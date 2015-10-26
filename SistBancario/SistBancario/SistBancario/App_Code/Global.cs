using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Timers;
using System.Web;

/// <summary>
///     Summary description for Global
/// </summary>
public static class Global
{
    public static string Connectionstring =
    "Data Source=tcp: 193.136.175.33\\SQLSERVER2012,8293;" +
    "Initial Catalog=p4g10;" +
    "Persist Security Info=True;" +
    // Alterar login
    "User ID=p4g10;" +
    "Password=12345";

    public static SqlConnection Conn = new SqlConnection(Connectionstring);

    public static int getLastID(object sender, EventArgs e, string tablename, string columnname)
    {
        int lastID = 0;

        try
        {
            Global.Conn.Open();

            // create a SqlCommand object for this connection
            SqlCommand command = Global.Conn.CreateCommand();
            command.CommandText = "SELECT " + columnname + " FROM " + tablename;
            command.CommandType = CommandType.Text;

            // execute the command that returns a SqlDataReader
            var reader = command.ExecuteReader();

            // the results
            while (reader.Read())
            {
                if (lastID < reader.GetInt32(0))
                    lastID = reader.GetInt32(0);
            }

            // close the connection
            reader.Close();
            Global.Conn.Close();
        }
        catch (Exception)
        {
            Global.Conn.Close();
        }

        return lastID + 1;
    }

    public static Boolean exists(object sender, EventArgs e, string tablename, string columnname, string value)
    {
        int count = 0;

        try
        {
            Global.Conn.Open();

            // create a SqlCommand object for this connection
            SqlCommand command = Global.Conn.CreateCommand();
            command.CommandText = "SELECT " + columnname + " FROM " + tablename + " WHERE " + columnname + " = " + value;
            command.CommandType = CommandType.Text;

            // execute the command that returns a SqlDataReader
            var reader = command.ExecuteReader();

            // the results
            while (reader.Read())
            {
                count++;
            }

            // close the connection
            reader.Close();
            Global.Conn.Close();
        }
        catch (Exception)
        {
            Global.Conn.Close();
        }

        if (count == 0)
        {
            return false;
        }

        return true;
    }
}