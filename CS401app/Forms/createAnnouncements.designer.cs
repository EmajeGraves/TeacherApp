
namespace TeacherApp
{
    partial class CreateAnnouncements
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.announcementLBL = new System.Windows.Forms.Label();
            this.announcementTXT = new System.Windows.Forms.TextBox();
            this.submitAnnouncementBtn = new System.Windows.Forms.Button();
            this.SelectLBL = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.subjectLBL = new System.Windows.Forms.Label();
            this.subjectTXT = new System.Windows.Forms.TextBox();
            this.selectCourseIdLBL = new System.Windows.Forms.Label();
            this.selectComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // announcementLBL
            // 
            this.announcementLBL.AutoSize = true;
            this.announcementLBL.Location = new System.Drawing.Point(67, 138);
            this.announcementLBL.Name = "announcementLBL";
            this.announcementLBL.Size = new System.Drawing.Size(85, 13);
            this.announcementLBL.TabIndex = 0;
            this.announcementLBL.Text = "Announcement: ";
            // 
            // announcementTXT
            // 
            this.announcementTXT.Location = new System.Drawing.Point(158, 138);
            this.announcementTXT.Multiline = true;
            this.announcementTXT.Name = "announcementTXT";
            this.announcementTXT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.announcementTXT.Size = new System.Drawing.Size(396, 114);
            this.announcementTXT.TabIndex = 1;
            // 
            // submitAnnouncementBtn
            // 
            this.submitAnnouncementBtn.Location = new System.Drawing.Point(255, 270);
            this.submitAnnouncementBtn.Name = "submitAnnouncementBtn";
            this.submitAnnouncementBtn.Size = new System.Drawing.Size(75, 23);
            this.submitAnnouncementBtn.TabIndex = 2;
            this.submitAnnouncementBtn.Text = "Send";
            this.submitAnnouncementBtn.UseVisualStyleBackColor = true;
            this.submitAnnouncementBtn.Click += new System.EventHandler(this.submitAnnouncementBtn_Click);
            // 
            // SelectLBL
            // 
            this.SelectLBL.AutoSize = true;
            this.SelectLBL.Location = new System.Drawing.Point(119, 102);
            this.SelectLBL.Name = "SelectLBL";
            this.SelectLBL.Size = new System.Drawing.Size(33, 13);
            this.SelectLBL.TabIndex = 3;
            this.SelectLBL.Text = "Date:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(366, 270);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(158, 102);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 6;
            // 
            // subjectLBL
            // 
            this.subjectLBL.AutoSize = true;
            this.subjectLBL.Location = new System.Drawing.Point(106, 75);
            this.subjectLBL.Name = "subjectLBL";
            this.subjectLBL.Size = new System.Drawing.Size(46, 13);
            this.subjectLBL.TabIndex = 7;
            this.subjectLBL.Text = "Subject:";
            // 
            // subjectTXT
            // 
            this.subjectTXT.Location = new System.Drawing.Point(158, 72);
            this.subjectTXT.Name = "subjectTXT";
            this.subjectTXT.Size = new System.Drawing.Size(125, 20);
            this.subjectTXT.TabIndex = 8;
            // 
            // selectCourseIdLBL
            // 
            this.selectCourseIdLBL.AutoSize = true;
            this.selectCourseIdLBL.Location = new System.Drawing.Point(62, 37);
            this.selectCourseIdLBL.Name = "selectCourseIdLBL";
            this.selectCourseIdLBL.Size = new System.Drawing.Size(90, 13);
            this.selectCourseIdLBL.TabIndex = 9;
            this.selectCourseIdLBL.Text = "Select Course ID:";
            // 
            // selectComboBox
            // 
            this.selectComboBox.FormattingEnabled = true;
            this.selectComboBox.Location = new System.Drawing.Point(158, 34);
            this.selectComboBox.Name = "selectComboBox";
            this.selectComboBox.Size = new System.Drawing.Size(75, 21);
            this.selectComboBox.TabIndex = 10;
            // 
            // CreateAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 334);
            this.Controls.Add(this.selectComboBox);
            this.Controls.Add(this.selectCourseIdLBL);
            this.Controls.Add(this.subjectTXT);
            this.Controls.Add(this.subjectLBL);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.SelectLBL);
            this.Controls.Add(this.submitAnnouncementBtn);
            this.Controls.Add(this.announcementTXT);
            this.Controls.Add(this.announcementLBL);
            this.MaximumSize = new System.Drawing.Size(704, 373);
            this.MinimumSize = new System.Drawing.Size(704, 373);
            this.Name = "CreateAnnouncements";
            this.Text = "CreateAnnouncements";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label announcementLBL;
        private System.Windows.Forms.TextBox announcementTXT;
        private System.Windows.Forms.Button submitAnnouncementBtn;
        private System.Windows.Forms.Label SelectLBL;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label subjectLBL;
        private System.Windows.Forms.TextBox subjectTXT;
        private System.Windows.Forms.Label selectCourseIdLBL;
        private System.Windows.Forms.ComboBox selectComboBox;
    }
}

