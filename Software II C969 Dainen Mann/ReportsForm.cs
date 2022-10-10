using System;
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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        public MainForm mainFormObject;
        private void ApptTypeByMonth()
        {
            reportDataGrid.DataSource = DBHelp.FillReports("select year(a.start) as 'Year', a.type as 'Appointment Type', count(case month(a.start) when 1 then a.type end) as 'Jan', count(case month(a.start) when 2 then a.type end) as 'Feb', " +
                "count(case month(a.start) when 3 then a.type end) as 'Mar', count(case month(a.start) when 4 then a.type end) as 'Apr', count(case month(a.start) when 5 then a.type end) as 'May', " +
                "count(case month(a.start) when 6 then a.type end) as 'Jun', count(case month(a.start) when 7 then a.type end) as 'Jul', count(case month(a.start) when 8 then a.type end) as 'Aug', " +
                "count(case month(a.start) when 9 then a.type end) as 'Sep', count(case month(a.start) when 10 then a.type end) as 'Oct', count(case month(a.start) when 11 then a.type end) as 'Nov', " +
                "count(case month(a.start) when 12 then a.type end) as 'Dec' from appointment a group by year(a.start), a.type order by year(a.start), a.type", DBHelp.spl, DBHelp.connStr);
        }

        private void ScheduleByUser()
        {
            DBHelp.spl.Add(new MySqlParameter("@TimeZone", TimeZoneInfo.Local.GetUtcOffset(DateTimeOffset.Now).ToString().Substring(0, 6)));
            reportDataGrid.DataSource = DBHelp.FillReports("select u.userName as 'User Name', c.customerName as 'Customer Name', a.title as 'Appt Title', a.description as 'Appt Description', a.location as 'Appt Location', a.contact as 'Appt Contact', " +
                "a.type as 'Appt Type', a.url as 'Appt URL', convert_tz(a.start, '+00:00', @TimeZone) as 'Appt Start', convert_tz(a.end, '+00:00', @TimeZone) as 'Appt End' from appointment a " +
                "inner join user u on u.userId = a.userId inner join customer c on c.customerId = a.customerId order by u.userName, a.start", DBHelp.spl, DBHelp.connStr);
        }

        private void InactiveCustomers()
        {
            reportDataGrid.DataSource = DBHelp.FillReports("select c.customerName as 'Customer Name', a.address as 'Address 1', a.address2 as 'Address 2', ci.city as 'City', a.postalCode as 'Postal Code', co.country as 'Country', a.phone as 'Phone' " +
                "from customer c inner join address a on a.addressId = c.addressId inner join city ci on ci.cityId = a.cityId inner join country co on co.countryId = ci.countryId where c.active = 0", DBHelp.spl, DBHelp.connStr);
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            reportListCombo.SelectedIndex = -1;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reportListCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reportListCombo.SelectedIndex == -1)
            {
                reportDataGrid.DataSource = null;
            }
            else if (reportListCombo.SelectedIndex == 0)
            {
                ApptTypeByMonth();
            }
            else if (reportListCombo.SelectedIndex == 1)
            {
                ScheduleByUser();
            }
            else if (reportListCombo.SelectedIndex == 2)
            {
                InactiveCustomers();
            }
        }
    }
}
