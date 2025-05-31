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
    public partial class FormBooking : Form
    {
        private SqlCommand cmd;
        private SqlDataReader reader;

        // 2) Tambahkan semua sekaligus

        public FormBooking()
        {
            InitializeComponent();

        }
        SqlConnection conn = DatabaseHelper.GetConnection();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormPemesanan_Load(object sender, EventArgs e)
        {
            ButtonStyler.SetFlatStyle(newBookMenu, historyMennu, logoutMennu, paymentMenu);
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;

            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Alat WHERE jenis = 'Alat Musik Utama'", conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                string nama = reader1["nama"].ToString();
                decimal harga = reader1.GetDecimal(reader1.GetOrdinal("harga_sewa"));
                // misal format mata uang Indonesia
                string itemText = $"{nama} - Rp{harga:N0}/jam";
                instrumentCheckedListBox.Items.Add(itemText);
            }
            reader1.Close();
            cmd1.Dispose();

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Alat WHERE jenis = 'Peralatan Pendukung'", conn);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                string nama = reader2["nama"].ToString();
                decimal harga = reader2.GetDecimal(reader2.GetOrdinal("harga_sewa"));
                // misal format mata uang Indonesia
                string itemText = $"{nama} - Rp{harga:N0}/jam";
                extraCheckedListBox.Items.Add(itemText);
            }
            reader2.Close();
            cmd2.Dispose();

            SqlCommand cmd3 = new SqlCommand("SELECT * FROM RuangStudio WHERE status = 'Tersedia'", conn);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                string nama = reader3["nama"].ToString();
                decimal harga = reader3.GetDecimal(reader3.GetOrdinal("harga"));
                // misal format mata uang Indonesia
                string itemText = $"{nama} - Rp{harga:N0}/jam";
                studioComboBox.Items.Add(itemText);
            }
            reader3.Close();
            cmd3.Dispose();
            conn.Close();


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validasi studio
            if (string.IsNullOrWhiteSpace(studioComboBox.Text))
            {
                MessageBox.Show("Pilih studio terlebih dahulu.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi nama band
            if (string.IsNullOrWhiteSpace(nameInp.Text))
            {
                MessageBox.Show("Masukkan nama band.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi durasi > 0
            if (durInp.Value <= 0)
            {
                MessageBox.Show("Durasi harus lebih dari 0.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Jika sudah lolos validasi, lanjutkan proses penyimpanan
            string namaStudio = studioComboBox.Text;
            string namaBand = nameInp.Text;
            string tanggal = datePicker.Value.ToString("yyyy-MM-dd");
            string jam = timePicker.Value.ToString("HH:mm:ss");
            decimal durasi = durInp.Value;

            decimal hargaStudio = 0m;
            if (namaStudio.Contains("-"))
            {
                string[] parts = namaStudio.Split('-');
                string hargaStudioStr = parts[parts.Length - 1].Trim();
                hargaStudioStr = hargaStudioStr.Replace("Rp", "")
                                               .Replace("/jam", "")
                                               .Replace(".", "")
                                               .Trim();

                decimal.TryParse(hargaStudioStr, NumberStyles.Any, CultureInfo.InvariantCulture, out hargaStudio);
            }

            decimal totalTarifAlat = instrumentCheckedListBox.CheckedItems
                .Cast<string>()
                .Select(item =>
                {
                    string hargaStr = item.Split('-')[1].Trim();
                    hargaStr = hargaStr.Replace("Rp", "")
                                       .Replace("/jam", "")
                                       .Replace(".", "")
                                       .Trim();
                    if (decimal.TryParse(hargaStr, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal harga))
                        return harga;
                    else
                        return 0m;
                })
                .Sum();

            decimal totalTarifAksesori = extraCheckedListBox.CheckedItems
                .Cast<string>()
                .Select(item =>
                {
                    string hargaStr = item.Split('-')[1].Trim();
                    hargaStr = hargaStr.Replace("Rp", "")
                                       .Replace("/jam", "")
                                       .Replace(".", "")
                                       .Trim();
                    if (decimal.TryParse(hargaStr, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal harga))
                        return harga;
                    else
                        return 0m;
                })
                .Sum();

            decimal totalTarif = (hargaStudio + totalTarifAlat + totalTarifAksesori) * durasi;

            // Menyimpan nama barang alat
            string alatNames = string.Join(";", instrumentCheckedListBox.CheckedItems
                .Cast<string>()
                .Select(item => item));

            // Menyimpan nama barang aksesori
            string aksesoriNames = string.Join(";", extraCheckedListBox.CheckedItems
                .Cast<string>()
                .Select(item => item));

            // Gabungkan nama-nama alat dan aksesori
            string semuaNamaBarang = alatNames + (alatNames.Length > 0 && aksesoriNames.Length > 0 ? "; " : "") + aksesoriNames;

            cmd = new SqlCommand("INSERT INTO Booking(id_operator, nama_studio, nama_band, alat_musik_tambahan, aksesoris_tambahan, jam_mulai,durasi, tanggal_pemesanan, total_biaya) VALUES(@id_operator, @nama_studio, @nama_band, @alat_musik_tambahan, @aksesoris_tambahan, @jam_mulai,@durasi, @tanggal_pemesanan, @total_biaya)", conn);

            cmd.Parameters.AddWithValue("@id_operator", UserSession.UserID);
            cmd.Parameters.AddWithValue("@nama_studio", namaStudio);
            cmd.Parameters.AddWithValue("@nama_band", namaBand);
            cmd.Parameters.AddWithValue("@alat_musik_tambahan", alatNames);
            cmd.Parameters.AddWithValue("@aksesoris_tambahan", aksesoriNames);
            cmd.Parameters.AddWithValue("@jam_mulai", jam);
            cmd.Parameters.AddWithValue("@durasi", durasi);
            cmd.Parameters.AddWithValue("@tanggal_pemesanan", tanggal);
            cmd.Parameters.AddWithValue("@total_biaya", totalTarif);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data berhasil ditambahkan");
        }

        private void button2_Click(object sender, EventArgs e)
        {


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
