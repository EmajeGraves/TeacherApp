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
        //CreateAnnouncements createAnnouncements;
        //ModifyAnnouncements modifyAnnouncements;

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
    }
}
