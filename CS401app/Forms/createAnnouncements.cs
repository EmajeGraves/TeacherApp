using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherApp.Forms;

namespace TeacherApp
{
    public partial class CreateAnnouncements : Form
    {
        // declaring variables
        public DatabaseMgrSQLite dataBaseMgr;
        private DataTable rosterDataTable = new DataTable();

        public CreateAnnouncements()
        {
            InitializeComponent();
            dataBaseMgr = new DatabaseMgrSQLite();

            PopulateSelectCourseId();
        }

        private void submitAnnouncementBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int courseId = Convert.ToInt32(selectComboBox.SelectedItem);
                string subject = subjectTXT.Text;
                string date = dateTimePicker.Text;
                string announcement = announcementTXT.Text; 
                string sqlStr = "INSERT INTO AnnouncementTable(courseID, userId, subject, date, announcementData) VALUES ('" + courseId + "','" + User.UserId + "','" + subject + "','" + date + "','" + announcement + "')";

                int rowsInserted = 0;
                rowsInserted = dataBaseMgr.putData(sqlStr);

                if (rowsInserted == 1)
                {  
                    MessageBox.Show( "Announcement Sent");

                    ClearTexts();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void PopulateSelectCourseId()
        {
            try
            {
                selectComboBox.Items.Clear();
                string sqlStr = "SELECT * FROM CourseTable WHERE teacherId = '" + User.UserId + "' ";
                int rowsReturned = 0;

                rosterDataTable.Clear();
                rosterDataTable = dataBaseMgr.getData(sqlStr, out rowsReturned);
                if (rowsReturned > 0)
                {
                    foreach (DataRow dr in rosterDataTable.Rows)
                    {
                        int courseIds = Convert.ToInt32(dr["courseID"]);                
              
                        selectComboBox.Items.Add(courseIds);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ClearTexts()
        {
            selectComboBox.Items.Clear();
            subjectTXT.Clear();
            announcementTXT.Clear();
        }
    }
}
