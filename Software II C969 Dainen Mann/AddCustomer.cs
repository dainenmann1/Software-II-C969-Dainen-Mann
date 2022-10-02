using System;
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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
        /*private void ClearForm()
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
        }*/
    }
}
