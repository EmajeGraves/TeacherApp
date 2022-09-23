
namespace Senior_Project
{
    partial class ModifyAnnouncements
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
            this.label1 = new System.Windows.Forms.Label();
            this.AnnouncementsList = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubjectTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submitAnnouncementBtn = new System.Windows.Forms.Button();
            this.AnnouncementTxtBox = new System.Windows.Forms.TextBox();
            this.announcementLBL = new System.Windows.Forms.Label();
            this.EditLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 12;
            // 
            // AnnouncementsList
            // 
            this.AnnouncementsList.FormattingEnabled = true;
            this.AnnouncementsList.Location = new System.Drawing.Point(252, 49);
            this.AnnouncementsList.Name = "AnnouncementsList";
            this.AnnouncementsList.Size = new System.Drawing.Size(121, 21);
            this.AnnouncementsList.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SubjectTxtBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.submitAnnouncementBtn);
            this.panel1.Controls.Add(this.AnnouncementTxtBox);
            this.panel1.Controls.Add(this.announcementLBL);
            this.panel1.Location = new System.Drawing.Point(55, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 265);
            this.panel1.TabIndex = 11;
            // 
            // SubjectTxtBox
            // 
            this.SubjectTxtBox.Location = new System.Drawing.Point(123, 25);
            this.SubjectTxtBox.Name = "SubjectTxtBox";
            this.SubjectTxtBox.Size = new System.Drawing.Size(245, 20);
            this.SubjectTxtBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Subject:";
            // 
            // submitAnnouncementBtn
            // 
            this.submitAnnouncementBtn.Location = new System.Drawing.Point(279, 225);
            this.submitAnnouncementBtn.Name = "submitAnnouncementBtn";
            this.submitAnnouncementBtn.Size = new System.Drawing.Size(75, 23);
            this.submitAnnouncementBtn.TabIndex = 7;
            this.submitAnnouncementBtn.Text = "Submit";
            this.submitAnnouncementBtn.UseVisualStyleBackColor = true;
            this.submitAnnouncementBtn.Click += new System.EventHandler(this.submitAnnouncementBtn_Click);
            // 
            // AnnouncementTxtBox
            // 
            this.AnnouncementTxtBox.Location = new System.Drawing.Point(123, 75);
            this.AnnouncementTxtBox.Multiline = true;
            this.AnnouncementTxtBox.Name = "AnnouncementTxtBox";
            this.AnnouncementTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AnnouncementTxtBox.Size = new System.Drawing.Size(396, 114);
            this.AnnouncementTxtBox.TabIndex = 6;
            // 
            // announcementLBL
            // 
            this.announcementLBL.AutoSize = true;
            this.announcementLBL.Location = new System.Drawing.Point(19, 78);
            this.announcementLBL.Name = "announcementLBL";
            this.announcementLBL.Size = new System.Drawing.Size(85, 13);
            this.announcementLBL.TabIndex = 5;
            this.announcementLBL.Text = "Announcement: ";
            // 
            // EditLbl
            // 
            this.EditLbl.AutoSize = true;
            this.EditLbl.Location = new System.Drawing.Point(67, 52);
            this.EditLbl.Name = "EditLbl";
            this.EditLbl.Size = new System.Drawing.Size(179, 13);
            this.EditLbl.TabIndex = 13;
            this.EditLbl.Text = "Select an Announcement to Modify: ";
            // 
            // ModifyAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AnnouncementsList);
            this.Controls.Add(this.label1);
            this.Name = "ModifyAnnouncements";
            this.Text = "ModifyAnnouncements";
            this.Load += new System.EventHandler(this.ModifyAnnouncements_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AnnouncementsList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SubjectTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitAnnouncementBtn;
        private System.Windows.Forms.TextBox AnnouncementTxtBox;
        private System.Windows.Forms.Label announcementLBL;
        private System.Windows.Forms.Label EditLbl;
    }
}