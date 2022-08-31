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
		public Login()
		{
			InitializeComponent();

			correctLang();
		}

		public string errorMessage = "The username and password did not match. Please try again";
		private void correctLang()
        {
			switch (RegionInfo.CurrentRegion.EnglishName)
            {
				case "United States":
					showEnglish();
					break;
				case "Spanish":
					showSpanish();
					break;

				default:
					showEnglish();
					break;
            }
        }

		private void showEnglish()
        {
			this.Text = "Login";
			userLabel.Text = "Username";
			pwLabel.Text = "Password";
			loginButton.Text = "Login";
			cancelButton.Text = "Cancel";
        }

		private void showSpanish()
        {
			this.Text = "Acceso";
			userLabel.Text = "Nombre de usuario";
			pwLabel.Text = "Clave";
			loginButton.Text = "Acceso";
			cancelButton.Text = "Cancelar";
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
				DBHelp.setUserId(Convert.ToInt32(reader[0]));
				DBHelp.setUserName(userName);
				reader.Close();
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
				MainForm mainForm = new MainForm();
				mainForm.Show();
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
