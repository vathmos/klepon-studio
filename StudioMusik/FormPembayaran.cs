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

namespace StudioMusik
{
    public partial class FormPembayaran : Form
    {
        public FormPembayaran()
        {
            InitializeComponent();
        }

        SqlConnection conn = DatabaseHelper.GetConnection();
        SqlCommand cmd;

        private void LoadData()
        {
            cmd = new SqlCommand("SELECT id_booking, nama_band, nama_studio , status_pembayaran, alat_musik_tambahan, aksesoris_tambahan, total_biaya, jam_mulai, tanggal_pemesanan FROM Booking WHERE status_pembayaran = 'pending' ORDER BY id_booking ASC", conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            BookingDataGridView.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ButtonStyler.SetFlatStyle(newBookMenu, historyMennu, logoutMennu, paymentMenu);
            LoadData();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = BookingDataGridView.Rows[e.RowIndex];

            idBox.Text = row.Cells["id_booking"].Value.ToString();
            decimal totalBiaya = Convert.ToDecimal(row.Cells["total_biaya"].Value);
            totalLabel.Text = "Rp" + totalBiaya.ToString("N0", new CultureInfo("id-ID"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validasi id booking dipilih
            if (string.IsNullOrWhiteSpace(idBox.Text))
            {
                MessageBox.Show("Pilih data booking terlebih dahulu.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi metode pembayaran dipilih
            if (!mbankingRadio.Checked && !ewalletRadio.Checked && !tunaiRadio.Checked)
            {
                MessageBox.Show("Pilih metode pembayaran.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi totalLabel harus ada nilai yang valid
            if (string.IsNullOrWhiteSpace(totalLabel.Text) || !decimal.TryParse(totalLabel.Text.Replace("Rp", "").Replace(".", ""), out decimal total))
            {
                MessageBox.Show("Total biaya tidak valid.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal jumlahBayar = payInp.Value;

            if (jumlahBayar < total)
            {
                MessageBox.Show("Uang yang dibayar kurang dari total biaya. Mohon input jumlah yang sesuai.", "Pembayaran Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string metodePembayaran = "";
            if (mbankingRadio.Checked)
                metodePembayaran = "M-Banking";
            else if (ewalletRadio.Checked)
                metodePembayaran = "E-Wallet";
            else if (tunaiRadio.Checked)
                metodePembayaran = "Tunai";

            // Hitung kembalian
            decimal kembalian = jumlahBayar - total;


            try
            {
                conn.Open();

                // Update pembayaran
                cmd = new SqlCommand("UPDATE Booking SET status_pembayaran = 'dibayar', metode_pembayaran = @metode_pembayaran, jumlah_bayar = @jumlah_bayar, kembalian = @kembalian WHERE id_booking = @id_booking", conn);
                cmd.Parameters.AddWithValue("metode_pembayaran", metodePembayaran);
                cmd.Parameters.AddWithValue("jumlah_bayar", jumlahBayar);
                cmd.Parameters.AddWithValue("kembalian", kembalian);
                cmd.Parameters.AddWithValue("id_booking", idBox.Text);
                cmd.ExecuteNonQuery();

                // Ambil data booking lagi dan assign ke BookingSession
                cmd = new SqlCommand("SELECT id_booking, nama_band, nama_studio,durasi, tanggal_pemesanan, alat_musik_tambahan, aksesoris_tambahan, total_biaya FROM Booking WHERE id_booking = @id_booking", conn);
                cmd.Parameters.AddWithValue("id_booking", idBox.Text);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        BookingSession.BookingID = Convert.ToInt32(reader["id_booking"]);
                        BookingSession.BandName = reader["nama_band"].ToString();
                        BookingSession.StudioName = reader["nama_studio"].ToString();
                        BookingSession.BookingDate = Convert.ToDateTime(reader["tanggal_pemesanan"]);
                        BookingSession.ExtraInstruments = reader["alat_musik_tambahan"].ToString();
                        BookingSession.ExtraTools = reader["aksesoris_tambahan"].ToString();
                        BookingSession.TotalCost = Convert.ToDecimal(reader["total_biaya"]);
                        BookingSession.Duration = Convert.ToInt32(reader["durasi"]);

                    }
                }

                MessageBox.Show("Data booking berhasil dikonfirmasi");
                LoadData();

                StrukPembayaran strukPembayaran = new StrukPembayaran();
                strukPembayaran.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat proses pembayaran: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }


        private void payInp_ValueChanged(object sender, EventArgs e)
        {
            returnLabel.Text = "Rp" + (payInp.Value - Convert.ToDecimal(totalLabel.Text.Replace("Rp", "").Replace(".", ""))).ToString("N0", new CultureInfo("id-ID"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            returnLabel.Text = "Rp" + (payInp.Value - Convert.ToDecimal(totalLabel.Text.Replace("Rp", "").Replace(".", ""))).ToString("N0", new CultureInfo("id-ID"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("DELETE FROM Booking WHERE id_booking = @id_booking", conn);
            cmd.Parameters.AddWithValue("id_booking", idBox.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data booking dibatalkan");
            LoadData();
        }

        private void newBookMenu_Click(object sender, EventArgs e)
        {
            FormBooking formPemesanan = new FormBooking();
            formPemesanan.Show();
            this.Hide();
        }

        private void paymentMenu_Click(object sender, EventArgs e)
        {
            FormPembayaran formPembayaran = new FormPembayaran();
            formPembayaran.Show();
            this.Hide();
        }

        private void historyMennu_Click(object sender, EventArgs e)
        {
            RiwayatBooking riwayatPemesanan = new RiwayatBooking();
            riwayatPemesanan.Show();
            this.Hide();
        }

        private void logoutMennu_Click(object sender, EventArgs e)
        {
            Logout.FormLogout(this);
        }
    }
}


