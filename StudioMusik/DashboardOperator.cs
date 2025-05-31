using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudioMusik
{
    public partial class DashboardOperator : Form
    {
        public DashboardOperator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBooking formPemesanan = new FormBooking();
            formPemesanan.Show();
            this.Hide();
        }

        private void DashboardOperator_Load(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button2.FlatStyle = FlatStyle.Flat;
            button3.FlatStyle = FlatStyle.Flat;
            button4.FlatStyle = FlatStyle.Flat;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Logout.FormLogout(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormBooking formPemesanan = new FormBooking();
            formPemesanan.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPembayaran formPembayaran = new FormPembayaran();
            formPembayaran.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RiwayatBooking riwayatPemesanan = new RiwayatBooking();
            riwayatPemesanan.Show();
            this.Hide();
        }
    }
}
