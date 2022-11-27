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
    public partial class CreateClass : Form
    {
        public DatabaseMgrSQLite dataBaseMgr;
        public CreateClass()
        {
            InitializeComponent();
            dataBaseMgr = new DatabaseMgrSQLite();
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            try
            {       
                string courseName = nameTXT.Text; 
                string title = titleTXT.Text;
                string credits = creditsComboBox1.SelectedItem.ToString();
                string term = termTXT.Text; 
                string sqlStr = "INSERT INTO CourseTable(teacherId, courseName, title, credits, term ) VALUES ('" + User.UserId + "','" + courseName + "','" + title + "','" + credits + "','" + term + "')";

                int rowsInserted = 0;
                rowsInserted = dataBaseMgr.putData(sqlStr);

                if (rowsInserted == 1)
                {
                    MessageBox.Show(courseName + " CREATED");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void titleLBL_Click(object sender, EventArgs e)
        {

        }
    }
}
