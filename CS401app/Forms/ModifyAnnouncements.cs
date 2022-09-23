using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senior_Project
{
    public partial class ModifyAnnouncements : Form
    {
        /*variables
        public DatabaseMgrSQLite dbMgr;
        private DataTable dataTable = new DataTable();
        public int userId = 0;
        */
        public ModifyAnnouncements()
        {
            InitializeComponent();
            /*
            //create new database
            dbMgr = new DatabaseMgrSQLite();

            //disable data panel and update button
            ModifyStudentPanel.Enabled = false;
            UpdateBtn.Enabled = false;
            */
        }

        /*
        private void clearStudentDataFields()
        {
            //clear data panel and update button
            userId = 0;
            nameTXT.Text = "";
            majorTXT.Text = "";
            gpaTXT.Text = "";


        }
        */

        private void ModifyAnnouncements_Load(object sender, EventArgs e)
        {
            //updateModifyList();
        }

        private void submitAnnouncementBtn_Click(object sender, EventArgs e)
        {

        }

    }
}
