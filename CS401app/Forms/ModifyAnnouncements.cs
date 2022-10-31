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
    public partial class ModifyAnnouncements : Form
    {
        //variables
        public DatabaseMgrSQLite dbMgr;
        public DataTable dataTable = new DataTable();
        //public int userId = 0;
        
        public ModifyAnnouncements()
        {
            InitializeComponent();
            
            //create new database
            dbMgr = new DatabaseMgrSQLite();

            //populateTextBoxes();
        }

        /*private void populateTextBoxes()
        {

            try
            {
                //SQLite statement
                string sqlStr = "SELECT * From AnnouncementsTable WHERE userID = '" + User.UserId + "' ";
                int rowsReturned = 0;
                //Admin data table calling get function from dataBaseMGR
                dataTable.Clear();
                dataTable = dbMgr.getData(sqlStr, out rowsReturned);
                if (rowsReturned > 0)
                {
                    foreach (DataRow dr in dataTable.Rows) // looping though rows
                    {
                        announcements.Text = dr["userName"].ToString();
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
            }*/

        /*
        private void clearStudentDataFields()
        {
            //clear data panel and update button
            userId = 0;
            nameTXT.Text = "";
            majorTXT.Text = "";
            gpaTXT.Text = "";


        }
        */

        private void ModifyAnnouncements_Load(object sender, EventArgs e)
        {
            //updateModifyList();
        }

        private void submitAnnouncementBtn_Click(object sender, EventArgs e)
        {

        }

    }
}
