using System;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_II_C969_Dainen_Mann
{
    public partial class AddAppt : Form
    {
        public AddAppt()
        {
            InitializeComponent();
            endTimePicker.Value = endTimePicker.Value.AddHours(1);
        }

        public MainForm mainFormObject;
        
        // EXCEPTIONS FOR CONFLICT TIMES AND OUTSIDE BUSINESS HOURS
        public static bool apptConflict(DateTime startTime, DateTime endTime)
        {
            foreach (var app in DBHelp.getAppts().Values)
            {
                if (startTime < DateTime.Parse(app["end"].ToString()) && DateTime.Parse(app["start"].ToString()) < endTime)
                    return true;
            }
            return false;
        }

        public static bool appIsOutsideBusinessHours(DateTime startTime, DateTime endTime)
        {
            startTime = startTime.ToLocalTime();
            endTime = endTime.ToLocalTime();
            DateTime businessStart = DateTime.Today.AddHours(8); // 8am
            DateTime businessEnd = DateTime.Today.AddHours(17); // 5pm
            if (startTime.TimeOfDay > businessStart.TimeOfDay && startTime.TimeOfDay < businessEnd.TimeOfDay &&
                endTime.TimeOfDay > businessStart.TimeOfDay && endTime.TimeOfDay < businessEnd.TimeOfDay)
                return false;

            return true;
        }

        private void PopulateAppointmentList()
        {
            apptCombo.DataSource = null;
            List<AppointmentList> appointmentList = new List<AppointmentList>();
            DBHelp.spl.Add(new MySqlParameter("@CurUtcTime", DateTime.UtcNow));
            MySqlDataReader dr = DBHelp.ExecuteReader("select appointmentId, title from appointment where start >= @CurUtcTime order by start", DBHelp.spl, DBHelp.connStr);
            if (dr != null && dr.HasRows)
            {
                while (dr.Read())
                {
                    appointmentList.Add(new AppointmentList { AppointmentID = dr.GetInt32(0), AppointmentTitle = dr.GetString(1) });
                }
                apptCombo.DisplayMember = "AppointmentTitle";
                apptCombo.ValueMember = "AppointmentId";
                apptCombo.DataSource = appointmentList;
            }
            apptCombo.SelectedIndex = -1;
        }
        private void PopulateCustomerList()
        {
            comboCustList.DataSource = null;
            List<CustomerList> customerList = new List<CustomerList>();
            MySqlDataReader dr = DBHelp.ExecuteReader("select customerId, customerName from customer order by customerName", DBHelp.spl, DBHelp.connStr);
            if (dr != null && dr.HasRows)
            {
                while (dr.Read())
                {
                    customerList.Add(new CustomerList(dr.GetInt32(0), dr.GetString(1)));
                }
                comboCustList.DisplayMember = "CustomerName";
                comboCustList.ValueMember = "CustomerId";
                comboCustList.DataSource = customerList;
            }
            comboCustList.SelectedIndex = -1;
        }
        private void addButton_Click_1(object sender, EventArgs e)
        {
            int userId = DBHelp.UserID;
            string username = DBHelp.UserName;
            DateTime startTime = startTimePicker.Value.ToUniversalTime();
            DateTime endTime = endTimePicker.Value.ToUniversalTime();

            try
            {
                if (apptConflict(startTime, endTime))
                    throw new apptException();
                else
                {
                    try
                    {
                        if (appIsOutsideBusinessHours(startTime, endTime))
                            throw new apptException();
                        else
                        {
                            DBHelp.spl.Add(new MySqlParameter("@CustomerId", comboCustList.SelectedValue.ToString()));
                            DBHelp.spl.Add(new MySqlParameter("@UserId", DBHelp.UserID.ToString()));
                            DBHelp.spl.Add(new MySqlParameter("@Title", titleBox.Text));
                            DBHelp.spl.Add(new MySqlParameter("@Description", descriptionBox.Text));
                            DBHelp.spl.Add(new MySqlParameter("@Location", locationBox.Text));
                            DBHelp.spl.Add(new MySqlParameter("@Contact", contactBox.Text));
                            DBHelp.spl.Add(new MySqlParameter("@Type", typeBox.Text));
                            DBHelp.spl.Add(new MySqlParameter("@Url", urlBox.Text));
                            DBHelp.spl.Add(new MySqlParameter("@Start", TimeZoneInfo.ConvertTimeToUtc(startTimePicker.Value, TimeZoneInfo.Local)));
                            DBHelp.spl.Add(new MySqlParameter("@End", TimeZoneInfo.ConvertTimeToUtc(endTimePicker.Value, TimeZoneInfo.Local)));
                            DBHelp.spl.Add(new MySqlParameter("@CurUtcTime", DateTime.UtcNow));
                            DBHelp.spl.Add(new MySqlParameter("@User", DBHelp.UserName));
                            DBHelp.ExecuteNonQuery("insert into appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                                "values (@CustomerId, @UserId, @Title, @Description, @Location, @Contact, @Type, @Url, @Start, @End, @CurUtcTime, @User, @CurUtcTime, @User)", DBHelp.spl, DBHelp.connStr);

                            Close();
                        }
                    }
                    catch (apptException ex) { ex.outsideBusHours(); }
                }
            }
            catch (apptException ex) { ex.conflictAppTime(); }
        }

        private void AddAppt_Load(object sender, EventArgs e)
        {
            PopulateCustomerList();
            PopulateAppointmentList();
        }

        private void endTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void typeLabel_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

