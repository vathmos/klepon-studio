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
using TokoOlehOlehBarokah;

namespace StudioMusik
{
    public partial class RiwayatBookingAdmin : Form
    {
        public RiwayatBookingAdmin()
        {
            InitializeComponent();
        }

        SqlConnection conn = DatabaseHelper.GetConnection();
        SqlCommand cmd;
        private void Search(string searchValue)
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM Booking WHERE status_pembayaran = 'dibayar' AND concat" +
            $"(id_booking,nama_band, nama_studio , status_pembayaran, alat_musik_tambahan, aksesoris_tambahan, total_biaya, jam_mulai, tanggal_pemesanan) like '%{searchValue}%'", conn);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            historyDataGridView.DataSource = dt;
        }

        private void LoadData()
        {
            cmd = new SqlCommand("SELECT * FROM Booking WHERE status_pembayaran = 'dibayar' ORDER BY id_booking ASC", conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            historyDataGridView.DataSource = dt;
        }


        private void searchInp_TextChanged(object sender, EventArgs e)
        {
            Search(searchBox.Text);
        }

        private void RiwayatPemesanan_Load(object sender, EventArgs e)
        {

        }

        private void newBookMenu_Click(object sender, EventArgs e)
        {
            ;
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

        private void newBookMenu_Click_1(object sender, EventArgs e)
        {
            FormBooking formPemesanan = new FormBooking();
            formPemesanan.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void reportMenu_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RiwayatPemesananAdmin_Load(object sender, EventArgs e)
        {
            ButtonStyler.SetFlatStyle();
            LoadData();
        }

        private void logoutMenu_Click_1(object sender, EventArgs e)
        {
            Logout.FormLogout(this);
        }
    }
}

