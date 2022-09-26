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
        
        public NotesForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if((null == CreateNotesForm || CreateNotesForm.IsDisposed))
            {
                CreateNotesForm = new CreateNotesForm();
            }
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
    }
}
