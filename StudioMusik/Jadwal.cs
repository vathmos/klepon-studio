using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace StudioMusik
{
    public partial class Jadwal : Form
    {
        public Jadwal()
        {
            InitializeComponent();
        }

        // Asumsikan DatabaseHelper.GetConnection() mengembalikan SqlConnection yang valid
        SqlConnection conn = DatabaseHelper.GetConnection();
        SqlCommand cmd;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void Jadwal_Load(object sender, EventArgs e)
        {
            // Batch SQL untuk "return stok" + "delete jadwal yang sudah lewat".
            // Gunakan single‐quote di dalam SQL untuk semua literal.
            string batchReturnAndDelete =
                "BEGIN TRANSACTION; " +
                "  IF OBJECT_ID('tempdb..#TempPastJadwal') IS NOT NULL DROP TABLE #TempPastJadwal; " +
                "  SELECT j.id_jadwal, b.alat_musik_tambahan, b.aksesoris_tambahan " +
                "  INTO #TempPastJadwal " +
                "  FROM dbo.Jadwal j " +
                "  INNER JOIN dbo.Booking b ON j.id_booking = b.id_booking " +
                "  WHERE (CAST(j.tanggal AS DATETIME) + CAST(j.waktu_selesai AS DATETIME)) < GETDATE(); " +
                "  ;WITH AlatSplit AS ( " +
                "      SELECT tpj.id_jadwal, LTRIM(RTRIM(value)) AS raw_item " +
                "      FROM #TempPastJadwal tpj " +
                "      CROSS APPLY STRING_SPLIT(tpj.alat_musik_tambahan, ';') " +
                "      WHERE tpj.alat_musik_tambahan IS NOT NULL AND tpj.alat_musik_tambahan <> '' " +
                "      UNION ALL " +
                "      SELECT tpj.id_jadwal, LTRIM(RTRIM(value)) AS raw_item " +
                "      FROM #TempPastJadwal tpj " +
                "      CROSS APPLY STRING_SPLIT(tpj.aksesoris_tambahan, ';') " +
                "      WHERE tpj.aksesoris_tambahan IS NOT NULL AND tpj.aksesoris_tambahan <> '' " +
                "  ), NamaAlat AS ( " +
                "      SELECT id_jadwal, " +
                "             CASE " +
                "               WHEN CHARINDEX(' - ', raw_item) > 0 " +
                "                 THEN LEFT(raw_item, CHARINDEX(' - ', raw_item) - 1) " +
                "               ELSE raw_item END AS nama_alat " +
                "      FROM AlatSplit " +
                "  ) " +
                "  UPDATE a " +
                "  SET a.stok = a.stok + 1 " +
                "  FROM dbo.Alat a " +
                "  INNER JOIN NamaAlat na ON a.nama = na.nama_alat; " +
                "  DELETE j " +
                "  FROM dbo.Jadwal j " +
                "  INNER JOIN #TempPastJadwal tpj ON j.id_jadwal = tpj.id_jadwal; " +
                "COMMIT TRANSACTION;";

            try
            {
                conn.Open();

                // Eksekusi batch untuk mengembalikan stok dan menghapus jadwal lewat
                using (SqlCommand cmdBatch = new SqlCommand(batchReturnAndDelete, conn))
                {
                    cmdBatch.CommandTimeout = 120; // Jika perlu waktu lebih lama, naikkan timeout
                    cmdBatch.ExecuteNonQuery();
                }

                // Setelah batch, load ulang data Jadwal yang tersisa (belum lewat)
                string selectJadwal =
                    "SELECT nama_band, nama_studio, tanggal, waktu_mulai, waktu_selesai " +
                    "FROM dbo.Jadwal " +
                    "ORDER BY waktu_mulai ASC;";

                cmd = new SqlCommand(selectJadwal, conn);
                SqlDataAdapter adapter = new SqlDataAdapter
                {
                    SelectCommand = cmd
                };
                DataTable dt = new DataTable();
                dt.Clear();
                adapter.Fill(dt);
                dataGridViewJadwal.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Terjadi kesalahan saat memuat jadwal: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                conn.Close();
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            // Pencarian dengan CONCAT dan LIKE, gunakan single‐quote untuk literal
            string sqlSearch =
                "SELECT nama_band, nama_studio, tanggal, waktu_mulai, waktu_selesai " +
                "FROM dbo.Jadwal " +
                "WHERE CONCAT(" +
                "  nama_band, '|', " +
                "  nama_studio, '|', " +
                "  CONVERT(VARCHAR(10), tanggal, 120), '|', " +
                "  CONVERT(VARCHAR(8), waktu_mulai, 108), '|', " +
                "  CONVERT(VARCHAR(8), waktu_selesai, 108)" +
                ") LIKE @keyword " +
                "ORDER BY waktu_mulai ASC;";

            try
            {
                using (SqlCommand cmdSearch = new SqlCommand(sqlSearch, conn))
                {
                    // Parameter @keyword tetap disertakan dengan tanda '%' untuk LIKE
                    cmdSearch.Parameters.AddWithValue("@keyword", "%" + searchBox.Text + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter
                    {
                        SelectCommand = cmdSearch
                    };
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewJadwal.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Terjadi kesalahan saat mencari: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
