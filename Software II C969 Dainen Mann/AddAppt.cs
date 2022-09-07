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

        private void addButton_Click_1(object sender, EventArgs e)
        {
            string timestamp = DBHelp.cTimestamp();
            int userId = DBHelp.getUserId();
            string username = DBHelp.getUsername();
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
                            DBHelp.createRec(timestamp, username, "appointment", $"'{customerIDBox.Text}', '{startTimePicker.Value.ToUniversalTime().ToString("u")}', '{endTimePicker.Value.ToUniversalTime().ToString("u")}', '{typeBox.Text}'", userId);
                            mainFormObject.showCalendar();
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

        }

        private void endTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void typeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

