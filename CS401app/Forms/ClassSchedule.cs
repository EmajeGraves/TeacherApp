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
    public partial class ClassSchedule : Form
    {
        CreateClass createClass;

        public DatabaseMgrSQLite dbMgr;
        public DataTable dataTable = new DataTable();

        public ClassSchedule()
        {
            InitializeComponent();

            dbMgr = new DatabaseMgrSQLite();
            ValidateUserRole();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(null == createClass || createClass.IsDisposed) { createClass = new CreateClass(); }
            createClass.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ValidateUserRole();
        }

        private void PopulateStudentClassText()
        {
            try
            {
                courseTXT.Clear();

                
                string sqlStr = "Select Distinct CourseTable.courseName, CourseTable.title, CourseTable.credits, CourseTable.term FROM CourseTable, StudentCourseTable WHERE CourseTable.courseId = StudentCourseTable.courseId AND StudentCourseTable.userId = '" + User.UserId + "';";
                int rowsReturned = 0;

                dataTable.Clear();
                dataTable = dbMgr.getData(sqlStr, out rowsReturned);
                if (rowsReturned > 0)
                {
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        string courseName = dr["courseName"].ToString();
                        string title = dr["title"].ToString();
                        string credits = dr["credits"].ToString();
                        string term = dr["term"].ToString();

                        courseTXT.AppendText(courseName + "  " + title + "  " + credits + "  " + term);
                        courseTXT.AppendText(Environment.NewLine);  
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void PopulateTeacherClassText()
        {
            try
            {
                courseTXT.Clear();


                string sqlStr = "Select Distinct CourseTable.courseName, CourseTable.title, CourseTable.credits, CourseTable.term FROM CourseTable WHERE CourseTable.teacherId = '" + User.UserId + "';";
                int rowsReturned = 0;

                dataTable.Clear();
                dataTable = dbMgr.getData(sqlStr, out rowsReturned);
                if (rowsReturned > 0)
                {
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        string courseName = dr["courseName"].ToString();
                        string title = dr["title"].ToString();
                        string credits = dr["credits"].ToString();
                        string term = dr["term"].ToString();

                        courseTXT.AppendText(courseName + "  " + title + "  " + credits + "  " + term);
                        courseTXT.AppendText(Environment.NewLine);
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
                PopulateTeacherClassText();
            }
            else if (User.UserRole == "Student")
            {
                PopulateStudentClassText();
                newToolStripMenuItem.Visible= false;
            }
        }
    }
}
