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
        public DatabaseMgrSQLite dbMgr;
        public DataTable finalDataTable = new DataTable();
        public int userId = 0;

        public ModifyAccountForm()
        {
            InitializeComponent();

            dbMgr = new DatabaseMgrSQLite();

            //disable data panel and update button
            accountPNL.Enabled = false;
            saveChangesToolStripMenuItem.Enabled = false;
        }

        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // read info from screen
            string firstName = firstNameTXT.Text.ToString();
            string lastName = lastNameTXT.Text.ToString();
            string username = userNameTXT.Text.ToString();
            string password = passwordTXT.Text.ToString();

            // generate query string
            string sqlstr = "update 'Account Table' set " +
                "firstName = '" + firstName + "', " +
                "lastName = '" + lastName + "', " +
                "userName = '" + username + "', " +
                "useerPassword = '" + password + "' " +
                "where userID = " + userId + "";

            // Run the update with the dbMgr and check results
            int numRowsUpdated = 0;
            numRowsUpdated = dbMgr.putData(sqlstr);

            if (numRowsUpdated > 0)
            {
                MessageBox.Show("User updated", "Modify User Status");
            }
            else
            {
                MessageBox.Show("User NOT updated", "Modify User Status");

            }

            // Update the student list 
           // updateModifyList();

            //disable panel
            //clearStudentDataFields();
            accountPNL.Enabled = false;
        }
        /*
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if selected item, enable panel 
            accountPNL.Enabled = true;

            // save the index
            int index = comboBox1.SelectedIndex;
            MessageBox.Show("Select index is: " + index);

            //fill text box with the data from table
            userId = Convert.ToInt32(finalDataTable.Rows[index]["userID"].ToString());
            firstNameTXT.Text = finalDataTable.Rows[index]["firstName"].ToString();
            lastNameTXT.Text = finalDataTable.Rows[index]["lastName"].ToString();
            userNameTXT.Text = finalDataTable.Rows[index]["userName"].ToString();
            passwordTXT.Text = finalDataTable.Rows[index]["userPassword"].ToString();
        }

        private void updateModifyList()
        {
            //step 1 clear all items in list first
            Items.Clear();
            comboBox1.Text = "";


            //step 2 generate query string //loadStudents method
            string sqlStr = "SELECT * FROM 'Account Table' ORDER BY userName ASC";
            int rowsReturned = 0;
            finalDataTable.Clear();
            finalDataTable = dbMgr.getData(sqlStr, out rowsReturned);

            //step 3 populate the list with results
            if (rowsReturned > 0)
            {
                //loop through data table and add the names to the list
                foreach (DataRow row in finalDataTable.Rows)
                {
                    comboBox1.Items.Add(row["userName"].ToString());
                }
            }
        } 

        private void ModifyAccountForm_Load(object sender, EventArgs e)
        {
            updateModifyList();
        } */
    }
}
