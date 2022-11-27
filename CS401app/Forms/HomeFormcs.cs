using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherApp.Forms;

namespace TeacherApp
{
    public partial class HomeForm : Form
    {


        AnnouncementsForm announcementsForm;
        ClassLookUp classLookUp;
        ClassSchedule classSchedule;
        ModifyAccountForm modifyAccountForm;
        NotesForm notesForm;
        RosterForm rosterForm;

        public HomeForm()
        {
            InitializeComponent();
        }
        

        private void announcementsBTN_Click(object sender, EventArgs e)
        {
            if(null == announcementsForm|| announcementsForm.IsDisposed)
            {
                announcementsForm = new AnnouncementsForm();
            }
        
            announcementsForm.ShowDialog();
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
            if ((null == classSchedule || classSchedule.IsDisposed))
            {
                classSchedule = new ClassSchedule();
            }
            classSchedule.ShowDialog();
        }

        private void hoursBTN_Click(object sender, EventArgs e)
        {
            if (null == classLookUp || classLookUp.IsDisposed)
            {
                classLookUp = new ClassLookUp();
            }
            classLookUp.ShowDialog();
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
