using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Software_II_C969_Dainen_Mann
{
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                DBHelp.spl.Add(new MySqlParameter("@Username", nameBox.Text));
                if ((int)DBHelp.GetCount("select count(*) from user where userName = @Username", DBHelp.spl, DBHelp.connStr) > 0)
                {
                    MessageBox.Show("Username already in use.");
                }
                else if (maskedPWBox.Text != confirmPWBox.Text)
                {
                    MessageBox.Show("Passwords do not match.");
                }
                else
                {
                    DBHelp.spl.Add(new MySqlParameter("@Username", nameBox.Text));
                    DBHelp.spl.Add(new MySqlParameter("@Password", maskedPWBox.Text));
                    DBHelp.spl.Add(new MySqlParameter("@CurUtcTime", DateTime.UtcNow));
                    DBHelp.ExecuteNonQuery("insert into user (userName, password, active, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                        "values (@Username, @Password, 1, @CurUtcTime, @Username, @CurUtcTime, @Username)", DBHelp.spl, DBHelp.connStr);
                    MessageBox.Show("User '" + nameBox.Text + "' created successfully.");
                    Close();
                }
            }
            catch (Exception ex)
            {
                Logger.LogMessage("ErrorLog", ex.Message, "error", "btnCreate_Click");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
