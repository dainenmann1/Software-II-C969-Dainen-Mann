using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Software_II_C969_Dainen_Mann
{
    public partial class Search_Form : Form
    {
        private string searchQuery;
        public MainForm mainFormObject;
        public Search_Form()
        {
            InitializeComponent();
        }

        private void Search_Form_Load(object sender, EventArgs e)
        {
            PopulateLists();
        }

        private void PopulateLists()
        {
            MySqlDataReader dr = null;

            dr = DBHelp.ExecuteReader("select customerName from customer order by customerName", DBHelp.spl, DBHelp.connStr);
            if (dr != null && dr.HasRows)
            {
                while (dr.Read())
                {
                    custCombo.Items.Add(dr[0].ToString());
                }
            }

            dr = DBHelp.ExecuteReader("select distinct location from appointment order by location", DBHelp.spl, DBHelp.connStr);
            if (dr != null && dr.HasRows)
            {
                while (dr.Read())
                {
                    locationCombo.Items.Add(dr[0].ToString());
                }
            }

            dr = DBHelp.ExecuteReader("select distinct type from appointment order by type", DBHelp.spl, DBHelp.connStr);
            if (dr != null && dr.HasRows)
            {
                while (dr.Read())
                {
                    typeCombo.Items.Add(dr[0].ToString());
                }
            }
             
            dr = DBHelp.ExecuteReader("select userName from user order by userName", DBHelp.spl, DBHelp.connStr);
            if (dr != null && dr.HasRows)
            {
                while (dr.Read())
                {
                    createdCombo.Items.Add(dr[0].ToString());
                }
            }
        }

        private void BuildQuery()
        {
            searchQuery = "";
            DBHelp.spl.Add(new MySqlParameter("@Now", DateTime.UtcNow));
            searchQuery += "select c.customerName, a.title, a.description, a.location, a.contact, a.type, a.url, a.start, a.end, u.userName createdBy from appointment a " +
                           "inner join customer c on c.customerId = a.customerId inner join user u on u.userId = a.userId where end >= @Now ";
            if (custCombo.SelectedIndex > -1)
            {
                DBHelp.spl.Add(new MySqlParameter("@Customer", custCombo.SelectedItem.ToString()));
                searchQuery += "and c.CustomerName = @Customer ";
            }
            if (!string.IsNullOrEmpty(titleBox.Text))
            {
                DBHelp.spl.Add(new MySqlParameter("@Title", "%" + titleBox.Text + "%"));
                searchQuery += "and a.title like @Title ";
            }
            if (!string.IsNullOrEmpty(descBox.Text))
            {
                DBHelp.spl.Add(new MySqlParameter("@Description", "%" + descBox.Text + "%"));
                searchQuery += "and a.Description like @Description ";
            }
            if (locationCombo.SelectedIndex > -1)
            {
                DBHelp.spl.Add(new MySqlParameter("@Location", locationCombo.SelectedItem.ToString()));
                searchQuery += "and a.location = @Location ";
            }
            if (typeCombo.SelectedIndex > -1)
            {
                DBHelp.spl.Add(new MySqlParameter("@Type", typeCombo.SelectedItem.ToString()));
                searchQuery += "and a.type = @Type ";
            }
            if (createdCombo.SelectedIndex > -1)
            {
                DBHelp.spl.Add(new MySqlParameter("@CreatedBy", createdCombo.SelectedItem.ToString()));
                searchQuery += "and u.userName = @CreatedBy ";
            }
            searchQuery += "order by start";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            BuildQuery();
            gridSearchResults.DataSource = DBHelp.FillReports(searchQuery, DBHelp.spl, DBHelp.connStr);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            custCombo.SelectedIndex = -1;
            titleBox.Text = "";
            descBox.Text = "";
            locationCombo.SelectedIndex = -1;
            typeCombo.SelectedIndex = -1;
            createdCombo.SelectedIndex = -1;
            gridSearchResults.DataSource = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
