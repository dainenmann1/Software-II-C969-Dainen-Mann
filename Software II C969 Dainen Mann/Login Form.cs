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
		public string errorMessage = "The username and password did not match. Please try again";
		public Login()
		{
			InitializeComponent();

			//if statement for Spanish (Mexico) language
			if (CultureInfo.CurrentUICulture.LCID == 2058)
            {
				this.Text = "Acceso";
				userLabel.Text = "Nombre de usuario";
				pwLabel.Text = "Clave";
				loginButton.Text = "Acceso";
				cancelButton.Text = "Cancelar";
				errorMessage = "El nombre de usuario y la contrasena no coinciden, intentalo de nuevo";
			}
		}

		
		static public int loginUser(string userName, string password)
		{
			MySqlConnection conn = new MySqlConnection(DBHelp.connStr);
			conn.Open();
			MySqlCommand cmd = new MySqlCommand($"SELECT userId FROM user WHERE userName = '{userName}' AND password = '{password}'", conn);
			MySqlDataReader reader = cmd.ExecuteReader();

			if (reader.HasRows) 
			{
				reader.Read();
				DBHelp.UserID = reader.GetInt32(0);
				DBHelp.UserName = reader.GetString(0);
				reader.Close();
				conn.Close();
				return DBHelp.UserID;
			}
			return 0;
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			if (loginUser(userBox.Text, pwBox.Text) != 0) 
			{
				this.Hide();
				MainForm MainForm = new MainForm
				{
					loginForm = this
				};
				Logger.WriteUserLoginLog(DBHelp.UserName);

				MainForm.Show();
			}
			else
			{
				MessageBox.Show(errorMessage);
				pwBox.Text = "";
			}
		}

        private void Login_Load(object sender, EventArgs e)
        {

		}

        private void cancelButton_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }
    }
}
