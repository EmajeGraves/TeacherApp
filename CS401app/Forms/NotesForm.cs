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
    public partial class NotesForm : Form
    {
        CreateNotesForm CreateNotesForm;
        DatabaseMgrSQLite dbMgrSQLite;
        private DataTable notesDataTable = new DataTable();
        
        public NotesForm()
        {
            InitializeComponent();
           
            dbMgrSQLite = new DatabaseMgrSQLite();        
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if((null == CreateNotesForm || CreateNotesForm.IsDisposed))
            {
                CreateNotesForm = new CreateNotesForm();
            }
            notesComboBox.Enabled = false;
            NotesTxtBox.ReadOnly = true;
            updateNoteBTN.Enabled = false;
            
            CreateNotesForm.ShowDialog();
        }

        private void notesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
            }
        }


        private void ModifyNoteBTN_Click(object sender, EventArgs e)
        {
            notesComboBox.Enabled = false;
            updateNoteBTN.Enabled = true;
            
            NotesTxtBox.ReadOnly = false;
        }

        private void SaveNoteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string noteTxtData = NotesTxtBox.Text.ToString();

                string sqlstr = "UPDATE Notes SET " +
                    "noteData = '" + noteTxtData + "' " + "WHERE userID = '" + User.UserId + "' And notesId = '" + Notes.NoteID + "' ";

                int numRowsUpdated = 0;
                numRowsUpdated = dbMgrSQLite.putData(sqlstr);

                if (numRowsUpdated == 1)
                {
                    HomeForm homeform = new HomeForm();
                    NotesTxtBox.ReadOnly = true;

                    MessageBox.Show("NOTE UPDATED!");
                }
                else
                {
                    MessageBox.Show("NOTE NOT UPDATED, TRY AGAIN");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
       
        public void PopulateNotesComboBoxData() 
        {
            try
            {               
                string sqlStr = "SELECT * FROM Notes WHERE userID = '" + User.UserId + "' ";
                int rowsReturned = 0;
                
                notesDataTable.Clear();
                notesDataTable = dbMgrSQLite.getData(sqlStr, out rowsReturned);
                if (rowsReturned > 0)
                {
                    foreach (DataRow dr in notesDataTable.Rows) 
                    {
                        string notesName = dr["noteName"].ToString();
                        notesComboBox.Items.Add(notesName);
                    }
                }              
            }
            catch (Exception)
            { 
                throw;
            }
        }

        private void viewBTN_Click(object sender, EventArgs e)
        {
            notesComboBox.Enabled = true;
            updateNoteBTN.Enabled = false;
            NotesTxtBox.ReadOnly = true;
           
            notesComboBox.Items.Clear();

            PopulateNotesComboBoxData();
        }
    }
}
