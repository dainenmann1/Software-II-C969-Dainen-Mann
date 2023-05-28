﻿using System;
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
        public bool HasConflictingAppointments(string appointmentId, string customerId, DateTime start, DateTime end)
        {
            string appointmentClause = "";
            if (!string.IsNullOrEmpty(appointmentId)) { appointmentClause = " and appointmentId <> @AppointmentId"; }
            DBHelp.spl.Add(new MySqlParameter("@AppointmentId", appointmentId));
            DBHelp.spl.Add(new MySqlParameter("@CustomerId", customerId));
            DBHelp.spl.Add(new MySqlParameter("@Start", TimeZoneInfo.ConvertTimeToUtc(start).ToString("yyyy-MM-dd HH:mm")));
            DBHelp.spl.Add(new MySqlParameter("@End", TimeZoneInfo.ConvertTimeToUtc(end).ToString("yyyy-MM-dd HH:mm")));
            long conflictFound = (DBHelp.GetCount("select count(*) from appointment where customerId = @CustomerId and ((@Start >= start and @End <= end) or (@Start <= start and @End > start) or (@Start < end and @End >= end) or (@Start <= start and @End >= end))" + appointmentClause, DBHelp.spl, DBHelp.connStr));
            if (conflictFound > 0) { return true; } else { return false; }
        }

        public string WithinBusinessHours(DateTime start, DateTime end)
        {
            TimeSpan businessStart = TimeSpan.Parse("08:00");
            TimeSpan businessEnd = TimeSpan.Parse("17:00");

            if (start.Date == end.Date)
            {
                if (start.TimeOfDay <= end.TimeOfDay)
                {
                    if (start.Hour < businessStart.Hours) { return "Meetings cannot be scheduled to start before business opens at 8:00AM."; }
                    else if (end.Hour > businessEnd.Hours) { return "Meetings cannot be scheduled to end after business closes at 5:00PM."; }
                    else { return ""; }
                }
                else
                {
                    return "Start time cannot be after end time.";
                }
            }
            else
            {
                return "Meetings cannot be scheduled across multiple days.";
            }
        }

        private bool CheckFieldsForError()
        {
            bool isValid = true;
            string errorMessage = "";
            if (string.IsNullOrEmpty(comboCustList.Text)) { isValid = false; errorMessage += "Customer field cannot be blank." + Environment.NewLine; }
            if (string.IsNullOrEmpty(titleBox.Text)) { isValid = false; errorMessage += "Title field cannot be blank." + Environment.NewLine; }
            if (string.IsNullOrEmpty(descriptionBox.Text)) { isValid = false; errorMessage += "Description field cannot be blank." + Environment.NewLine; }
            if (string.IsNullOrEmpty(locationBox.Text)) { isValid = false; errorMessage += "Location field cannot be blank." + Environment.NewLine; }
            if (string.IsNullOrEmpty(contactBox.Text)) { isValid = false; errorMessage += "Contact field cannot be blank." + Environment.NewLine; }
            if (string.IsNullOrEmpty(typeBox.Text)) { isValid = false; errorMessage += "Type field cannot be blank." + Environment.NewLine; }
            if (string.IsNullOrEmpty(urlBox.Text)) { isValid = false; errorMessage += "URL field cannot be blank."; }
            if (!string.IsNullOrEmpty(errorMessage)) { MessageBox.Show(errorMessage); }
            return isValid;
        }
        //Button and clear functions
        private void ClearForm()
        {
            DateTime curDateTime = DateTime.Now;
            comboCustList.SelectedIndex = -1;
            titleBox.Text = "";
            descriptionBox.Text = "";
            locationBox.Text = "";
            contactBox.Text = "";
            typeBox.Text = "";
            urlBox.Text = "";
            startTimePicker.Value = curDateTime;
            endTimePicker.Value = curDateTime.AddHours(1);
        }

        private void AddorUpdate()
        {
            if (comboCustList.SelectedIndex == -1)
            {
                addButton.Enabled = true;
                addButton.Visible = true;
                updateButton.Enabled = false;
                updateButton.Visible = false;
            }
            else
            {
                addButton.Enabled = false;
                addButton.Visible = false;
                updateButton.Enabled = true;
                updateButton.Visible = true;
            }
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
                    appointmentList.Add(new AppointmentList { AppointmentId = dr.GetInt32(0), AppointmentTitle = dr.GetString(1) });
                }
                apptCombo.DisplayMember = "AppointmentTitle";
                apptCombo.ValueMember = "AppointmentId";
                apptCombo.DataSource = appointmentList;
            }
            apptCombo.SelectedIndex = -1;
        }

        private void LoadIndexAppointment()
        {
            if (apptCombo.SelectedValue != null)
            {
                DBHelp.spl.Add(new MySqlParameter("@AppointmentId", apptCombo.SelectedValue.ToString()));
                MySqlDataReader dr = DBHelp.ExecuteReader("select customerId, title, description, location, contact, type, url, start, end from appointment where appointmentId = @AppointmentId", DBHelp.spl, DBHelp.connStr);
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    comboCustList.SelectedValue = dr.GetInt32(0);
                    titleBox.Text = dr.GetString(1);
                    descriptionBox.Text = dr.GetString(2);
                    locationBox.Text = dr.GetString(3);
                    contactBox.Text = dr.GetString(4);
                    typeBox.Text = dr.GetString(5);
                    urlBox.Text = dr.GetString(6);
                    startTimePicker.Value = TimeZoneInfo.ConvertTimeFromUtc(dr.GetDateTime(7), TimeZoneInfo.Local);
                    endTimePicker.Value = TimeZoneInfo.ConvertTimeFromUtc(dr.GetDateTime(8), TimeZoneInfo.Local);
                }
            }
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
            try
            {
                if (CheckFieldsForError())
                {
                    if (MessageBox.Show("Create this appointment?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string businessHourMessage = WithinBusinessHours(startTimePicker.Value, endTimePicker.Value);
                        if (string.IsNullOrEmpty(businessHourMessage))
                        {
                            if (!HasConflictingAppointments(apptCombo.SelectedValue.ToString(), comboCustList.SelectedValue.ToString(), startTimePicker.Value, endTimePicker.Value))
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

                                PopulateAppointmentList();
                            }
                            else
                            {
                                MessageBox.Show("Selected appointment times conflict with existing appointment for " + comboCustList.Text + ".");
                            }
                        }
                        else
                        {
                            MessageBox.Show(businessHourMessage);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem updating appointment data." + Environment.NewLine + Environment.NewLine + ex.Message);
            }
        }

        private void AddAppt_Load(object sender, EventArgs e)
        {
            AddorUpdate();
            PopulateCustomerList();
            PopulateAppointmentList();
            ClearForm();
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void apptCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (apptCombo.SelectedIndex == -1)
            {
                ClearForm();
                AddorUpdate();
            }
            else
            {
                LoadIndexAppointment();
                AddorUpdate();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            DateTime startTime = startTimePicker.Value.ToUniversalTime();
            DateTime endTime = endTimePicker.Value.ToUniversalTime();

            try
            {
                if (CheckFieldsForError())
                {
                    if (MessageBox.Show("Make changes to this appointment?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string businessHourMessage = WithinBusinessHours(startTimePicker.Value, endTimePicker.Value);
                        if (string.IsNullOrEmpty(businessHourMessage))
                        {
                            if (!HasConflictingAppointments(apptCombo.SelectedValue.ToString(), comboCustList.SelectedValue.ToString(), startTimePicker.Value, endTimePicker.Value))
                            {
                                DBHelp.spl.Add(new MySqlParameter("@AppointmentId", apptCombo.SelectedValue.ToString()));
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
                                    DBHelp.ExecuteNonQuery("update appointment set customerId = @CustomerId, userId = @UserId, title = @Title, description = @Description, location = @Location, contact = @Contact, type = @Type, url = @Url, " +
                                    "start = @Start, end = @End, createDate = @CurUtcTime, createdBy = @User, lastUpdate = @CurUtcTime, lastUpdateBy = @User where appointmentId = @AppointmentId", DBHelp.spl, DBHelp.connStr);

                                    PopulateAppointmentList();
                            }
                            else
                            {
                                MessageBox.Show("Selected appointment times conflict with existing appointment for " + comboCustList.Text + ".");
                            }
                        }
                        else
                        {
                            MessageBox.Show(businessHourMessage);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem updating appointment data." + Environment.NewLine + Environment.NewLine + ex.Message);
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            apptCombo.SelectedIndex = -1;
            AddorUpdate();
            ClearForm();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (apptCombo.SelectedIndex > -1)
                {
                    if (MessageBox.Show("Delete this appointment from the list?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DBHelp.spl.Add(new MySqlParameter("@AppointmentId", apptCombo.SelectedValue.ToString()));
                        DBHelp.ExecuteNonQuery("delete from appointment where appointmentId = @AppointmentId", DBHelp.spl, DBHelp.connStr);

                        PopulateAppointmentList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem deleting appointment data." + Environment.NewLine + Environment.NewLine + ex.Message);
            }
        }

        private void endTimeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

