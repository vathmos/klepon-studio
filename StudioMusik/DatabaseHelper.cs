using System;
using System.Data.SqlClient;

public static class DatabaseHelper
{
    // Update with your actual connection string
    private static readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudioMusik;Integrated Security=True;Connect Timeout=30;Encrypt=False";

    // Reusable method to get a new SqlConnection
    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}
