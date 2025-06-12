using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TokoOlehOlehBarokah;

namespace StudioMusik
{
    public partial class KelolaOperator : Form
    {
        public KelolaOperator()
        {
            InitializeComponent();
        }

        SqlConnection conn = DatabaseHelper.GetConnection();
        SqlCommand cmd;

        private void LoadData()
        {
            cmd = new SqlCommand("EXEC usp_SelectAllFromTable @TableName = 'Operator', @OrderColumn = 'id_operator',  @SortDirection = 'ASC'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridViewOperator.DataSource = dt;
        }

        private void Clear()
        {
            idBox.Text = "";
            nameInp.Text = "";
            usnInp.Text = "";
            pwdInp.Text = "";
        }

        private bool ValidateOperatorInput()
        {
            if (string.IsNullOrWhiteSpace(nameInp.Text))
            {
                MessageBox.Show("Nama lengkap harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nameInp.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(usnInp.Text))
            {
                MessageBox.Show("Username harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usnInp.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(pwdInp.Text))
            {
                MessageBox.Show("Password harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pwdInp.Focus();
                return false;
            }

            return true;
        }

        private void KelolaOperator_Load(object sender, EventArgs e)
        {
        }

        private void KelolaOperator_Load_1(object sender, EventArgs e)
        {
            LoadData();

        }

        private void dataGridViewOperator_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            {
                if (e.RowIndex < 0) return;

                var row = dataGridViewOperator.Rows[e.RowIndex];

                idBox.Text = row.Cells["id_operator"].Value.ToString();
                nameInp.Text = row.Cells["nama_lengkap"].Value.ToString();
                usnInp.Text = row.Cells["username"].Value.ToString();
                pwdInp.Text = row.Cells["password"].Value.ToString();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateOperatorInput()) return;

            string nama = nameInp.Text;
            string username = usnInp.Text;
            string password = pwdInp.Text;

            using (SqlCommand cmd = new SqlCommand(
                "INSERT INTO Operator (nama_lengkap, username, password) VALUES (@nama, @username, @password)",
                conn))
            {
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Data berhasil ditambahkan");
            LoadData();
            Clear();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idBox.Text))
            {
                MessageBox.Show("Pilih data yang akan dihapus.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand($"DELETE FROM Operator WHERE id_operator = @id", conn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idBox.Text));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data berhasil dihapus");
                LoadData();
                Clear();
            }
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idBox.Text))
            {
                MessageBox.Show("Pilih data yang akan diupdate.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateOperatorInput()) return;

            cmd = new SqlCommand("UPDATE Operator SET nama_lengkap = @nama, username = @username, password = @password WHERE id_operator = @id", conn);

            cmd.Parameters.AddWithValue("@nama", nameInp.Text);
            cmd.Parameters.AddWithValue("@username", usnInp.Text);
            cmd.Parameters.AddWithValue("@password", pwdInp.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idBox.Text));

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data berhasil diupdate");
            LoadData();
            Clear();
        }

        private void resBtn_Click(object sender, EventArgs e)
        {
            Clear();
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
            Logout.FormLogout(this);
        }
        private void operatorMenu_Click(object sender, EventArgs e)
        {
            KelolaOperator kelolaOperator = new KelolaOperator();
            kelolaOperator.Show();
            this.Hide();
        }




    }
}
