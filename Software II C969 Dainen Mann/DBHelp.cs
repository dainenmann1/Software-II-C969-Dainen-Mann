using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Software_II_C969_Dainen_Mann
{
	class DBHelp
	{
		private static int _currentUserId;
		private static string _currentUserName;
		public static string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
		MySqlConnection conn = new MySqlConnection(constr);

		public static int getCurrentUserId()
		{
			return _currentUserId;
		}
		public static void setCurrentUserId(int currentUserId)
		{
			_currentUserId = currentUserId;
		}
		public static string currentUserName { get; set; }
	}
}
