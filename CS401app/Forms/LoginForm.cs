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
    public partial class LoginForm : Form
    {
        //variables
        CreateAccountForm createAccountForm;
        HomeForm homeForm;
        
        public DatabaseMgrSQLite dbMgr;
        private DataTable dataTable = new DataTable();
    
        public LoginForm()
        {
            InitializeComponent();
            dbMgr = new DatabaseMgrSQLite();
        }

        private void createNewLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((null == createAccountForm) || (createAccountForm.IsDisposed))
            {
                    createAccountForm = new CreateAccountForm();
            }
            // show account form
            createAccountForm.Show();
        }

        private void LoginBTN_Click_1(object sender, EventArgs e)
        {
            //read info
            string username = userNameInput.Text.ToString();
            string password = userPasswordInput.Text.ToString();

            //step2 generate sql insert statement
            string sqlStr = "SELECT * From AccountTable WHERE userName = '" + username + "' AND userPassword = '" + password + "' ";

            //step 3 get data to database using dbMgr
            int rowsReturned = 0;
            dataTable = dbMgr.getData(sqlStr, out rowsReturned);

            //if rowsReturned == 1, then we found the user
            if (rowsReturned == 1)
            {
                foreach (DataRow dr in dataTable.Rows) // looping though rows
                {
                      User.UserId = Convert.ToInt32(dr["userID"]);
                      User.UserRole = dr["role"].ToString();
                }
                MessageBox.Show("Logged In Successfully! " + "\nWelcome " + username);
                
                if ((homeForm == null || homeForm.IsDisposed))
                {
                    homeForm = new HomeForm();
                }
              
                homeForm.ShowDialog();
                
            }
            else 
            {
                MessageBox.Show("Login failed. Try Again.");
            }

        }
    }

        
}
    