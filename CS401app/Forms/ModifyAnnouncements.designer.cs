
namespace TeacherApp
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
            this.submitAnnouncementBtn = new System.Windows.Forms.Button();
            this.AnnouncementTxtBox = new System.Windows.Forms.TextBox();
            this.announcementLBL = new System.Windows.Forms.Label();
            this.selectLBL = new System.Windows.Forms.Label();
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
            this.AnnouncementsList.Location = new System.Drawing.Point(231, 52);
            this.AnnouncementsList.Name = "AnnouncementsList";
            this.AnnouncementsList.Size = new System.Drawing.Size(212, 21);
            this.AnnouncementsList.TabIndex = 10;
            // 
            // submitAnnouncementBtn
            // 
            this.submitAnnouncementBtn.Location = new System.Drawing.Point(342, 332);
            this.submitAnnouncementBtn.Name = "submitAnnouncementBtn";
            this.submitAnnouncementBtn.Size = new System.Drawing.Size(75, 23);
            this.submitAnnouncementBtn.TabIndex = 7;
            this.submitAnnouncementBtn.Text = "Submit";
            this.submitAnnouncementBtn.UseVisualStyleBackColor = true;
            this.submitAnnouncementBtn.Click += new System.EventHandler(this.submitAnnouncementBtn_Click);
            // 
            // AnnouncementTxtBox
            // 
            this.AnnouncementTxtBox.Location = new System.Drawing.Point(123, 107);
            this.AnnouncementTxtBox.Multiline = true;
            this.AnnouncementTxtBox.Name = "AnnouncementTxtBox";
            this.AnnouncementTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AnnouncementTxtBox.Size = new System.Drawing.Size(454, 179);
            this.AnnouncementTxtBox.TabIndex = 6;
            // 
            // announcementLBL
            // 
            this.announcementLBL.AutoSize = true;
            this.announcementLBL.Location = new System.Drawing.Point(32, 110);
            this.announcementLBL.Name = "announcementLBL";
            this.announcementLBL.Size = new System.Drawing.Size(85, 13);
            this.announcementLBL.TabIndex = 5;
            this.announcementLBL.Text = "Announcement: ";
            // 
            // selectLBL
            // 
            this.selectLBL.AutoSize = true;
            this.selectLBL.Location = new System.Drawing.Point(182, 52);
            this.selectLBL.Name = "selectLBL";
            this.selectLBL.Size = new System.Drawing.Size(43, 13);
            this.selectLBL.TabIndex = 13;
            this.selectLBL.Text = "Select: ";
            // 
            // ModifyAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 334);
            this.Controls.Add(this.submitAnnouncementBtn);
            this.Controls.Add(this.selectLBL);
            this.Controls.Add(this.AnnouncementTxtBox);
            this.Controls.Add(this.announcementLBL);
            this.Controls.Add(this.AnnouncementsList);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(704, 373);
            this.MinimumSize = new System.Drawing.Size(704, 373);
            this.Name = "ModifyAnnouncements";
            this.Text = "ModifyAnnouncements";
            this.Load += new System.EventHandler(this.ModifyAnnouncements_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AnnouncementsList;
        private System.Windows.Forms.Button submitAnnouncementBtn;
        private System.Windows.Forms.TextBox AnnouncementTxtBox;
        private System.Windows.Forms.Label announcementLBL;
        private System.Windows.Forms.Label selectLBL;
    }
}