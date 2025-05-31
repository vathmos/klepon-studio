using System;
using System.Data.SqlClient;

public static class DatabaseHelper
{
    private static readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudioMusik;Integrated Security=True;Connect Timeout=30;Encrypt=False";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}
