using System;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Software_II_C969_Dainen_Mann
{
    static class DBHelp
    {
        //VARIABLES
        public static string connStr = "Host=localhost;Port=3306;Database=client_schedule;Username=sqlUser;Password=Passw0rd!";
        public static List<Appointment> appointmentList = new List<Appointment>();
        public static int UserID { get; set; }
        public static string UserName { get; set; }
        public static List<MySqlParameter> spl = new List<MySqlParameter>();
        public static string ConnStr {get; set;}


        //MySQL methods
        public static MySqlDataReader ExecuteReader(string query, List<MySqlParameter> spl, string connStr)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                if (conn.State == ConnectionState.Closed) { conn.Open(); }
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (spl.Count > 0) { cmd.Parameters.AddRange(spl.ToArray()); }
                    MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    spl.Clear();
                    return dr;
                }
            }
            catch (Exception ex)
            {
                spl.Clear();
                Logger.LogMessage("ErrorLog", ex.Message, "error", "SQL_ExecuteReader");
                return null;
            }
        }
        public static void ExecuteNonQuery(string query, List<MySqlParameter> spl, string connStr)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    if (conn.State == ConnectionState.Closed) { conn.Open(); }
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (spl.Count > 0) { cmd.Parameters.AddRange(spl.ToArray()); }
                        cmd.ExecuteNonQuery();
                        spl.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                spl.Clear();
                Logger.LogMessage("ErrorLog", ex.Message, "error", "SQL_ExecuteNonQuery");
            }
        }
        public static long GetCount(string query, List<MySqlParameter> spl, string connStr)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    if (conn.State == ConnectionState.Closed) { conn.Open(); }
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (spl.Count > 0) { cmd.Parameters.AddRange(spl.ToArray()); }
                        long count = (long)cmd.ExecuteScalar();
                        spl.Clear();
                        return count;
                    }
                }
            }
            catch (Exception ex)
            {
                spl.Clear();
                Logger.LogMessage("ErrorLog", ex.Message, "error", "SQL_GetCount");
                return 0;
            }
        }

        public static DataTable FillReports(string query, List<MySqlParameter> spl, string connStr)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    if (conn.State == ConnectionState.Closed) { conn.Open(); }
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (spl.Count > 0) { cmd.Parameters.AddRange(spl.ToArray()); }
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            spl.Clear();
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                spl.Clear();
                Logger.LogMessage("ErrorLog", ex.Message, "error", "SQL_FillDataTable");
                return null;
            }
        }
    }
}
