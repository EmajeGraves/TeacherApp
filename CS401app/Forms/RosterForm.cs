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
    public partial class RosterForm : Form
    {
        // declaring variables
        public DatabaseMgrSQLite dataBaseMgr;
        private DataTable rosterDataTable = new DataTable();
        public RosterForm()
        {
            InitializeComponent();
            dataBaseMgr = new DatabaseMgrSQLite(); // creaing instance of databasemgrSqlite

        }
        private void viewRosterBTN_Click(object sender, EventArgs e)
        {
            try
            {
                viewRosterBTN.Enabled = false;
                ViewMode();
                //SQLite statement
                string sqlStr = "SELECT * FROM AccountTable";
                int rowsReturned = 0;
                //Admin data table calling get function from dataBaseMGR
                rosterDataTable.Clear();
                rosterDataTable = dataBaseMgr.getData(sqlStr, out rowsReturned);
                if (rowsReturned > 0)
                {
                    foreach (DataRow dr in rosterDataTable.Rows) // looping though rows
                    {
                      // savving data from dr to msg then appinging to "adminTXT"
                        string msg = dr["userID"].ToString() + " | " + dr["userName"].ToString() + " | " + dr["userPassword"].ToString() + " | " + 
                            dr["firstName"].ToString() + " | " + dr["lastName"].ToString() + " | " + dr["schoolEmail"].ToString() + " | " + dr["alternateEmail"].ToString()
                            + " " + dr["address"].ToString() + " | " + dr["phone"].ToString() + " | " + dr["role"].ToString();
                        
                        rosterTXT.AppendText(msg);
                        rosterTXT.AppendText(Environment.NewLine);
                    }
                }
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
        public void ViewMode() //  function to make sure the textbox is in readonly mode
        {
            rosterTXT.ReadOnly = true;

        }
    }
}
