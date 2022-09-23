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
            accountPNL.Enabled = false;

            populateTextBoxes();
        }

        private void saveChangesToolStripMenuItem_Click_1(object sender, EventArgs e)
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
                    "WHERE userID = '" + User.userId + "' ";

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

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //if selected item, enable panel 

            // save the index
            int index = comboBox1.SelectedIndex;
            MessageBox.Show("Select index is: " + index);

            //fill text box with the data from table

            firstNameTXT.Text = dataTable.Rows[index]["firstName"].ToString();
            lastNameTXT.Text = dataTable.Rows[index]["lastName"].ToString();
            userNameTXT.Text = dataTable.Rows[index]["userName"].ToString();
            passwordTXT.Text = dataTable.Rows[index]["userPassword"].ToString();
        }

        private void updateModifyList()
        {
            //step 1 clear all items in list first
            comboBox1.Items.Clear();
            comboBox1.Text = "";


            //step 2 generate query string //loadStudents method
            string sqlStr = "SELECT * FROM Account Table ORDER BY userName ASC";
            int rowsReturned = 0;
            dataTable.Clear();
            dataTable = dbMgr.getData(sqlStr, out rowsReturned);

            //step 3 populate the list with results
            if (rowsReturned > 0)
            {
                //loop through data table and add the names to the list
                foreach (DataRow row in dataTable.Rows)
                {
                    comboBox1.Items.Add(row["userName"].ToString());
                }
            }
        } 
        
        private void ModifyAccountForm_Load(object sender, EventArgs e)
        {
            updateModifyList();
        }

        private void switchToModifyModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accountPNL.Enabled = true;
            saveChangesToolStripMenuItem.Enabled = true;
        }

        private void swtchToViewModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accountPNL.Enabled = false;
            saveChangesToolStripMenuItem.Enabled = true;
        }

        private void populateTextBoxes()
        {

            try
            {
                //SQLite statement
                string sqlStr = "SELECT * From AccountTable WHERE userID = '" + User.userId + "' ";
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

        
    }
}
