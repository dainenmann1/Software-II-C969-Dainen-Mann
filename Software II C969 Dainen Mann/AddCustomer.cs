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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        public MainForm mainFormObject;
        private void AddCustomer_Load(object sender, EventArgs e)
        {
            AddorUpdate();
            ClearForm();
            PopulateCustomerList();
            PopulateCountryList();
        }

        private void AddorUpdate()
        {
            if (customerComboBox.SelectedIndex == -1)
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

        private void ClearForm()
        {
            activeCheckBox.Checked = false;
            nameBox.Text = "";
            address1Box.Text = "";
            address2Box.Text = "";
            phoneNumBox.Text = "";
            zipCodeBox.Text = "";
            cityComboBox.Text = "";
            cityComboBox.Items.Clear();

        }

        private bool CheckFieldsForError()
        {
            bool isValid = true;
            string errorMessage = "";
            if (string.IsNullOrEmpty(countryComboBox.Text)) { isValid = false; errorMessage += "Country field cannot be blank." + Environment.NewLine; }
            if (string.IsNullOrEmpty(nameBox.Text)) { isValid = false; errorMessage += "Name field cannot be blank." + Environment.NewLine; }
            if (string.IsNullOrEmpty(address1Box.Text)) { isValid = false; errorMessage += "Address field cannot be blank." + Environment.NewLine; }
            if (string.IsNullOrEmpty(cityComboBox.Text)) { isValid = false; errorMessage += "City field cannot be blank." + Environment.NewLine; }
            if (string.IsNullOrEmpty(zipCodeBox.Text)) { isValid = false; errorMessage += "Postal Code field cannot be blank." + Environment.NewLine; }
            if (string.IsNullOrEmpty(phoneNumBox.Text)) { isValid = false; errorMessage += "Phone field cannot be blank."; }
            if (!string.IsNullOrEmpty(errorMessage)) { MessageBox.Show(errorMessage); }
            return isValid;
        }

        //COUNTRY METHODS
        private string CountryData()
        {
            MySqlDataReader dr;
            string countryId = "";

            if (countryComboBox.SelectedValue != null)
            {
                countryId = countryComboBox.SelectedValue.ToString();
            }
            else
            {
                DBHelp.spl.Add(new MySqlParameter("@Country", countryComboBox.Text));
                dr = DBHelp.ExecuteReader("select countryId from country where country = @Country", DBHelp.spl, DBHelp.connStr);
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    countryId = dr.GetString(0);
                }
                else
                {
                    DBHelp.spl.Add(new MySqlParameter("@Country", countryComboBox.Text));
                    DBHelp.spl.Add(new MySqlParameter("@CurUtcTime", DateTime.UtcNow));
                    DBHelp.spl.Add(new MySqlParameter("@User", DBHelp.UserName));
                    DBHelp.ExecuteNonQuery("insert into country (country, createDate, createdBy, lastUpdate, lastUpdateBy) values (@Country, @CurUtcTime, @User, @CurUtcTime, @User)", DBHelp.spl, DBHelp.connStr);

                    DBHelp.spl.Add(new MySqlParameter("@Country", countryComboBox.Text));
                    dr = DBHelp.ExecuteReader("select countryId from country where country = @Country", DBHelp.spl, DBHelp.connStr);
                    if (dr != null && dr.HasRows)
                    {
                        dr.Read();
                        countryId = dr.GetString(0);
                    }
                }
            }
            return countryId;
        }

        private void PopulateCountryList()
        {
            countryComboBox.DataSource = null;
            List<CountryList> countryList = new List<CountryList>();
            MySqlDataReader dr = DBHelp.ExecuteReader("select countryId, country from country order by country", DBHelp.spl, DBHelp.connStr);
            if (dr != null && dr.HasRows)
            {
                while (dr.Read())
                {
                    countryList.Add(new CountryList { CountryId = dr.GetInt32(0), CountryName = dr.GetString(1) });
                }
                countryComboBox.DisplayMember = "CountryName";
                countryComboBox.ValueMember = "CountryId";
                countryComboBox.DataSource = countryList;
            }
            countryComboBox.SelectedIndex = -1;
        }

        //CUSTOMER METHODS
        private void PopulateCustomerList()
        {
            customerComboBox.DataSource = null;
            List<CustomerList> customerList = new List<CustomerList>();
            MySqlDataReader dr = DBHelp.ExecuteReader("select customerId, customerName from customer order by customerName", DBHelp.spl, DBHelp.connStr);
            if (dr != null && dr.HasRows)
            {
                while (dr.Read())
                {
                    customerList.Add(new CustomerList(dr.GetInt32(0), dr.GetString(1)));
                }
                customerComboBox.DisplayMember = "CustomerName";
                customerComboBox.ValueMember = "CustomerId";
                customerComboBox.DataSource = customerList;
            }
            customerComboBox.SelectedIndex = -1;
        }

        private void LoadIndexCustomer()
        {
            if (customerComboBox.SelectedValue != null)
            {
                DBHelp.spl.Add(new MySqlParameter("CustomerId", customerComboBox.SelectedValue.ToString()));
                MySqlDataReader dr = DBHelp.ExecuteReader("select c.active, c.customerName, a.address, a.address2, a.postalCode, a.phone, ci.city, co.country from customer c inner join address a on a.addressId = c.addressId inner join city ci on ci.cityId = a.cityId inner join country co on co.countryId = ci.countryId where c.customerId = @CustomerId", DBHelp.spl, DBHelp.connStr);
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    activeCheckBox.Checked = dr.GetBoolean(0);
                    countryComboBox.Text = dr.GetString(7);
                    PopulateCityList();
                    nameBox.Text = dr.GetString(1);
                    address1Box.Text = dr.GetString(2);
                    address2Box.Text = dr.GetString(3);
                    zipCodeBox.Text = dr.GetString(4);
                    phoneNumBox.Text = dr.GetString(5);
                    cityComboBox.Text = dr.GetString(6);
                }
            }
        }

        //CITY METHODS
        private string CityData(string countryId)
        {
            MySqlDataReader dr;
            string cityId = "";

            DBHelp.spl.Add(new MySqlParameter("@City", cityComboBox.Text));
            DBHelp.spl.Add(new MySqlParameter("@CountryId", countryId));
            dr = DBHelp.ExecuteReader("select cityId from city where city = @City and countryId = @CountryId", DBHelp.spl, DBHelp.connStr);
            if (dr != null && dr.HasRows)
            {
                dr.Read();
                cityId = dr.GetString(0);
            }
            else
            {
                DBHelp.spl.Add(new MySqlParameter("@City", cityComboBox.Text));
                DBHelp.spl.Add(new MySqlParameter("@CountryId", countryId));
                DBHelp.spl.Add(new MySqlParameter("@CurUtcTime", DateTime.UtcNow));
                DBHelp.spl.Add(new MySqlParameter("@User", DBHelp.UserName));
                DBHelp.ExecuteNonQuery("insert into city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) values (@City, @CountryId, @CurUtcTime, @User, @CurUtcTime, @User)", DBHelp.spl, DBHelp.connStr);

                DBHelp.spl.Add(new MySqlParameter("@City", cityComboBox.Text));
                DBHelp.spl.Add(new MySqlParameter("@CountryId", countryId));
                dr = DBHelp.ExecuteReader("select cityId from city where city = @City and countryId = @CountryId", DBHelp.spl, DBHelp.connStr);
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    cityId = dr.GetString(0);
                }
            }

            return cityId;
        }

        private string AddressData(string cityId)
        {
            MySqlDataReader dr;
            string addressId = "";

            DBHelp.spl.Add(new MySqlParameter("@Address", address1Box.Text));
            DBHelp.spl.Add(new MySqlParameter("@Address2", address2Box.Text));
            DBHelp.spl.Add(new MySqlParameter("@CityId", cityId));
            DBHelp.spl.Add(new MySqlParameter("@PostalCode", zipCodeBox.Text));
            DBHelp.spl.Add(new MySqlParameter("@Phone", phoneNumBox.Text));
            dr = DBHelp.ExecuteReader("select addressId from address where address = @Address and address2 = Address2 and cityId = @CityId and postalCode = @PostalCode and phone = @Phone", DBHelp.spl, DBHelp.connStr);
            if (dr != null && dr.HasRows)
            {
                dr.Read();
                addressId = dr.GetString(0);
            }
            else
            {
                DBHelp.spl.Add(new MySqlParameter("@Address", address1Box.Text));
                DBHelp.spl.Add(new MySqlParameter("@Address2", address2Box.Text));
                DBHelp.spl.Add(new MySqlParameter("@CityId", cityId));
                DBHelp.spl.Add(new MySqlParameter("@PostalCode", zipCodeBox.Text));
                DBHelp.spl.Add(new MySqlParameter("@Phone", phoneNumBox.Text));
                DBHelp.spl.Add(new MySqlParameter("@CurUtcTime", DateTime.UtcNow));
                DBHelp.spl.Add(new MySqlParameter("@User", DBHelp.UserName));
                DBHelp.ExecuteNonQuery("insert into address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) values (@Address, @Address2, @CityId, @PostalCode, @Phone, @CurUtcTime, @User, @CurUtcTime, @User)", DBHelp.spl, DBHelp.connStr);

                DBHelp.spl.Add(new MySqlParameter("@Address", address1Box.Text));
                DBHelp.spl.Add(new MySqlParameter("@Address2", address2Box.Text));
                DBHelp.spl.Add(new MySqlParameter("@CityId", cityId));
                DBHelp.spl.Add(new MySqlParameter("@PostalCode", zipCodeBox.Text));
                DBHelp.spl.Add(new MySqlParameter("@Phone", phoneNumBox.Text));
                dr = DBHelp.ExecuteReader("select addressId from address where address = @Address and address2 = Address2 and cityId = @CityId and postalCode = @PostalCode and phone = @Phone", DBHelp.spl, DBHelp.connStr);
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    addressId = dr.GetString(0);
                }
            }

            return addressId;
        }

        private void PopulateCityList()
        {
            cityComboBox.Items.Clear();
            if (countryComboBox.SelectedValue != null)
            {
                DBHelp.spl.Add(new MySqlParameter("@Country", countryComboBox.SelectedValue.ToString()));
                MySqlDataReader dr = DBHelp.ExecuteReader("select city from city where countryId = @Country order by city", DBHelp.spl, DBHelp.connStr);
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cityComboBox.Items.Add(dr.GetString(0));
                    }
                }
                cityComboBox.SelectedIndex = -1;
            }
        }

        private void countryComboBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(countryComboBox.Text)) { PopulateCityList(); }
        }

        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerComboBox.SelectedIndex == -1)
            {
                AddorUpdate();
                ClearForm();
            }
            else
            {
                LoadIndexCustomer();
                AddorUpdate();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            customerComboBox.SelectedIndex = -1;
            AddorUpdate();
            ClearForm();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Add this customer to the list?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (CheckFieldsForError())
                    {
                        string countryId = CountryData();
                        string cityId = CityData(countryId);
                        string addressId = AddressData(cityId);

                        DBHelp.spl.Add(new MySqlParameter("@CustomerName", nameBox.Text));
                        DBHelp.spl.Add(new MySqlParameter("@AddressId", addressId));
                        DBHelp.spl.Add(new MySqlParameter("@Active", activeCheckBox.Checked));
                        DBHelp.spl.Add(new MySqlParameter("@CurUtcTime", DateTime.UtcNow));
                        DBHelp.spl.Add(new MySqlParameter("@User", DBHelp.UserName));
                        DBHelp.ExecuteNonQuery("insert into customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) values (@CustomerName, @AddressId, @Active, @CurUtcTime, @User, @CurUtcTime, @User)", DBHelp.spl, DBHelp.connStr);

                        PopulateCustomerList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem saving customer data." + Environment.NewLine + Environment.NewLine + ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (customerComboBox.SelectedIndex > -1)
                {
                    if (MessageBox.Show("Delete this from customer list?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DBHelp.spl.Add(new MySqlParameter("@CustomerId", customerComboBox.SelectedValue.ToString()));
                        DBHelp.ExecuteNonQuery("delete from appointment where customerId = @CustomerId", DBHelp.spl, DBHelp.connStr);

                        DBHelp.spl.Add(new MySqlParameter("@CustomerId", customerComboBox.SelectedValue.ToString()));
                        DBHelp.ExecuteNonQuery("delete from customer where customerId = @CustomerId", DBHelp.spl, DBHelp.connStr);

                        PopulateCustomerList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem deleting customer data." + Environment.NewLine + Environment.NewLine + ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Make changes to this customer?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (CheckFieldsForError())
                    {
                        string countryId = CountryData();
                        string cityId = CityData(countryId);
                        string addressId = AddressData(cityId);

                        DBHelp.spl.Add(new MySqlParameter("@CustomerId", customerComboBox.SelectedValue.ToString()));
                        DBHelp.spl.Add(new MySqlParameter("@CustomerName", nameBox.Text));
                        DBHelp.spl.Add(new MySqlParameter("@AddressId", addressId));
                        DBHelp.spl.Add(new MySqlParameter("@Active", activeCheckBox.Checked));
                        DBHelp.spl.Add(new MySqlParameter("@CurUtcTime", DateTime.UtcNow));
                        DBHelp.spl.Add(new MySqlParameter("@User", DBHelp.UserName));
                        DBHelp.ExecuteNonQuery("update customer set customerName = @CustomerName, addressId = @addressId, active = @Active, lastUpdate = @CurUtcTime, lastUpdateBy = @User where customerId = @CustomerId", DBHelp.spl, DBHelp.connStr);

                        PopulateCustomerList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem updating customer data." + Environment.NewLine + Environment.NewLine + ex.Message);
            }
        }
    }
}
