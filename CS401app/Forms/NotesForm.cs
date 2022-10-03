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
            CreateNotesForm.ShowDialog();
        }

        private void notesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateNotesBTN_Click(object sender, EventArgs e)
        {

        }

        private void ModifyNoteBTN_Click(object sender, EventArgs e)
        {

        }

        private void SaveNoteBTN_Click(object sender, EventArgs e)
        {

        }
        public  void PopulateNotesComboBoxData() 
        {
            try
            {
                
                //SQLite statement
                string sqlStr = "SELECT * FROM Notes WHERE userID = '" + User.UserId + "' ";
                int rowsReturned = 0;
                //Admin data table calling get function from dataBaseMGR
                notesDataTable.Clear();
                notesDataTable = dbMgrSQLite.getData(sqlStr, out rowsReturned);
                if (rowsReturned > 0)
                {
                    foreach (DataRow dr in notesDataTable.Rows) // looping though rows
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
            notesComboBox.Items.Clear();

            PopulateNotesComboBoxData();
        }
    }
}
