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

namespace StudioMusik
{
    public partial class Jadwal : Form
    {
        public Jadwal()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlConnection conn = DatabaseHelper.GetConnection();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void Jadwal_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT nama_band, tanggal, waktu_mulai, waktu_selesai FROM Jadwal ORDER BY waktu_mulai ASC", conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridViewJadwal.DataSource = dt;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM Jadwal WHERE concat" +
$"(nama_band, tanggal, waktu_mulai, waktu_selesai) like '%{searchBox.Text}%'", conn);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dataGridViewJadwal.DataSource = dt;
        }
    }
}
