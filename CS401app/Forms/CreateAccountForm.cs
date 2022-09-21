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
    public partial class CreateAccountForm : Form
    {
        // declaring variables
        public DatabaseMgrSQLite dataBaseMgr;
        private DataTable adminDataTable = new DataTable();
        public CreateAccountForm()
        {
            InitializeComponent();
            dataBaseMgr = new DatabaseMgrSQLite();
        }

        private void mainContentPNL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fileMainMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mainMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewModeMenuItem_Click(object sender, EventArgs e)
        {
            //Do not allow changes
            mainContentPNL.Enabled = false;
        }

        private void modifyModeMenuItem_Click(object sender, EventArgs e)
        {
            //Allow changes
            mainContentPNL.Enabled = true;
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes Saved");
        }

        private void closeMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Close Clicked");
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("About Clicked");
        }

       
            

        private void createBTN_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Saving text to variable
                string userName = usernameTXT.Text;
                string userPassword = passwordTXT.Text;
                string firstName = firstNameTXT.Text;
                string lastName = lastNameTXT.Text;
                string role = roleComboBox.Text;
                string address = streetTXT.Text + " " + cityTXT.Text + " " + stateComboBX.Text + " " + zipCodeTXT.Text;
                string email = emailTXT.Text;
                string schoolEmail = schoolEmailTXT.Text;
                string phone = phoneTXT.Text;
                
                // creting sqlite statement
                string sqlStr = "INSERT INTO AccountTable(userID, userName, userPassword, firstName, lastName, schoolEmail, alternateEmail, address, phone, role) VALUES ( abs(random() % 5000),'" + userName + "','" + userPassword + "','" + firstName + "','" + lastName + "','" + schoolEmail + "','" + email + "','" + address + "','" + phone + "','" + role + "')";

                // send data to data base
                int rowsInserted = 0;
                rowsInserted = dataBaseMgr.putData(sqlStr);

                // checking to make sure account was created
                if (rowsInserted == 1)
                {
                    MessageBox.Show("Account Created!");
                }
                else
                {
                    MessageBox.Show("Error , Try Again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
