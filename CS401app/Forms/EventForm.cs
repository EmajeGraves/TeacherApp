using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherApp.Forms
{
    public partial class EventForm : Form
    {
        public DatabaseMgrSQLite dbMgr;
        public DataTable calenderDataTable = new DataTable();

        string date = CalendarControls.UserControlDay.static_day + "/" + Calendar.static_month + "/" + Calendar.static_year;

        public EventForm()
        {
            InitializeComponent();
            dbMgr = new DatabaseMgrSQLite();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            dateTXT.Text = date;

            //query information 
            string sqlStr = "SELECT * FROM calendar WHERE date ='" + date + "' and userID = '" + User.UserId + "'";
            int rowsReturned = 0;
            calenderDataTable.Clear();
            calenderDataTable = dbMgr.getData(sqlStr, out rowsReturned);

            //catch thrown error, If DB empty then SAVE, if db populated then MODIFY
            try
            {
                eventTXT.Text = calenderDataTable.Rows[0]["Event"].ToString();
                saveBTN.Enabled = false;
            }
            catch (Exception ex)
            {
                modifyBTN.Enabled = false;
                //System.Windows.Forms.MessageBox.Show(ex.Message, "Exception: getData()");
            }
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            // read info from screen
            string date = dateTXT.Text.ToString();
            string events = eventTXT.Text.ToString();

            // generate query string
            string sqlstr = "INSERT INTO calendar (userID, date, event) " +
                "VALUES ('" + User.UserId + "', '" + date + "', '" + events + "')";
                        
            if (events.Length > 0)
            {
                int numRowsInserted = dbMgr.putData(sqlstr);

                if (numRowsInserted > 0)
                {
                    MessageBox.Show("Event Created!!", "Events Update Status");
                    this.Close();
                }
                else MessageBox.Show("Event Not Created \n Seems there was a problem!!", "Events Update Status");
            }
            else MessageBox.Show("Please Insert A Value!!", "Events Update Status");

        }

        private void modifyBTN_Click(object sender, EventArgs e)
        {
            string sqlstr = "UPDATE calendar " +
               "SET Event = '" + eventTXT.Text +
               "' WHERE date ='" + date + "' AND userID = '" + User.UserId + "'";

            // Run the update with the dbMgr and check results
            int numRowsUpdated = 0;
            numRowsUpdated = dbMgr.putData(sqlstr);

            if (numRowsUpdated > 0)
            {
                MessageBox.Show("Events updated", "Events Update Status");
                this.Close();
            }
            else
            {
                MessageBox.Show("Events NOT updated", "Events Update Status");
            }
        }
    }
}
