
namespace TeacherApp
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
            this.announcementTxt = new System.Windows.Forms.TextBox();
            this.announcementLBL = new System.Windows.Forms.Label();
            this.Savebtn = new System.Windows.Forms.Button();
            this.subjectLBL = new System.Windows.Forms.Label();
            this.subjectTXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // announcementTxt
            // 
            this.announcementTxt.Location = new System.Drawing.Point(212, 133);
            this.announcementTxt.Multiline = true;
            this.announcementTxt.Name = "announcementTxt";
            this.announcementTxt.Size = new System.Drawing.Size(365, 80);
            this.announcementTxt.TabIndex = 0;
            // 
            // announcementLBL
            // 
            this.announcementLBL.AutoSize = true;
            this.announcementLBL.Location = new System.Drawing.Point(104, 136);
            this.announcementLBL.Name = "announcementLBL";
            this.announcementLBL.Size = new System.Drawing.Size(82, 13);
            this.announcementLBL.TabIndex = 1;
            this.announcementLBL.Text = "Announcement:";
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(251, 290);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(107, 30);
            this.Savebtn.TabIndex = 2;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            // 
            // subjectLBL
            // 
            this.subjectLBL.AutoSize = true;
            this.subjectLBL.Location = new System.Drawing.Point(140, 99);
            this.subjectLBL.Name = "subjectLBL";
            this.subjectLBL.Size = new System.Drawing.Size(46, 13);
            this.subjectLBL.TabIndex = 3;
            this.subjectLBL.Text = "Subject:";
            // 
            // subjectTXT
            // 
            this.subjectTXT.Location = new System.Drawing.Point(212, 96);
            this.subjectTXT.Name = "subjectTXT";
            this.subjectTXT.Size = new System.Drawing.Size(125, 20);
            this.subjectTXT.TabIndex = 4;
            // 
            // createAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 353);
            this.Controls.Add(this.subjectTXT);
            this.Controls.Add(this.subjectLBL);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.announcementLBL);
            this.Controls.Add(this.announcementTxt);
            this.Name = "createAnnouncements";
            this.Text = "CreateAnnouncements";
            this.Load += new System.EventHandler(this.createAnnouncements_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox announcementTxt;
        private System.Windows.Forms.Label announcementLBL;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Label subjectLBL;
        private System.Windows.Forms.TextBox subjectTXT;
    }
}

