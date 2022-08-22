using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Software_II_C969_Dainen_Mann
{
	public partial class Login : Form
	{
		public string errorMessage = "The username and password do not match.";
		public Login()
		{
			InitializeComponent();

			if (CultureInfo.CurrentUICulture.LCID == 2058)
			{
				userLabel.Text = "Nombre de usuario";
				pwLabel.Text = "Contraseña";
				loginButton.Text = "Iniciar sesión";
				cancelButton.Text = "Cancelar";
			}
		}

		static public int loginUser(string userName, string password)
		{
			MySqlConnection conn = new MySqlConnection(DBHelp.connStr);
			conn.Open();
			MySqlCommand cmd = new MySqlCommand($"SELECT userId FROM user WHERE userName = '{userName}' AND password = '{password}'", conn);
			MySqlDataReader rdr = cmd.ExecuteReader();

			if (rdr.HasRows) 
			{
				rdr.Read();
				DBHelp.setUserId(Convert.ToInt32(rdr[0]));
				DBHelp.setUserName(userName);
				rdr.Close();
				conn.Close();
				return DBHelp.getUserId();
			}
			return 0;
		}
		private void userLabel_Click(object sender, EventArgs e)
		{

		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			if (loginUser(userBox.Text, pwBox.Text) != 0) 
			{
				this.Hide();
				
			}
		}

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
