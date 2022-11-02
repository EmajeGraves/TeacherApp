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
    public partial class createAnnouncements : Form
    {
        // declaring variables
        public DatabaseMgrSQLite dataBaseMgr;

        public createAnnouncements()
        {
            InitializeComponent();
            dataBaseMgr = new DatabaseMgrSQLite();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submitAnnouncementBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes Saved");
            try
            {
                // Saving text to variable
                string subject = subjectTXT.Text;
                string announcement = announcementTxt.Text;

                // creting sqlite statement
                string sqlStr = "INSERT INTO Students ('subject', 'announcement') VALUES('" + subject + "', '" + announcement + "')";

                // send data to data base
                int rowsInserted = 0;
                rowsInserted = dataBaseMgr.putData(sqlStr);

                // checking to make sure announcement was created
                if (rowsInserted == 1)
                {
                    MessageBox.Show("Announcement Created!");
                    Close();
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
            /*
            //step 1: read and store data from file
            string subject = subjectTXT.Text;
            string announcement = announcementTXT.Text;

            //step2 generate sql insert statement
            string sqlStr = "INSERT INTO Students ('subject', 'announcement') VALUES('" + subject + "', '" + announcement + "')";

            //step 3 send data to database using dbMgr
            int rowsInserted = 0;
            rowsInserted = dbMgr.putData(sqlStr);

            //test 3 
            MessageBox.Show("Inserted " + rowsInserted + " rows");

            //step 4 display success or error

            if (rowsInserted == 1)
            {
                MessageBox.Show("Data added Successfully");
            }
            else
            {
                MessageBox.Show("Error: Not added successfully");
            }
            */
        }

        private void createAnnouncements_Load(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
