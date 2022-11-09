using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TeacherApp 
{
    public partial class RosterForm : Form
    {
        // declaring variables
        CreateRoster createRoster;
        public DatabaseMgrSQLite dataBaseMgr;
        private DataTable rosterDataTable = new DataTable();
        
        public RosterForm()
        {
            InitializeComponent();
            dataBaseMgr = new DatabaseMgrSQLite();

            Roster.RosterId = User.UserId;
            PopulateRosterSelectComboBoxData();
            ValidateUserRole();
            
        }
       
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            HideModify();

            createLinkLabel.Enabled = true;
            modifyToolStripMenuItem.Enabled = false;
            selectComboBox1.Enabled = true;
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
            } 
            else
            {
                modifyToolStripMenuItem.Visible = false;
                createLinkLabel.Visible = false;
                HideModify();
            }
        }
       

        private void PopulateAddToRosterBox()
        {
            try
            {
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
                        addComboBox.Items.Add(userId + " " + names);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void PopulateRosterTXT()
        {
            try
            {
                rosterTXT.Clear();

                string rosterName = selectComboBox1.SelectedItem.ToString();
                string sqlStr = "SELECT * FROM RosterTable WHERE UserID = '" + User.UserId + "' And RosterName = '" + rosterName + "' ";
                int rowsReturned = 0;
                //Admin data table calling get function from dataBaseMGR
                rosterDataTable.Clear();
                rosterDataTable = dataBaseMgr.getData(sqlStr, out rowsReturned);
                if (rowsReturned > 0)
                {
                    foreach (DataRow dr in rosterDataTable.Rows) // looping though rows
                    {
                        string notesName = dr["RosterName"].ToString();
                        string noteData = dr["RosterData"].ToString();
                        Roster.RosterId = Convert.ToInt32(dr["RosterID"]);

                        rosterTXT.AppendText(noteData);
                        
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

      

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ShowModify();
            PopulateAddToRosterBox();

            createLinkLabel.Enabled = false;
            selectComboBox1.Enabled = false;
        }

        

        private void createLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(null == createRoster || createRoster.IsDisposed)
            {
                createRoster = new CreateRoster();
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
                string rosterName = selectComboBox1.SelectedItem.ToString();    
                string sqlStr = "SELECT * FROM RosterTable WHERE UserID = '" + User.UserId + "' And RosterName = '" + rosterName + "' ";
                int rowsReturned = 0;
                //Admin data table calling get function from dataBaseMGR
                rosterDataTable.Clear();
                rosterDataTable = dataBaseMgr.getData(sqlStr, out rowsReturned);
                if (rowsReturned > 0)
                {
                    foreach (DataRow dr in rosterDataTable.Rows) // looping though rows
                    {
                        
                        string noteData = dr["RosterData"].ToString();
   
                        Roster.RosterId = Convert.ToInt32(dr["RosterID"]);
                        
                        rosterTXT.AppendText(noteData);
                        rosterTXT.AppendText(Environment.NewLine);

                        modifyToolStripMenuItem.Enabled = true;
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void PopulateRosterSelectComboBoxData()
        {
            try
            {
                string sqlStr = "SELECT * FROM RosterTable WHERE UserID = '" + User.UserId + "' ";
                int rowsReturned = 0;

                rosterDataTable.Clear();
                rosterDataTable = dataBaseMgr.getData(sqlStr, out rowsReturned);
                if (rowsReturned > 0)
                {
                    foreach (DataRow dr in rosterDataTable.Rows)
                    {
                        string rosterName = dr["RosterName"].ToString();
                        selectComboBox1.Items.Add(rosterName);
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
            refreshBTN.Enabled = false;
            selectComboBox1.Enabled = true;
            selectComboBox1.Items.Clear();
            
            PopulateRosterSelectComboBoxData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string addedRosterData = addComboBox.SelectedItem.ToString();
                Roster.RosterData = Roster.RosterData + Environment.NewLine + addedRosterData;

                string sqlstr = "UPDATE RosterTable SET " +
                    "RosterData = '" + Roster.RosterData + "' " + "WHERE RosterID = '" + Roster.RosterId + "' ";

                int numRowsUpdated = 0;
                numRowsUpdated = dataBaseMgr.putData(sqlstr);

                if (numRowsUpdated == 1)
                {
                    PopulateRosterTXT();
                    MessageBox.Show(addedRosterData + " Added!");
                }
                else
                {
                    MessageBox.Show("Roster NOT UPDATED, TRY AGAIN");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void GetSelectedUserID() 
        {
            string s = addComboBox.SelectedItem.ToString();
            string i = s.Substring(0, 3);
            int x = Int32.Parse(i);
            int g = 0;

            /*if (Int32.TryParse(x, out g))
            {
                MessageBox.Show(x);
            } */
            
            
        }


        private void addComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            GetSelectedUserID();
        }
    }
}
