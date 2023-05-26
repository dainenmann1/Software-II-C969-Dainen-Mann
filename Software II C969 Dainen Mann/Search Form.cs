using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Software_II_C969_Dainen_Mann
{
    public partial class Search_Form : Form
    {
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
