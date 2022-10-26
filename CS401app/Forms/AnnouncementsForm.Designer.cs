
namespace TeacherApp
{
    partial class AnnouncementsForm
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
            this.createAnnBTN = new System.Windows.Forms.Button();
            this.AnnouncementsTXT = new System.Windows.Forms.TextBox();
            this.homebtn = new System.Windows.Forms.Button();
            this.modifyAnnouncement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createAnnBTN
            // 
            this.createAnnBTN.Location = new System.Drawing.Point(468, 401);
            this.createAnnBTN.Name = "createAnnBTN";
            this.createAnnBTN.Size = new System.Drawing.Size(155, 23);
            this.createAnnBTN.TabIndex = 6;
            this.createAnnBTN.Text = "Create Announcement";
            this.createAnnBTN.UseVisualStyleBackColor = true;
            this.createAnnBTN.Click += new System.EventHandler(this.createAnnBTN_Click);
            // 
            // AnnouncementsTXT
            // 
            this.AnnouncementsTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AnnouncementsTXT.HideSelection = false;
            this.AnnouncementsTXT.Location = new System.Drawing.Point(35, 36);
            this.AnnouncementsTXT.Multiline = true;
            this.AnnouncementsTXT.Name = "AnnouncementsTXT";
            this.AnnouncementsTXT.ReadOnly = true;
            this.AnnouncementsTXT.Size = new System.Drawing.Size(674, 311);
            this.AnnouncementsTXT.TabIndex = 5;
            this.AnnouncementsTXT.TextChanged += new System.EventHandler(this.AnnouncementsTXT_TextChanged);
            // 
            // homebtn
            // 
            this.homebtn.Location = new System.Drawing.Point(287, 366);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(127, 23);
            this.homebtn.TabIndex = 7;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // modifyAnnouncement
            // 
            this.modifyAnnouncement.Location = new System.Drawing.Point(633, 401);
            this.modifyAnnouncement.Name = "modifyAnnouncement";
            this.modifyAnnouncement.Size = new System.Drawing.Size(83, 23);
            this.modifyAnnouncement.TabIndex = 8;
            this.modifyAnnouncement.Text = "Modify";
            this.modifyAnnouncement.UseVisualStyleBackColor = true;
            this.modifyAnnouncement.Click += new System.EventHandler(this.modifyAnnouncement_Click);
            // 
            // AnnouncementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modifyAnnouncement);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.createAnnBTN);
            this.Controls.Add(this.AnnouncementsTXT);
            this.Name = "AnnouncementsForm";
            this.Text = "Announcements";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createAnnBTN;
        private System.Windows.Forms.TextBox AnnouncementsTXT;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button modifyAnnouncement;
    }
}