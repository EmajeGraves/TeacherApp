
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // announcementLBL
            // 
            this.announcementLBL.AutoSize = true;
            this.announcementLBL.Location = new System.Drawing.Point(76, 122);
            this.announcementLBL.Name = "announcementLBL";
            this.announcementLBL.Size = new System.Drawing.Size(85, 13);
            this.announcementLBL.TabIndex = 0;
            this.announcementLBL.Text = "Announcement: ";
            this.announcementLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // announcementTXT
            // 
            this.announcementTXT.Location = new System.Drawing.Point(167, 122);
            this.announcementTXT.Multiline = true;
            this.announcementTXT.Name = "announcementTXT";
            this.announcementTXT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.announcementTXT.Size = new System.Drawing.Size(396, 114);
            this.announcementTXT.TabIndex = 1;
            // 
            // submitAnnouncementBtn
            // 
            this.submitAnnouncementBtn.Location = new System.Drawing.Point(270, 261);
            this.submitAnnouncementBtn.Name = "submitAnnouncementBtn";
            this.submitAnnouncementBtn.Size = new System.Drawing.Size(75, 23);
            this.submitAnnouncementBtn.TabIndex = 2;
            this.submitAnnouncementBtn.Text = "Submit";
            this.submitAnnouncementBtn.UseVisualStyleBackColor = true;
            this.submitAnnouncementBtn.Click += new System.EventHandler(this.submitAnnouncementBtn_Click);
            // 
            // SelectLBL
            // 
            this.SelectLBL.AutoSize = true;
            this.SelectLBL.Location = new System.Drawing.Point(121, 37);
            this.SelectLBL.Name = "SelectLBL";
            this.SelectLBL.Size = new System.Drawing.Size(40, 13);
            this.SelectLBL.TabIndex = 3;
            this.SelectLBL.Text = "Select:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(381, 261);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // CreateAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 334);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.SelectLBL);
            this.Controls.Add(this.submitAnnouncementBtn);
            this.Controls.Add(this.announcementTXT);
            this.Controls.Add(this.announcementLBL);
            this.MaximumSize = new System.Drawing.Size(704, 373);
            this.MinimumSize = new System.Drawing.Size(704, 373);
            this.Name = "CreateAnnouncements";
            this.Text = "CreateAnnouncements";
            this.Load += new System.EventHandler(this.createAnnouncements_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label announcementLBL;
        private System.Windows.Forms.TextBox announcementTXT;
        private System.Windows.Forms.Button submitAnnouncementBtn;
        private System.Windows.Forms.Label SelectLBL;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

