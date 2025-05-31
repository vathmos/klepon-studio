using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudioMusik
{
    internal class Logout
    {
        public static void FormLogout(Form CurrentForm)
        {
            if (UserSession.UserID != 0 && !string.IsNullOrEmpty(UserSession.Role) && UserSession.Role == "Operator")
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmdLog = new SqlCommand("INSERT INTO dbo.Log (id_operator, jenis_aktivitas) VALUES (@id_operator, @jenis_aktivitas)", conn))
                    {
                        cmdLog.Parameters.AddWithValue("@id_operator", UserSession.UserID);
                        cmdLog.Parameters.AddWithValue("@jenis_aktivitas", "logout");
                        cmdLog.ExecuteNonQuery();
                    }
                }
            }

            UserSession.Clear();

            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            CurrentForm.Hide();
        }
    }
}
