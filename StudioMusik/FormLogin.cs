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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StudioMusik
{
    public partial class FormLogin : Form
    {
        private SqlDataReader reader;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login(string name, string password, string role)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = $"SELECT * FROM {role} WHERE Username = @username AND Password = @password";
                using (SqlCommand cmd1 = new SqlCommand(query, conn))
                {
                    cmd1.Parameters.AddWithValue("@username", name);
                    cmd1.Parameters.AddWithValue("@password", password);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd1);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count != 0)
                    {
                        string idColumn = role == "Operator" ? "id_operator" : "id_admin";
                        string queryId = $"SELECT {idColumn} FROM {role} WHERE Username = @username";

                        using (SqlCommand cmd2 = new SqlCommand(queryId, conn))
                        {
                            cmd2.Parameters.AddWithValue("@username", name);

                            using (SqlDataReader reader = cmd2.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    UserSession.Username = name;
                                    UserSession.Role = role;
                                    UserSession.UserID = Convert.ToInt32(reader[idColumn]);
                                }
                            }
                        }

                        MessageBox.Show("Berhasil melakukan login");

                        if (role == "Operator")
                        {
                            using (SqlCommand cmdLog = new SqlCommand("INSERT INTO dbo.Log (id_operator, jenis_aktivitas) VALUES (@id_operator, @jenis_aktivitas)", conn))
                            {
                                cmdLog.Parameters.AddWithValue("@id_operator", UserSession.UserID);
                                cmdLog.Parameters.AddWithValue("@jenis_aktivitas", "login");
                                cmdLog.ExecuteNonQuery();
                            }

                            this.Hide();
                            DashboardOperator dashboardOperator = new DashboardOperator();
                            dashboardOperator.Show();
                        }
                        else if (role == "Admin")
                        {
                            this.Hide();
                            DashboardAdmin dashboardAdmin = new DashboardAdmin();
                            dashboardAdmin.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gagal melakukan login");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = nameInput.Text.Trim();
            string password = pwdInput.Text.Trim();
            string role = roleComboBox.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nameInput.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pwdInput.Focus();
                return;
            }

            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Pilih role terlebih dahulu.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                roleComboBox.Focus();
                return;
            }

            Login(username, password, role);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Jadwal jadwal = new Jadwal();
            jadwal.Show();
            this.Hide();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pwdInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
