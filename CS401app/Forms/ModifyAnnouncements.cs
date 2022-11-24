using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherApp.Forms;

namespace TeacherApp

{
    public partial class ModifyAnnouncements : Form
    {
  
        public DatabaseMgrSQLite dbMgr;
        public DataTable dataTable = new DataTable();
        
        
        public ModifyAnnouncements()
        {
            InitializeComponent();
            
            dbMgr = new DatabaseMgrSQLite();

            PopulateSubjectComboBox();  
        }

        private void submitAnnouncementBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetSelectedCourseID();
                string announcementData = AnnouncementTXT.Text;
                string sqlstr = "UPDATE AnnouncementTable SET " +
                    "announcementData = '" + announcementData + "' " +
                    "WHERE announcementId = '" + id + "' ";

                int numRowsUpdated = 0;
                numRowsUpdated = dbMgr.putData(sqlstr);

                if (numRowsUpdated == 1)
                {
                    selectSubjectComboBox.Text = string.Empty;
                    AnnouncementTXT.Text = string.Empty;
                    
                    MessageBox.Show("Announcement updated", "Modify Announcement Status");
                    Close();
                }
                else
                {
                    MessageBox.Show("Announcement NOT updated", "Modify Announcement Status");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    

        private void selectSubjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnnouncementTXT.Enabled = true;
            PopulateEditText();
        }
        private void PopulateSubjectComboBox() 
        {
            try
            {      
                selectSubjectComboBox.Items.Clear();

                string sqlStr = "SELECT * FROM AnnouncementTable WHERE userId = '" + User.UserId + "' ";
                int rowsReturned = 0;

                dataTable.Clear();
                dataTable = dbMgr.getData(sqlStr, out rowsReturned);

                if (rowsReturned > 0)
                {
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        int id = Convert.ToInt32(dr["announcementId"]);
                        string subject = dr["subject"].ToString();
                        
                        selectSubjectComboBox.Items.Add(id + " " + subject);
                        Announcements.AnnouncementIdList.Add(id);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void PopulateEditText() 
        {
            try
            {
                AnnouncementTXT.Clear();

                int id = GetSelectedCourseID();

                string sqlStr = "Select * FROM AnnouncementTable WHERE announcementId = '" + id + "';";
                int rowsReturned = 0;

                dataTable.Clear();
                dataTable = dbMgr.getData(sqlStr, out rowsReturned);
                if (rowsReturned > 0)
                {
                    foreach (DataRow dr in dataTable.Rows) // looping though rows
                    {
                        string data = dr["announcementData"].ToString();

                        AnnouncementTXT.AppendText(data);
                        AnnouncementTXT.AppendText(Environment.NewLine);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private int GetSelectedCourseID()
        {
            int indexOfSelectComboBox = selectSubjectComboBox.SelectedIndex;
            int announccemnetId = Announcements.AnnouncementIdList[indexOfSelectComboBox];

            return announccemnetId;
        }

        
    }
}
