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
    public partial class PengaturanStudio : Form
    {
        public PengaturanStudio()
        {
            InitializeComponent();
        }
        SqlConnection conn = DatabaseHelper.GetConnection();
        SqlCommand cmd;

        private void LoadData()
        {
            cmd = new SqlCommand("SELECT * FROM RuangStudio ORDER BY id_studio ASC", conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridViewStudio.RowTemplate.Height = 75;
            dataGridViewStudio.DataSource = dt;
        }
        private void Clear()
        {
            idBox.Text = "";
            nameInp.Text = "";
            descInp.Text = "";
            priceInp.Value = 0;
            avlCheckBox.Checked = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PengaturanStudio_Load(object sender, EventArgs e)
        {
            ButtonStyler.SetFlatStyle(button7, button8, button4, button11, menuOperator);
            LoadData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Informasi", MessageBoxButtons.YesNo,
           MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string id = idBox.Text;
                SqlCommand cmd = new SqlCommand($"DELETE FROM RuangStudio where id_studio ='{id}'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Berhasil menghapus data");
                LoadData();

            }
            else
            {
                MessageBox.Show("Gagal menghapus data");
                LoadData();

            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridViewStudio.Rows[e.RowIndex];

            idBox.Text = row.Cells["id_studio"].Value.ToString();

            nameInp.Text = row.Cells["nama"].Value.ToString();
            descInp.Text = row.Cells["deskripsi"].Value.ToString();
            priceInp.Value = Convert.ToDecimal(row.Cells["harga"].Value);
            avlCheckBox.Checked = row.Cells["status"].Value.ToString() == "Tersedia" ? true : false;
        }

        private bool ValidateStudioInput()
        {
            if (string.IsNullOrWhiteSpace(nameInp.Text))
            {
                MessageBox.Show("Nama studio harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nameInp.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(descInp.Text))
            {
                MessageBox.Show("Deskripsi studio harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                descInp.Focus();
                return false;
            }

            if (priceInp.Value <= 0)
            {
                MessageBox.Show("Harga harus lebih dari 0.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                priceInp.Focus();
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateStudioInput()) return;

            string nama = nameInp.Text;
            string deskripsi = descInp.Text;
            decimal harga = priceInp.Value;
            bool tersedia = avlCheckBox.Checked;

            using (SqlCommand cmd = new SqlCommand(
                "INSERT INTO RuangStudio (nama, deskripsi, harga, status) VALUES (@nama, @deskripsi, @harga, @status)",
                conn))
            {
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@deskripsi", deskripsi);
                cmd.Parameters.AddWithValue("@harga", harga);
                cmd.Parameters.AddWithValue("@status", tersedia ? "Tersedia" : "Tidak Tersedia");

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Data berhasil ditambahkan");
            LoadData();
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idBox.Text))
            {
                MessageBox.Show("Pilih data yang akan diupdate.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateStudioInput()) return;

            cmd = new SqlCommand("UPDATE RuangStudio SET nama = @nama, deskripsi = @deskripsi, harga = @harga, status = @status WHERE id_studio = @id", conn);

            cmd.Parameters.AddWithValue("@nama", nameInp.Text);
            cmd.Parameters.AddWithValue("@deskripsi", descInp.Text);
            cmd.Parameters.AddWithValue("@harga", priceInp.Value);
            cmd.Parameters.AddWithValue("@id", idBox.Text);
            cmd.Parameters.AddWithValue("@status", avlCheckBox.Checked ? "Tersedia" : "Tidak Tersedia");

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data berhasil diupdate");
            LoadData();
            Clear();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void descInp_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            PengaturanStudio pengaturanStudio = new PengaturanStudio();
            pengaturanStudio.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RiwayatBookingAdmin riwayatPemesananAdmin = new RiwayatBookingAdmin();
            riwayatPemesananAdmin.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            KelolaAlatMusik menuControl = new KelolaAlatMusik();
            menuControl.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            KelolaOperator kelolaOperator = new KelolaOperator();
            kelolaOperator.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Laporan laporan = new Laporan();
            laporan.Show();
            this.Hide();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            Logout.FormLogout(this);

        }
    }
}
