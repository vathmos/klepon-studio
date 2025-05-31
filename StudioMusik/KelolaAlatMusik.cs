using StudioMusik;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TokoOlehOlehBarokah
{
    public partial class KelolaAlatMusik : Form
    {
        public KelolaAlatMusik()
        {
            InitializeComponent();
            LoadData();
        }
        SqlConnection conn = DatabaseHelper.GetConnection();
        SqlCommand cmd;

        private void Clear()
        {
            idBox.Text = "";
            nameInp.Text = "";
            specInp.Text = "";
            priceInp.Value = 0;
            stockInp.Value = 0;
            typeComboBox.SelectedIndex = -1;

        }

        private void LoadData()
        {
            cmd = new SqlCommand("SELECT * FROM Alat ORDER BY id_alat ASC", conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.RowTemplate.Height = 75;
            dataGridView1.DataSource = dt;
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Informasi", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string id = idBox.Text;
                SqlCommand cmd = new SqlCommand($"DELETE FROM Alat where id_alat ='{id}'", conn);
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

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(nameInp.Text))
            {
                MessageBox.Show("Nama alat musik harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nameInp.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(specInp.Text))
            {
                MessageBox.Show("Spesifikasi harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                specInp.Focus();
                return false;
            }

            if (priceInp.Value <= 0)
            {
                MessageBox.Show("Harga sewa harus lebih dari 0.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                priceInp.Focus();
                return false;
            }

            if (stockInp.Value < 0)
            {
                MessageBox.Show("Stok tidak boleh kurang dari 0.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                stockInp.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(typeComboBox.Text))
            {
                MessageBox.Show("Jenis alat musik harus dipilih.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                typeComboBox.Focus();
                return false;
            }

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            cmd = new SqlCommand("INSERT INTO Alat(nama, stok, spesifikasi, harga_sewa, jenis) VALUES(@nama, @stok, @spesifikasi, @harga_sewa, @jenis)", conn);

            cmd.Parameters.AddWithValue("nama", nameInp.Text);
            cmd.Parameters.AddWithValue("stok", stockInp.Value);
            cmd.Parameters.AddWithValue("spesifikasi", specInp.Text);
            cmd.Parameters.AddWithValue("harga_sewa", priceInp.Value);
            cmd.Parameters.AddWithValue("jenis", typeComboBox.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data berhasil ditambahkan");
            LoadData();
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idBox.Text))
            {
                MessageBox.Show("Pilih data yang akan diupdate.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput()) return;

            cmd = new SqlCommand(
                "UPDATE Alat SET nama = @nama, stok = @stok, spesifikasi = @spesifikasi, harga_sewa = @harga_sewa, jenis = @jenis WHERE id_alat = @id_alat",
                conn);

            cmd.Parameters.AddWithValue("nama", nameInp.Text);
            cmd.Parameters.AddWithValue("stok", stockInp.Value);
            cmd.Parameters.AddWithValue("spesifikasi", specInp.Text);
            cmd.Parameters.AddWithValue("harga_sewa", priceInp.Value);
            cmd.Parameters.AddWithValue("jenis", typeComboBox.Text);
            cmd.Parameters.AddWithValue("id_alat", idBox.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data berhasil diupdate");
            LoadData();
            Clear();
        }



        private void Search(string searchValue)
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM OlehOleh where concat" +
            $"(Name, Description, Price, Origin, Weight, Availability) like '%{searchValue}%'", conn);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Data yang anda cari tidak ada");
            }
        }
        private void MenuControl_Load(object sender, EventArgs e)
        {
            ButtonStyler.SetFlatStyle(historyMenu, settingMenu, reportMenu, instrumentMenu, OperatorMenu);
        }

        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];

            idBox.Text = row.Cells["id_alat"].Value.ToString();
            nameInp.Text = row.Cells["nama"].Value.ToString();
            specInp.Text = row.Cells["spesifikasi"].Value.ToString();
            priceInp.Value = Convert.ToDecimal(row.Cells["harga_sewa"].Value);
            stockInp.Value = Convert.ToDecimal(row.Cells["stok"].Value);
            typeComboBox.Text = row.Cells["jenis"].Value.ToString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Clear();
        }


        private void button1_Click(object sender, EventArgs e)
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
        private void button7_Click(object sender, EventArgs e)
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
