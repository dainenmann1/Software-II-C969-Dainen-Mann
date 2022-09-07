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
		public MainForm()
		{
			InitializeComponent();
            apptCalendar.DataSource = updateCalendar(weekRadio.Checked);
		}

        static public Array updateCalendar(bool weekView)
        {
            MySqlConnection conn = new MySqlConnection(DBHelp.connStr);
            conn.Open();
            string query = $"Select customerId, type, start, end, appointmentId, userId FROM appointment WHERE userId = '{DBHelp.getUserId()}'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            Dictionary<int, Hashtable> appointments = new Dictionary<int, Hashtable>();

            while (reader.Read())
            {
                Hashtable appointment = new Hashtable();
                appointment.Add("customerId", reader[0]);
                appointment.Add("type", reader[1]);
                appointment.Add("start", reader[2]);
                appointment.Add("end", reader[3]);
                appointments.Add(Convert.ToInt32(reader[4]), appointment);
                appointment.Add("userId", reader[5]);
            }
            reader.Close();

            foreach (var app in appointments.Values)
            {
                query = $"SELECT userName FROM user WHERE userId = '{app["userId"]}'";
                cmd = new MySqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                reader.Read();
                app.Add("userName", reader[0]);
                reader.Close();
            }

            foreach (var app in appointments.Values)
            {
                query = $"SELECT customerName FROM customer WHERE customerId = '{app["customerId"]}'";
                cmd = new MySqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                reader.Read();
                app.Add("customerName", reader[0]);
                reader.Close();
            }

            Dictionary<int, Hashtable> parsedAppointments = new Dictionary<int, Hashtable>();
            foreach (var app in appointments)
            {
                DateTime startTime = DateTime.Parse(app.Value["start"].ToString());
                DateTime endTime = DateTime.Parse(app.Value["end"].ToString());
                DateTime today = DateTime.UtcNow;

                if (weekView)
                {
                    DateTime sunday = today.AddDays(-(int)today.DayOfWeek);
                    DateTime saturday = today.AddDays(-(int)today.DayOfWeek + (int)DayOfWeek.Saturday);

                    if (startTime >= sunday && endTime < saturday)
                    {
                        parsedAppointments.Add(app.Key, app.Value);
                    }
                }
                else
                {
                    DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
                    DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
                    if (startTime >= firstDayOfMonth && endTime < lastDayOfMonth)
                    {
                        parsedAppointments.Add(app.Key, app.Value);
                    }
                }
            }

            DBHelp.setAppts(appointments);
            var appointmentArray = from row in parsedAppointments
                      select new
                     {
                      ID = row.Key,
                      Type = row.Value["type"],
                      StartTime = DBHelp.convertToTimezone(row.Value["start"].ToString()),
                      EndTime = DBHelp.convertToTimezone(row.Value["end"].ToString()),
                       Customer = row.Value["customerName"]
                     };

            conn.Close();

            return appointmentArray.ToArray();
        }

        public void showCalendar()
        {
            apptCalendar.DataSource = updateCalendar(weekRadio.Checked);
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

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void weekRadio_CheckedChanged(object sender, EventArgs e)
        {
            showCalendar();
        }

        //Add Appointment Button
        private void button1_Click(object sender, EventArgs e)
        {
            AddAppt addAppt = new AddAppt();
            addAppt.mainFormObject = this;
            addAppt.Show();
        }
    }
}
