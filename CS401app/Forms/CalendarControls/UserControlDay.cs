using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherApp.Forms.CalendarControls
{
    public partial class UserControlDay : UserControl
    {
        //static vaariable for days to EventForm
        public static string static_day;
        string date = static_day + "/" + Calendar.static_month + "/" + Calendar.static_year;

        public DatabaseMgrSQLite dbMgr;
        public DataTable calenderDataTable = new DataTable();

        public UserControlDay()
        {
            InitializeComponent();
            dbMgr = new DatabaseMgrSQLite();
        }

        private void UserControlDay_Click(object sender, EventArgs e)
        {
            static_day = daysLBL.Text;
            timer1.Start();
            EventForm eventform = new EventForm();
            eventform.Show();
        }

        private void UserControlDay_Load(object sender, EventArgs e)
        {
            displayEvents();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvents();
        }

        public void days(int numday)
        {
            daysLBL.Text = numday + "";
        }

        public void displayEvents()
        {
            string date = daysLBL.Text + "/" + Calendar.static_month + "/" + Calendar.static_year;

            //query information 
            string sqlStr = "SELECT * FROM calendar WHERE date ='" + date + "' and userID = '" + User.UserId + "'";
            int rowsReturned = 0;
            calenderDataTable.Clear();
            calenderDataTable = dbMgr.getData(sqlStr, out rowsReturned);

            //catch thrown error, If DB empty then SAVE, if db populated then MODIFY
            try
            {
                displayEventLBL.Text = calenderDataTable.Rows[0]["Event"].ToString();
            }
            catch (Exception ex)
            {
                displayEventLBL.Text = "";
                //System.Windows.Forms.MessageBox.Show(ex.Message, "Exception: getData()");
            }
        }
    }
}
