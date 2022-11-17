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
    public partial class AnnouncementsForm : Form
    {
        
         CreateAnnouncements createAnnouncements;

        public DatabaseMgrSQLite dataBaseMgr;
        private DataTable rosterDataTable = new DataTable();

        public AnnouncementsForm()
        {
            InitializeComponent();

            dataBaseMgr = new DatabaseMgrSQLite();

            ValidateUserRole(); 
        }   
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null == createAnnouncements || createAnnouncements.IsDisposed)
            {
                createAnnouncements = new CreateAnnouncements();
            }
            createAnnouncements.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ValidateUserRole();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PopulateStudentAnnouncements() 
        {
            try
            {
                announcementsTXT.Clear();

                string announcements = announcementsTXT.Text;
                string sqlStr = "Select Distinct AnnouncementTable.date, AnnouncementTable.announcementData From AnnouncementTable, CourseTable, StudentCourseTable WHERE AnnouncementTable.courseId = StudentCourseTable.courseId AND StudentCourseTable.userId = '" + User.UserId + "';";
                int rowsReturned = 0;

                rosterDataTable.Clear();
                rosterDataTable = dataBaseMgr.getData(sqlStr, out rowsReturned);
                if (rowsReturned > 0)
                {
                    foreach (DataRow dr in rosterDataTable.Rows)
                    {
                        string date = dr["date"].ToString();
                        string announcementData = dr["announcementData"].ToString();

                        announcementsTXT.AppendText(date + " - " + announcementData);
                        announcementsTXT.AppendText(Environment.NewLine);

                        modifyToolStripMenuItem.Enabled = true;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void PopulateTeachersAnnouncements() 
        {
            try
            {
                announcementsTXT.Clear();

                string announcements = announcementsTXT.Text;
                string sqlStr = "Select DISTINCT AnnouncementTable.date, AnnouncementTable.announcementData From AnnouncementTable, CourseTable, StudentCourseTable WHERE AnnouncementTable.courseId = StudentCourseTable.courseId AND CourseTable.teacherId = '" + User.UserId + "';";
                int rowsReturned = 0;

                rosterDataTable.Clear();
                rosterDataTable = dataBaseMgr.getData(sqlStr, out rowsReturned);
                if (rowsReturned > 0)
                {
                    foreach (DataRow dr in rosterDataTable.Rows)
                    {
                        string date = dr["date"].ToString();
                        string announcementData = dr["announcementData"].ToString();

                        announcementsTXT.AppendText(date + " - " + announcementData);
                        announcementsTXT.AppendText(Environment.NewLine);

                        modifyToolStripMenuItem.Enabled = true;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ValidateUserRole()
        {
            if (User.UserRole == "Teacher" || User.UserRole == "Admin")
            {
                PopulateTeachersAnnouncements();
            }
            else
            {
                PopulateStudentAnnouncements();
                StudentScreen();
            }
        }

        private void StudentScreen()
        {
            menuStrip1.Visible= false;
        }
    }
}
