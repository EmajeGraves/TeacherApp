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
        //initalize
        //HomeForm homeForm;
        createAnnouncements createAnnouncements;
        ModifyAnnouncements modifyAnnouncements;

        public AnnouncementsForm()
        {
            InitializeComponent();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            //homeForm.Show();
        }

        private void createAnnBTN_Click(object sender, EventArgs e)
        {
            //createAnnouncements.Show();
        }

        private void modifyAnnouncement_Click(object sender, EventArgs e)
        {
            //modifyAnnouncements.Show();
        }

        private void AnnouncementsTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //create new announcement will open
        private void createNewLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (null == createAnnouncements || createAnnouncements.IsDisposed)
            {
                createAnnouncements = new createAnnouncements();
            }

            createAnnouncements.ShowDialog();
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
                createNewLBL.Visible = false;
                HideModify();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* try
            {
                string noteName = notesComboBox.SelectedItem.ToString();
                string sqlStr = "SELECT * FROM Notes WHERE userID = '" + User.UserId + "' And noteName = '" + noteName + "' ";
                int rowsReturned = 0;
                //Admin data table calling get function from dataBaseMGR
                notesDataTable.Clear();
                notesDataTable = dbMgrSQLite.getData(sqlStr, out rowsReturned);
                if (rowsReturned > 0)
                {
                    foreach (DataRow dr in notesDataTable.Rows) // looping though rows
                    {
                        string notesName = dr["noteName"].ToString();
                        string noteData = dr["noteData"].ToString();
                        Notes.NoteID = Convert.ToInt32(dr["notesId"]);

                        NotesTxtBox.Text = noteData.ToString();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }*/
        }

        /*private void PopulateRosterSelectComboBoxData()
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
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            refreshBtn.Enabled = false;
            subjectcomboBox.Enabled = true;
            subjectcomboBox.Items.Clear();

            //PopulateRosterSelectComboBoxData();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ShowModify();
            //createLinkLabel.Enabled = false;
            //selectComboBox1.Enabled = false;
        }


    }
}
