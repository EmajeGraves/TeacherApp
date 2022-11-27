using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TeacherApp 
{
    public partial class RosterForm : Form
    {
        CreateClass createRoster;
       
        public DatabaseMgrSQLite dataBaseMgr;
        private DataTable rosterDataTable = new DataTable();
        
        public RosterForm()
        {
            InitializeComponent();
            dataBaseMgr = new DatabaseMgrSQLite();

            ValidateUserRole();           
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            HideModify();
            rosterTXT.Clear();
            addComboBox.Text = string.Empty;
            deleteComboBox.Text = string.Empty;
           
            refreshBTN.Enabled = true;
            createLinkLabel.Enabled = true;
            modifyToolStripMenuItem.Enabled = false;      
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ShowModify();
            PopulateAddToRosterBox();
            PopulateDeleteToRosterBox();

            createLinkLabel.Enabled = false;
            selectComboBox1.Enabled = false;

            selectComboBox1.Text = string.Empty;
        }

        private void createLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(null == createRoster || createRoster.IsDisposed)
            {
                createRoster = new CreateClass();
            }

            refreshBTN.Enabled = true;
            selectComboBox1.Enabled = false;
           
            createRoster.ShowDialog();
        }

        private void selectComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                rosterTXT.Clear();

                modifyToolStripMenuItem.Enabled = true;
        
                Course.CourseId = GetSelectedCourseId();

                string sqlStr = "Select AccountTable.firstName, AccountTable.lastName, StudentCourseTable.courseId, StudentCourseTable.userID From AccountTable, StudentCourseTable WHERE AccountTable.userID = StudentCourseTable.userID AND StudentCourseTable.courseId = '" + Course.CourseId + "';";
                int rowsReturned = 0;
                
                rosterDataTable.Clear();
                rosterDataTable = dataBaseMgr.getData(sqlStr, out rowsReturned);
                if (rowsReturned > 0)
                {
                    foreach (DataRow dr in rosterDataTable.Rows) // looping though rows
                    {
                        string firstName = dr["firstName"].ToString();
                        string lastName = dr["lastName"].ToString();    
                        
                        rosterTXT.AppendText(firstName + " " + lastName);
                        rosterTXT.AppendText(Environment.NewLine);                     
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            selectComboBox1.Enabled = true;
            
            selectComboBox1.Items.Clear();
            rosterTXT.Clear();  
            
            selectComboBox1.Text = String.Empty;
            
            ValidateUserRole();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
           try
            {

                if(CheckIfUserInRoster() == true) 
                {
                    MessageBox.Show(addComboBox.SelectedItem.ToString() + " ALREADY IN CLASS.");
                }
                else 
                {
                    int selectedUserId = GetAddSelectedUserID();
                    string sqlStr = "INSERT INTO StudentCourseTable(userID, courseId) VALUES ('" + selectedUserId + "','" + Course.CourseId + "')";
                    int rowsInserted = 0;
                   
                    rowsInserted = dataBaseMgr.putData(sqlStr);

                    if (rowsInserted == 1)
                    {
                        MessageBox.Show(" Student Added");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            } 
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedUserId = GetDeleteSelectedUserID(); 
                string sqlStr = "DELETE FROM StudentCourseTable WHERE userID = '" + selectedUserId + "' AND courseId = '" + Course.CourseId + "' ";
                int rowsInserted = 0;
               
                rowsInserted = dataBaseMgr.putData(sqlStr);              
                if (rowsInserted == 0)
                {
                    MessageBox.Show("Student Deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // make select show course name
        private void PopulateTeacherSelectComboBoxData()
        {
            try
            {
                string sqlStr = "SELECT * FROM CourseTable WHERE teacherId = '" + User.UserId + "' ";
                int rowsReturned = 0;

                rosterDataTable.Clear();
                rosterDataTable = dataBaseMgr.getData(sqlStr, out rowsReturned);
                if (rowsReturned > 0)
                {
                    foreach (DataRow dr in rosterDataTable.Rows)
                    {
                        int courseIds = Convert.ToInt32(dr["courseID"]);
                        string courseName = dr["courseName"].ToString();

                        Course.CourseSelectList.Add(courseIds);
                        selectComboBox1.Items.Add(courseIds +" "+ courseName);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void PopulateStudentSelectComboBoxData()
        {
            try
            {
                string sqlStr = "SELECT * FROM CourseTable, StudentCourseTable WHERE CourseTable.courseID = StudentCourseTable.courseId AND StudentCourseTable.userID = '" + User.UserId + "' ";
                int rowsReturned = 0;

                rosterDataTable.Clear();
                rosterDataTable = dataBaseMgr.getData(sqlStr, out rowsReturned);
                if (rowsReturned > 0)
                {
                    foreach (DataRow dr in rosterDataTable.Rows)
                    {
                        int courseIds = Convert.ToInt32(dr["courseID"]);
                       
                        Course.CourseSelectList.Add(courseIds);
                        selectComboBox1.Items.Add(courseIds);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void PopulateAddToRosterBox()
        {
            try
            {
                Course.AddIdList.Clear();
                addComboBox.Items.Clear();

                string sqlStr = "SELECT * FROM AccountTable WHERE role = \"Student\" ";
                int rowsReturned = 0;

                rosterDataTable.Clear();
                rosterDataTable = dataBaseMgr.getData(sqlStr, out rowsReturned);

                if (rowsReturned > 0)
                {
                    foreach (DataRow dr in rosterDataTable.Rows)
                    {
                        string names = dr["firstName"].ToString() + " " + dr["lastName"].ToString();
                        int userId = Convert.ToInt32(dr["userID"]);

                        Course.AddIdList.Add(userId);
                        addComboBox.Items.Add(userId + " " + names);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void PopulateDeleteToRosterBox()
        {
            try
            {
                Course.DeleteIdList.Clear();
                deleteComboBox.Items.Clear();

                string sqlStr = "SELECT StudentCourseTable.userID, AccountTable.firstName, AccountTable.lastName FROM AccountTable, StudentCourseTable WHERE StudentCourseTable.userID = AccountTable.userID AND StudentCourseTable.courseId = '" + Course.CourseId + "' ";
                int rowsReturned = 0;

                rosterDataTable.Clear();
                rosterDataTable = dataBaseMgr.getData(sqlStr, out rowsReturned);

                if (rowsReturned > 0)
                {
                    foreach (DataRow dr in rosterDataTable.Rows)
                    {
                        string names = dr["firstName"].ToString() + " " + dr["lastName"].ToString();
                        int userId = Convert.ToInt32(dr["userID"]);

                        Course.DeleteIdList.Add(userId);

                        deleteComboBox.Items.Add(userId + " " + names);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private int GetAddSelectedUserID()
        {
            int indexOfAddComboBox = addComboBox.SelectedIndex;
            int newRosterData = Course.AddIdList[indexOfAddComboBox];

            return newRosterData;
        }

        private int GetDeleteSelectedUserID()
        {
            int indexOfDeleteComboBox = deleteComboBox.SelectedIndex;
            int newRosterData = Course.DeleteIdList[indexOfDeleteComboBox];

            return newRosterData;
        }

        private int GetSelectedCourseId()
        {
            int indexOfSelectComboBox = selectComboBox1.SelectedIndex;
            int newRosterData = Course.CourseSelectList[indexOfSelectComboBox];

            return newRosterData;
        }

        private bool CheckIfUserInRoster()
        { 
            int selectedUserId = GetAddSelectedUserID();
            string sqlStr = "SELECT * From StudentCourseTable WHERE UserID = '" + selectedUserId + "' AND CourseId = '" + Course.CourseId + "' ";
            int rowsReturned = 0;
            
            rosterDataTable = dataBaseMgr.getData(sqlStr, out rowsReturned);

            if (rowsReturned == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void ShowModify()
        {
            modifyPNL.Enabled = true;
            modifyPNL.Visible = true;
        }

        private void HideModify()
        {
            modifyPNL.Enabled = false;
            modifyPNL.Visible = false;
        }

        private void ValidateUserRole()
        {
            if (User.UserRole == "Teacher" || User.UserRole == "Admin")
            {
                HideModify();
                PopulateTeacherSelectComboBoxData();
            }
            else
            {
                modifyToolStripMenuItem.Visible = false;
                createLinkLabel.Visible = false;
                HideModify();
                PopulateStudentSelectComboBoxData();
            }
        }
    }
}

