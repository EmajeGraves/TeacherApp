using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senior_Project
{
    public partial class createAnnouncements : Form
    {
        //variables
       // public DatabaseMgrSQLite dbMgr;
        //private DataTable dataTable = new DataTable();

        public createAnnouncements()
        {
            InitializeComponent();
            //dbMgr = new DatabaseMgrSQLite();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submitAnnouncementBtn_Click(object sender, EventArgs e)
        {
            /*
            //step 1: read and store data from file
            string subject = subjectTXT.Text;
            string announcement = announcementTXT.Text;

            //step2 generate sql insert statement
            string sqlStr = "INSERT INTO Students ('subject', 'announcement') VALUES('" + subject + "', '" + announcement + "')";;

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
    }
}
