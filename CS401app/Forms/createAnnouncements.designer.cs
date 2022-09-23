
namespace Senior_Project
{
    partial class createAnnouncements
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
            this.label1 = new System.Windows.Forms.Label();
            this.subjectTXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // announcementLBL
            // 
            this.announcementLBL.AutoSize = true;
            this.announcementLBL.Location = new System.Drawing.Point(93, 90);
            this.announcementLBL.Name = "announcementLBL";
            this.announcementLBL.Size = new System.Drawing.Size(85, 13);
            this.announcementLBL.TabIndex = 0;
            this.announcementLBL.Text = "Announcement: ";
            this.announcementLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // announcementTXT
            // 
            this.announcementTXT.Location = new System.Drawing.Point(197, 87);
            this.announcementTXT.Multiline = true;
            this.announcementTXT.Name = "announcementTXT";
            this.announcementTXT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.announcementTXT.Size = new System.Drawing.Size(396, 114);
            this.announcementTXT.TabIndex = 1;
            // 
            // submitAnnouncementBtn
            // 
            this.submitAnnouncementBtn.Location = new System.Drawing.Point(353, 237);
            this.submitAnnouncementBtn.Name = "submitAnnouncementBtn";
            this.submitAnnouncementBtn.Size = new System.Drawing.Size(75, 23);
            this.submitAnnouncementBtn.TabIndex = 2;
            this.submitAnnouncementBtn.Text = "Submit";
            this.submitAnnouncementBtn.UseVisualStyleBackColor = true;
            this.submitAnnouncementBtn.Click += new System.EventHandler(this.submitAnnouncementBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subject:";
            // 
            // subjectTXT
            // 
            this.subjectTXT.Location = new System.Drawing.Point(197, 37);
            this.subjectTXT.Name = "subjectTXT";
            this.subjectTXT.Size = new System.Drawing.Size(245, 20);
            this.subjectTXT.TabIndex = 4;
            // 
            // createAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.subjectTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitAnnouncementBtn);
            this.Controls.Add(this.announcementTXT);
            this.Controls.Add(this.announcementLBL);
            this.Name = "createAnnouncements";
            this.Text = "CreateAnnouncements";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label announcementLBL;
        private System.Windows.Forms.TextBox announcementTXT;
        private System.Windows.Forms.Button submitAnnouncementBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subjectTXT;
    }
}

