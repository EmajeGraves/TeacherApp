﻿using System;
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
        
         CreateAnnouncements createAnnouncements;
        //ModifyAnnouncements modifyAnnouncements;

        public AnnouncementsForm()
        {
            InitializeComponent();
        }   
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null == createAnnouncements || createAnnouncements.IsDisposed)
            {
                createAnnouncements = new CreateAnnouncements();
            }
            createAnnouncements.ShowDialog();
        }
    }
}
