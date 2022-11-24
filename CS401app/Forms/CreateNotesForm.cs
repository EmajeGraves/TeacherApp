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
    public partial class CreateNotesForm : Form
    {
        public DatabaseMgrSQLite dataBaseMgr;
        public CreateNotesForm()
        {
            InitializeComponent();
            dataBaseMgr = new DatabaseMgrSQLite();
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string noteName = noteNameTxtBOX.Text;
                string noteData = noteTXT.Text;
              
                string sqlStr = "INSERT INTO Notes(userID, noteName, noteData) VALUES ('" + User.UserId + "','" + noteName + "','" + noteData + "')";

                int rowsInserted = 0;
                rowsInserted = dataBaseMgr.putData(sqlStr);

                if (rowsInserted == 1)
                {
                    MessageBox.Show("NOTE CREATED!");
                    Close();
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }     
    }
}
