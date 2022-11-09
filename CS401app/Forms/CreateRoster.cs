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
    public partial class CreateRoster : Form
    {
        public DatabaseMgrSQLite dataBaseMgr;
        public CreateRoster()
        {
            InitializeComponent();
            dataBaseMgr = new DatabaseMgrSQLite();
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            try
            {
                // Saving text to variable
                string rosterName = nameTXT.Text;

                // creting sqlite statement
                string sqlStr = "INSERT INTO RosterTable(UserID, RosterName) VALUES ('" + User.UserId + "','" + rosterName + "')";

                // send data to data base
                int rowsInserted = 0;
                rowsInserted = dataBaseMgr.putData(sqlStr);

                // checking to make sure account was created
                if (rowsInserted == 1)
                {
                    MessageBox.Show(rosterName + " CREATED");
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
