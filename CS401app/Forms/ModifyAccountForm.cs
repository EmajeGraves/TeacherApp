using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherApp
{
    public partial class ModifyAccountForm : Form
    {
        // passes user from home screen
        
        
        public DatabaseMgrSQLite dbMgr;
        public DataTable dataTable = new DataTable();
        
        public ModifyAccountForm()
        {
            InitializeComponent();
          
            dbMgr = new DatabaseMgrSQLite();
            
            populateTextBoxes();
        }

        private void populateTextBoxes()
        {

            try
            {
                //SQLite statement
                string sqlStr = "SELECT * From AccountTable WHERE userID = '" + User.UserId + "' ";
                int rowsReturned = 0;
                //Admin data table calling get function from dataBaseMGR
                dataTable.Clear();
                dataTable = dbMgr.getData(sqlStr, out rowsReturned);
                if (rowsReturned > 0)
                {
                    foreach (DataRow dr in dataTable.Rows) // looping though rows
                    {
                        userNameTXT.Text = dr["userName"].ToString();
                        passwordTXT.Text = dr["userPassword"].ToString();
                        firstNameTXT.Text = dr["firstName"].ToString();
                        lastNameTXT.Text = dr["lastName"].ToString();
                        addressTXT.Text = dr["address"].ToString();
                        cityTXT.Text = dr["city"].ToString();
                        stateTXT.Text = dr["state"].ToString();
                        zipTXT.Text = dr["zip"].ToString();
                        emailTXT.Text = dr["alternateEmail"].ToString();
                        schoolEmailTXT.Text = dr["schoolEmail"].ToString();
                        phoneTXT.Text = dr["phone"].ToString();

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void saveChangesBTN_Click(object sender, EventArgs e)
        {
            try
            {
                // read info from screen
                string username = userNameTXT.Text.ToString();
                string userPassword = passwordTXT.Text.ToString();
                string firstName = firstNameTXT.Text.ToString();
                string lastName = lastNameTXT.Text.ToString();
                string address = addressTXT.Text.ToString();
                string city = cityTXT.Text.ToString();

                string state = stateTXT.Text.ToString();
                string zip = zipTXT.Text.ToString();
                string email = emailTXT.Text.ToString();
                string schoolEmail = schoolEmailTXT.Text.ToString();
                string phone = phoneTXT.Text;

                // generate query string
                string sqlstr = "UPDATE AccountTable SET " +
                    "username = '" + username + "', " +
                    "userPassword = '" + userPassword + "', " +
                    "firstName = '" + firstName + "', " +
                    "lastName = '" + lastName + "', " +
                    "schoolEmail = '" + schoolEmail + "', " +
                    "alternateEmail = '" + email + "', " +
                    "address = '" + address + "', " +
                    "city = '" + city + "', " +
                    "state = '" + state + "', " +
                    "zip = '" + zip + "', " +
                    "phone = '" + phone + "' " +
                    "WHERE userID = '" + User.UserId + "' ";

                // Run the update with the dbMgr and check results
                int numRowsUpdated = 0;
                numRowsUpdated = dbMgr.putData(sqlstr);

                if (numRowsUpdated == 1)
                {
                    HomeForm homeform = new HomeForm();

                    MessageBox.Show("User updated", "Modify User Status");
                }
                else
                {
                    MessageBox.Show("User NOT updated", "Modify User Status");

                }
                //updateModifyList(); syntax error
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
