using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Software_II_C969_Dainen_Mann
{
	public partial class MainForm : Form
	{
        public Login loginForm;

        public static string connStr = DBHelp.ConnStr;
		public MainForm()
		{
			InitializeComponent();
            MainForm_Load(allRadio.Checked = true);
        }

        public static string SetApptID = "";
        public static string SetCustName = "";

        private void PopulateAppointmentList()
        {
            apptFlowPanel.Controls.Clear();

            if (DBHelp.appointmentList.Count > 0)
            {
                string appointmentInfo;

                //Lambda used to simplify foreach statement
                DBHelp.appointmentList.ForEach(a =>
                {
                    appointmentInfo = "";
                    appointmentInfo += "Appointment for " + a.CustomerName + " from " + a.Start.ToString("yyyy-MM-dd HH:mm") + " to " + a.End.ToString("yyyy-MM-dd HH:mm") + Environment.NewLine;
                    appointmentInfo += "Title: " + a.Title + Environment.NewLine;
                    appointmentInfo += "Description: " + a.Description + Environment.NewLine;
                    appointmentInfo += "Contact: " + a.Contact + Environment.NewLine;
                    appointmentInfo += "Location: " + a.Location + Environment.NewLine;
                    appointmentInfo += "URL: " + a.Url + Environment.NewLine;
                    appointmentInfo += "Meeting type: " + a.Type;
                    TextBox t = new TextBox
                    {
                        Text = appointmentInfo,
                        AutoSize = false,
                        Width = 500,
                        Height = 100,
                        BorderStyle = BorderStyle.FixedSingle,
                        ScrollBars = ScrollBars.Vertical,
                        ReadOnly = true,
                        Multiline = true,
                        WordWrap = true
                    };
                    if (DBHelp.appointmentList.Count <= 3) { t.Width = 517; }
                    apptFlowPanel.Controls.Add(t);
                });
            }
        }
        private void LoadUpcomingAppointments()
        {
            MySqlDataReader dr = null;
            DateTime curUtcDateTime = DateTime.UtcNow;

            DBHelp.appointmentList.Clear();

            DBHelp.spl.Add(new MySqlParameter("@UserId", DBHelp.UserID));
            DBHelp.spl.Add(new MySqlParameter("@Now", curUtcDateTime));
            if (allRadio.Checked)
            {
                dr = DBHelp.ExecuteReader("select a.appointmentId, c.customerName, a.title, a.description, a.location, a.contact, a.type, a.url, a.start, a.end, a.createDate from appointment a inner join customer c on c.customerId = a.customerId where userId = @UserId and end >= @Now order by start", DBHelp.spl, DBHelp.connStr);
            }
            else if (weekRadio.Checked)
            {
                DBHelp.spl.Add(new MySqlParameter("@FromNow", curUtcDateTime.AddDays(7)));
                dr = DBHelp.ExecuteReader("select a.appointmentId, c.customerName, a.title, a.description, a.location, a.contact, a.type, a.url, a.start, a.end, a.createDate from appointment a inner join customer c on c.customerId = a.customerId where userId = @UserId and end >= @Now and end <= @FromNow order by start", DBHelp.spl, DBHelp.connStr);
            }
            else if (monthRadio.Checked)
            {
                DBHelp.spl.Add(new MySqlParameter("@FromNow", curUtcDateTime.AddMonths(1)));
                dr = DBHelp.ExecuteReader("select a.appointmentId, c.customerName, a.title, a.description, a.location, a.contact, a.type, a.url, a.start, a.end, a.createDate from appointment a inner join customer c on c.customerId = a.customerId where userId = @UserId and end >= @Now and end <= @FromNow order by start", DBHelp.spl, DBHelp.connStr);
            }

            if (dr != null && dr.HasRows)
            {
                while (dr.Read())
                {
                    DBHelp.appointmentList.Add(new Appointment(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7), TimeZoneInfo.ConvertTimeFromUtc(dr.GetDateTime(8), TimeZoneInfo.Local), TimeZoneInfo.ConvertTimeFromUtc(dr.GetDateTime(9), TimeZoneInfo.Local)));
                }
            }

            PopulateAppointmentList();
        }

        public void MainForm_Load(bool week)
        {
          
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadUpcomingAppointments();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void weekRadio_CheckedChanged(object sender, EventArgs e)
        {
            LoadUpcomingAppointments();
        }

        //Add Appointment Button
        private void button1_Click(object sender, EventArgs e)
        {
            AddAppt addAppt = new AddAppt();
            addAppt.mainFormObject = this;
            addAppt.Show();
            LoadUpcomingAppointments();
        }

        private void monthRadio_CheckedChanged(object sender, EventArgs e)
        {
            LoadUpcomingAppointments();
        }

        private void allRadio_CheckedChanged(object sender, EventArgs e)
        {
            LoadUpcomingAppointments();
        }
    }
}
