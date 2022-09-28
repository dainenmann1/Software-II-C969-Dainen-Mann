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
    class DBHelp
    {
        //VARIABLES
        public static string connStr = "Host=localhost;Port=3306;Database=client_schedule;Username=sqlUser;Password=Passw0rd!";
        public static List<Appointment> appointmentList = new List<Appointment>();
        private static Dictionary<int, Hashtable> _appointments = new Dictionary<int, Hashtable>();
        public static int UserID { get; set; }
        public static string UserName { get; set; }
        public static List<MySqlParameter> spl = new List<MySqlParameter>();
        public static string ConnStr {get; set;}


        public static Dictionary<int, Hashtable> getAppts()
        {
            return _appointments;
        }

        public static void setAppts(Dictionary<int, Hashtable> appointments)
        {
            _appointments = appointments;
        }


        public static string cTimestamp()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        }
        public static string DateSQLFormat(DateTime dateValue)
        {
            string formatForMySql = dateValue.ToString("yyyy-MM-dd HH:mm");

            return formatForMySql;
        }

        public static DataTable Schedule(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("message", nameof(id));
            }

            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string query = $"SELECT (select customerName from customer where customerId = appointment.customerId) as 'Customer',  type as 'Type', start as 'Start Time', end as 'End Time', createdBy as 'Created By', location as 'Location', title as 'Title' FROM appointment order by start;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            foreach (DataRow row in dt.Rows)
            {
                DateTime utcStart = Convert.ToDateTime(row["Start Time"]);
                DateTime utcEnd = Convert.ToDateTime(row["End Time"]);
                row["Start Time"] = TimeZone.CurrentTimeZone.ToLocalTime(utcStart);
                row["End Time"] = TimeZone.CurrentTimeZone.ToLocalTime(utcEnd);
            }

            conn.Close();
            return dt;
        }
        public static int cID(string table)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT {table + "Id"} FROM {table}", conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<int> idList = new List<int>();
            while (reader.Read())
            {
                idList.Add(Convert.ToInt32(reader[0]));
            }
            reader.Close();
            conn.Close();
            return newID(idList);
        }

        public static DataTable FirstCal(string filter, bool week)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string query = week ? $"SELECT (select customerName from customer where customerId = appointment.customerId) as 'Customer',  customerId as 'Customer Id', title as 'Title', type as 'Type', start as 'Start Time', end as 'End Time', location as 'Location' FROM appointment where start < '{filter}' and end < '{filter}'  and end > now() order by start;"
                : $"SELECT  (select customerName from customer where customerId = appointment.customerId) as 'Customer', customerId as 'Customer Id', title as 'Title', type as 'Type', start as 'Start Time', end as 'End Time', location as 'Location' FROM appointment where start < '{filter}' and end < '{filter}' and end > now() order by start;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            foreach (DataRow row in dt.Rows)
            {
                DateTime utcStart = Convert.ToDateTime(row["Start Time"]);
                DateTime utcEnd = Convert.ToDateTime(row["End Time"]);
                row["Start Time"] = TimeZone.CurrentTimeZone.ToLocalTime(utcStart);
                row["End Time"] = TimeZone.CurrentTimeZone.ToLocalTime(utcEnd);
            }

            conn.Close();
            return dt;

        }
        static public int createRec(string timestamp, string userName, string table, string partOfQuery, int userId = 0)
        {
            int recId = cID(table);
            string recInsert;
            if (userId == 0)
            {
                recInsert = $"INSERT INTO {table}" +
                $" VALUES ('{recId}', {partOfQuery}, '{timestamp}', '{userName}', '{timestamp}', '{userName}')";
            }
            else
            {
                recInsert = $"INSERT INTO {table} (appointmentId, customerId, title, start, end, type, userId, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                $" VALUES ('{recId}', {partOfQuery}, '{userId}', '{timestamp}', '{userName}', '{timestamp}', '{userName}')";
            }

            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(recInsert, conn);
            cmd.ExecuteNonQuery();

            return recId;
        }

        public static int newID(List<int> idList)
        {
            int highestID = 0;
            foreach (int id in idList)
            {
                if (id > highestID)
                    highestID = id;
            }
            return highestID + 1;
        }
        static public int findCustomer(string search)
        {
            int customerId;
            string query;
            if (int.TryParse(search, out customerId))
            {
                query = $"SELECT customerId FROM customer WHERE customerId = '{search.ToString()}'";
            }
            else
            {
                query = $"SELECT customerId FROM customer WHERE customerName LIKE '{search}'";
            }
            MySqlConnection c = new MySqlConnection(DBHelp.connStr);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                rdr.Read();
                customerId = Convert.ToInt32(rdr[0]);
                rdr.Close(); c.Close();
                return customerId;
            }
            return 0;
        }

        static public Dictionary<string, string> getCustomerDetails(int customerId)
        {
            string query = $"SELECT * FROM customer WHERE customerId = '{customerId.ToString()}'";
            MySqlConnection c = new MySqlConnection(DBHelp.connStr);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();

            Dictionary<string, string> customerDict = new Dictionary<string, string>();
            // Customer Table Details
            customerDict.Add("customerName", rdr[1].ToString());
            customerDict.Add("addressId", rdr[2].ToString());
            customerDict.Add("active", rdr[3].ToString());
            rdr.Close();

            query = $"SELECT * FROM address WHERE addressId = '{customerDict["addressId"]}'";
            cmd = new MySqlCommand(query, c);
            rdr = cmd.ExecuteReader();
            rdr.Read();

            // Address Table Details
            customerDict.Add("address", rdr[1].ToString());
            customerDict.Add("cityId", rdr[3].ToString());
            customerDict.Add("zip", rdr[4].ToString());
            customerDict.Add("phone", rdr[5].ToString());
            rdr.Close();

            query = $"SELECT * FROM city WHERE cityId = '{customerDict["cityId"]}'";
            cmd = new MySqlCommand(query, c);
            rdr = cmd.ExecuteReader();
            rdr.Read();

            // City Table Details
            customerDict.Add("city", rdr[1].ToString());
            customerDict.Add("countryId", rdr[2].ToString());
            rdr.Close();

            query = $"SELECT * FROM country WHERE countryId = '{customerDict["countryId"]}'";
            cmd = new MySqlCommand(query, c);
            rdr = cmd.ExecuteReader();
            rdr.Read();

            // Country Table Details
            customerDict.Add("country", rdr[1].ToString());
            rdr.Close();
            c.Close();

            return customerDict;
        }

        static public Dictionary<string, string> getAppointmentDetails(string appointmentId)
        {
            string query = $"SELECT * FROM appointment WHERE appointmentId = '{appointmentId}'";
            MySqlConnection c = new MySqlConnection(DBHelp.connStr);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();

            Dictionary<string, string> appointmentDict = new Dictionary<string, string>();
            // Customer Table Details
            appointmentDict.Add("appointmentId", appointmentId);
            appointmentDict.Add("customerId", rdr[1].ToString());
            appointmentDict.Add("type", rdr[13].ToString());
            appointmentDict.Add("start", rdr[7].ToString());
            appointmentDict.Add("end", rdr[8].ToString());
            rdr.Close();

            return appointmentDict;
        }

        static public string ConvertToTimezone(string dateTime)
        {
            DateTime utcDateTime = DateTime.Parse(dateTime.ToString());
            DateTime localDateTime = utcDateTime.ToLocalTime();

            return localDateTime.ToString("yyyy-MM-dd hh:mm:ss");
        }

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

    }
}
