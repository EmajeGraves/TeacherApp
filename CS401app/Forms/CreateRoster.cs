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
                string rosterName = nameTXT.Text;            
                string sqlStr = "INSERT INTO CourseTable(teacherId, courseName) VALUES ('" + User.UserId + "','" + rosterName + "')";

                int rowsInserted = 0;
                rowsInserted = dataBaseMgr.putData(sqlStr);

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
