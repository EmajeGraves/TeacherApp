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
    public partial class HomeForm : Form
    {
        
        
        AccountsTableForm accountsTableForm;
        ModifyAccountForm modifyAccountForm;
        NotesForm notesForm;
        RosterForm rosterForm;

        public HomeForm()
        {
            InitializeComponent(); 
        }
        

        private void announcementsBTN_Click(object sender, EventArgs e)
        {

        }

        private void notesBTN_Click(object sender, EventArgs e)
        {
            if((null == notesForm || notesForm.IsDisposed))
            {
                notesForm = new NotesForm();
            }
            notesForm.ShowDialog();
        }

        private void scheduleBTN_Click(object sender, EventArgs e)
        {

        }

        private void hoursBTN_Click(object sender, EventArgs e)
        {

        }

        private void modifyAccountBTN_Click(object sender, EventArgs e)
        {
            if ((null == modifyAccountForm || modifyAccountForm.IsDisposed))
            {
                modifyAccountForm = new ModifyAccountForm();
            }

            modifyAccountForm.ShowDialog();
        }

        private void rosterBTN_Click(object sender, EventArgs e)
        {
            if ((null == rosterForm || rosterForm.IsDisposed))
            {
                rosterForm = new RosterForm();
            }
            rosterForm.ShowDialog();
        }

        
    }
}
