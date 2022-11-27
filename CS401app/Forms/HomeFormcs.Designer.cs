namespace TeacherApp
{
    partial class HomeForm
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
            this.notesBTN = new System.Windows.Forms.Button();
            this.announcementsBTN = new System.Windows.Forms.Button();
            this.scheduleBTN = new System.Windows.Forms.Button();
            this.modifyAccountBTN = new System.Windows.Forms.Button();
            this.rosterBTN = new System.Windows.Forms.Button();
            this.LookUpBTN = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // notesBTN
            // 
            this.notesBTN.Location = new System.Drawing.Point(414, 156);
            this.notesBTN.Margin = new System.Windows.Forms.Padding(2);
            this.notesBTN.MaximumSize = new System.Drawing.Size(157, 62);
            this.notesBTN.MinimumSize = new System.Drawing.Size(157, 62);
            this.notesBTN.Name = "notesBTN";
            this.notesBTN.Size = new System.Drawing.Size(157, 62);
            this.notesBTN.TabIndex = 0;
            this.notesBTN.Text = "Notes";
            this.notesBTN.UseVisualStyleBackColor = true;
            this.notesBTN.Click += new System.EventHandler(this.notesBTN_Click);
            // 
            // announcementsBTN
            // 
            this.announcementsBTN.Location = new System.Drawing.Point(150, 156);
            this.announcementsBTN.Margin = new System.Windows.Forms.Padding(2);
            this.announcementsBTN.MaximumSize = new System.Drawing.Size(157, 62);
            this.announcementsBTN.MinimumSize = new System.Drawing.Size(157, 64);
            this.announcementsBTN.Name = "announcementsBTN";
            this.announcementsBTN.Size = new System.Drawing.Size(157, 64);
            this.announcementsBTN.TabIndex = 1;
            this.announcementsBTN.Text = "Announcements";
            this.announcementsBTN.UseVisualStyleBackColor = true;
            this.announcementsBTN.Click += new System.EventHandler(this.announcementsBTN_Click);
            // 
            // scheduleBTN
            // 
            this.scheduleBTN.Location = new System.Drawing.Point(671, 156);
            this.scheduleBTN.Margin = new System.Windows.Forms.Padding(2);
            this.scheduleBTN.MaximumSize = new System.Drawing.Size(157, 62);
            this.scheduleBTN.MinimumSize = new System.Drawing.Size(157, 62);
            this.scheduleBTN.Name = "scheduleBTN";
            this.scheduleBTN.Size = new System.Drawing.Size(157, 62);
            this.scheduleBTN.TabIndex = 2;
            this.scheduleBTN.Text = "Schedule";
            this.scheduleBTN.UseVisualStyleBackColor = true;
            this.scheduleBTN.Click += new System.EventHandler(this.scheduleBTN_Click);
            // 
            // modifyAccountBTN
            // 
            this.modifyAccountBTN.Location = new System.Drawing.Point(414, 283);
            this.modifyAccountBTN.Margin = new System.Windows.Forms.Padding(2);
            this.modifyAccountBTN.MaximumSize = new System.Drawing.Size(157, 62);
            this.modifyAccountBTN.MinimumSize = new System.Drawing.Size(157, 62);
            this.modifyAccountBTN.Name = "modifyAccountBTN";
            this.modifyAccountBTN.Size = new System.Drawing.Size(157, 62);
            this.modifyAccountBTN.TabIndex = 3;
            this.modifyAccountBTN.Text = "Modify Account";
            this.modifyAccountBTN.UseVisualStyleBackColor = true;
            this.modifyAccountBTN.Click += new System.EventHandler(this.modifyAccountBTN_Click);
            // 
            // rosterBTN
            // 
            this.rosterBTN.Location = new System.Drawing.Point(671, 283);
            this.rosterBTN.Margin = new System.Windows.Forms.Padding(2);
            this.rosterBTN.MaximumSize = new System.Drawing.Size(157, 62);
            this.rosterBTN.MinimumSize = new System.Drawing.Size(157, 62);
            this.rosterBTN.Name = "rosterBTN";
            this.rosterBTN.Size = new System.Drawing.Size(157, 62);
            this.rosterBTN.TabIndex = 4;
            this.rosterBTN.Text = "Roster";
            this.rosterBTN.UseVisualStyleBackColor = true;
            this.rosterBTN.Click += new System.EventHandler(this.rosterBTN_Click);
            // 
            // LookUpBTN
            // 
            this.LookUpBTN.Location = new System.Drawing.Point(150, 283);
            this.LookUpBTN.Margin = new System.Windows.Forms.Padding(2);
            this.LookUpBTN.MaximumSize = new System.Drawing.Size(157, 62);
            this.LookUpBTN.MinimumSize = new System.Drawing.Size(157, 62);
            this.LookUpBTN.Name = "LookUpBTN";
            this.LookUpBTN.Size = new System.Drawing.Size(157, 62);
            this.LookUpBTN.TabIndex = 5;
            this.LookUpBTN.Text = "Look up Classes";
            this.LookUpBTN.UseVisualStyleBackColor = true;
            this.LookUpBTN.Click += new System.EventHandler(this.hoursBTN_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1043, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 593);
            this.Controls.Add(this.LookUpBTN);
            this.Controls.Add(this.rosterBTN);
            this.Controls.Add(this.modifyAccountBTN);
            this.Controls.Add(this.scheduleBTN);
            this.Controls.Add(this.announcementsBTN);
            this.Controls.Add(this.notesBTN);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1059, 632);
            this.MinimumSize = new System.Drawing.Size(1059, 632);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button notesBTN;
        private System.Windows.Forms.Button announcementsBTN;
        private System.Windows.Forms.Button scheduleBTN;
        private System.Windows.Forms.Button modifyAccountBTN;
        private System.Windows.Forms.Button rosterBTN;
        private System.Windows.Forms.Button LookUpBTN;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}