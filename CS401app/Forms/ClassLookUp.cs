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
    public partial class ClassLookUp : Form
    {
        public DatabaseMgrSQLite dbMgr;
        public DataTable dataTable = new DataTable();

        public ClassLookUp()
        {
            InitializeComponent();

            dbMgr = new DatabaseMgrSQLite();
            PopulateAvailiableCourses();
        }

        private void PopulateAvailiableCourses()
        {
            try
            {
                string sqlStr = "Select DISTINCT CourseTable.courseID, CourseTable.courseName, CourseTable.title, AccountTable.firstName, AccountTable.lastName, CourseTable.credits, CourseTable.term FROM AccountTable, CourseTable Where AccountTable.userID = CourseTable.teacherId";
                int rowsReturned = 0;

                dataTable.Clear();
                dataTable = dbMgr.getData(sqlStr, out rowsReturned);
                if (rowsReturned > 0)
                {
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        int id = Convert.ToInt32(dr["courseID"]); 
                        string courseName = dr["courseName"].ToString();
                        string title = dr["title"].ToString();
                        string name = dr["firstName"].ToString() + " " + dr["lastName"].ToString();
                        string credits = dr["credits"].ToString();
                        string term = dr["term"].ToString();

                        courseTXT.AppendText(id + "  " + courseName + "  " + title + "  " + name + "  " + credits + "  " + term);
                        courseTXT.AppendText(Environment.NewLine);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
