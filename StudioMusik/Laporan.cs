using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TokoOlehOlehBarokah;

namespace StudioMusik
{
    public partial class Laporan : Form
    {
        public Laporan()
        {
            InitializeComponent();
        }

        SqlCommand cmd1;
        SqlCommand cmd2;
        SqlConnection conn = DatabaseHelper.GetConnection();

        private void LoadData()
        {
            try
            {
                conn.Open();
                cmd1 = new SqlCommand("SELECT id_booking, nama_band, nama_studio, total_biaya FROM Booking WHERE status_pembayaran = 'dibayar' AND tanggal_pemesanan = @tanggal_pemesanan ORDER BY id_booking ASC", conn);
                cmd2 = new SqlCommand("SELECT SUM(total_biaya) AS total_biaya FROM Booking WHERE status_pembayaran = 'dibayar' AND tanggal_pemesanan = @tanggal_pemesanan", conn);

                cmd1.Parameters.AddWithValue("@tanggal_pemesanan", reportDateTimePicker.Value.Date);
                cmd2.Parameters.AddWithValue("@tanggal_pemesanan", reportDateTimePicker.Value.Date);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                dt.Clear();
                adapter.Fill(dt);
                reportDataGridView.DataSource = dt;
                cmd1.Dispose();

                SqlDataReader reader = cmd2.ExecuteReader();

                if (reader.Read() && reader["total_biaya"] != DBNull.Value)
                {
                    decimal totalBiaya = Convert.ToDecimal(reader["total_biaya"]);
                    totalLabel.Text = "Rp" + totalBiaya.ToString("N0", new CultureInfo("id-ID"));
                }
                else
                {
                    totalLabel.Text = "Total Pendapatan: Rp. 0";
                }

                reader.Close();
                cmd2.Dispose();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Terjadi kesalahan saat mengambil data booking: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                totalLabel.Text = "Total Pendapatan: Rp. 0";
                reportDataGridView.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kesalahan tidak terduga: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                totalLabel.Text = "Total Pendapatan: Rp. 0";
                reportDataGridView.DataSource = null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Laporan_Load(object sender, EventArgs e)
        {

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void instrumentMenu_Click(object sender, EventArgs e)
        {
            KelolaAlatMusik kelolaAlatMusik = new KelolaAlatMusik();
            kelolaAlatMusik.Show();
            this.Hide();
        }

        private void historyMenu_Click(object sender, EventArgs e)
        {
            RiwayatBookingAdmin riwayatPemesananAdmin = new RiwayatBookingAdmin();
            riwayatPemesananAdmin.Show();
            this.Hide();
        }

        private void reportMenu_Click_1(object sender, EventArgs e)
        {
            Laporan laporan = new Laporan();
            laporan.Show();
            this.Hide();
        }
        private void settingMenu_Click(object sender, EventArgs e)
        {
            PengaturanStudio pengaturanStudio = new PengaturanStudio();
            pengaturanStudio.Show();
            this.Hide();
        }

        private void logoutMenu_Click(object sender, EventArgs e)
        {
            KelolaOperator kelolaOperator = new KelolaOperator();
            kelolaOperator.Show();
            this.Hide();
        }

        private void logoutMenu_Click_1(object sender, EventArgs e)
        {
            Logout.FormLogout(this);

        }
    }
}
