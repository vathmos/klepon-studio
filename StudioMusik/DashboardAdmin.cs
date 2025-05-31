using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TokoOlehOlehBarokah;

namespace StudioMusik
{
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PengaturanStudio pengaturanStudio = new PengaturanStudio();
            pengaturanStudio.Show();
            this.Hide();
        }

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {
            settingMenu.FlatStyle = FlatStyle.Flat;
            historyMenu.FlatStyle = FlatStyle.Flat;
            reportMenu.FlatStyle = FlatStyle.Flat;
            instrumentMenu.FlatStyle = FlatStyle.Flat;
            operatorMenu.FlatStyle = FlatStyle.Flat;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KelolaOperator kelolaOperator = new KelolaOperator();
            kelolaOperator.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KelolaAlatMusik menuControl = new KelolaAlatMusik();
            menuControl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RiwayatBookingAdmin riwayatPemesananAdmin = new RiwayatBookingAdmin();
            riwayatPemesananAdmin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Laporan laporan = new Laporan();
            laporan.Show();
            this.Hide();
        }

        private void logoutMenu_Click(object sender, EventArgs e)
        {
            Logout.FormLogout(this);

        }
    }
}
