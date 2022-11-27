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
        ModifyAnnouncements modifyAnnouncements;

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
            if(null == modifyAnnouncements || modifyAnnouncements.IsDisposed) { modifyAnnouncements = new ModifyAnnouncements();}
            
            modifyAnnouncements.ShowDialog();
        }

        private void PopulateStudentAnnouncements() 
        {
            try
            {
                announcementsTXT.Clear();

                string announcements = announcementsTXT.Text;
                string sqlStr = "Select Distinct AnnouncementTable.date, AnnouncementTable.courseId, AnnouncementTable.announcementData From AnnouncementTable, CourseTable, StudentCourseTable WHERE AnnouncementTable.courseId = StudentCourseTable.courseId AND StudentCourseTable.userId = '" + User.UserId + "';";
                int rowsReturned = 0;

                rosterDataTable.Clear();
                rosterDataTable = dataBaseMgr.getData(sqlStr, out rowsReturned);
                if (rowsReturned > 0)
                {
                    foreach (DataRow dr in rosterDataTable.Rows)
                    {
                        string courseId = dr["courseId"].ToString();
                        string date = dr["date"].ToString();
                        string announcementData = dr["announcementData"].ToString();

                        announcementsTXT.AppendText("\n" + courseId + " - " + date + " - " + announcementData);
                        
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
                string sqlStr = "Select DISTINCT AnnouncementTable.courseId, AnnouncementTable.date, AnnouncementTable.announcementData From AnnouncementTable WHERE AnnouncementTable.userId = '" + User.UserId + "';";
                int rowsReturned = 0;

                rosterDataTable.Clear();
                rosterDataTable = dataBaseMgr.getData(sqlStr, out rowsReturned);
                if (rowsReturned > 0)
                {
                    foreach (DataRow dr in rosterDataTable.Rows)
                    {
                        string courseId = dr["courseId"].ToString();
                        string date = dr["date"].ToString();
                        string announcementData = dr["announcementData"].ToString();

                        announcementsTXT.AppendText(courseId +  " - " + date + " - " + announcementData + "\n");      
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
            else if (User.UserRole == "Student")
            {
     
                createToolStripMenuItem.Visible = false;
                modifyToolStripMenuItem.Visible = false;
                refreshToolStripMenuItem.Visible = false;   
                menuStrip1.Visible = false;
                PopulateStudentAnnouncements();
            }
        }
    }
}
