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
            this.hoursBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notesBTN
            // 
            this.notesBTN.Location = new System.Drawing.Point(621, 240);
            this.notesBTN.MaximumSize = new System.Drawing.Size(235, 96);
            this.notesBTN.MinimumSize = new System.Drawing.Size(235, 96);
            this.notesBTN.Name = "notesBTN";
            this.notesBTN.Size = new System.Drawing.Size(235, 96);
            this.notesBTN.TabIndex = 0;
            this.notesBTN.Text = "Notes";
            this.notesBTN.UseVisualStyleBackColor = true;
            this.notesBTN.Click += new System.EventHandler(this.notesBTN_Click);
            // 
            // announcementsBTN
            // 
            this.announcementsBTN.Location = new System.Drawing.Point(225, 240);
            this.announcementsBTN.MaximumSize = new System.Drawing.Size(235, 96);
            this.announcementsBTN.MinimumSize = new System.Drawing.Size(235, 98);
            this.announcementsBTN.Name = "announcementsBTN";
            this.announcementsBTN.Size = new System.Drawing.Size(235, 98);
            this.announcementsBTN.TabIndex = 1;
            this.announcementsBTN.Text = "Announcements";
            this.announcementsBTN.UseVisualStyleBackColor = true;
            this.announcementsBTN.Click += new System.EventHandler(this.announcementsBTN_Click);
            // 
            // scheduleBTN
            // 
            this.scheduleBTN.Location = new System.Drawing.Point(1006, 240);
            this.scheduleBTN.MaximumSize = new System.Drawing.Size(235, 96);
            this.scheduleBTN.MinimumSize = new System.Drawing.Size(235, 96);
            this.scheduleBTN.Name = "scheduleBTN";
            this.scheduleBTN.Size = new System.Drawing.Size(235, 96);
            this.scheduleBTN.TabIndex = 2;
            this.scheduleBTN.Text = "Schedule";
            this.scheduleBTN.UseVisualStyleBackColor = true;
            this.scheduleBTN.Click += new System.EventHandler(this.scheduleBTN_Click);
            // 
            // modifyAccountBTN
            // 
            this.modifyAccountBTN.Location = new System.Drawing.Point(621, 436);
            this.modifyAccountBTN.MaximumSize = new System.Drawing.Size(235, 96);
            this.modifyAccountBTN.MinimumSize = new System.Drawing.Size(235, 96);
            this.modifyAccountBTN.Name = "modifyAccountBTN";
            this.modifyAccountBTN.Size = new System.Drawing.Size(235, 96);
            this.modifyAccountBTN.TabIndex = 3;
            this.modifyAccountBTN.Text = "Modify Account";
            this.modifyAccountBTN.UseVisualStyleBackColor = true;
            this.modifyAccountBTN.Click += new System.EventHandler(this.modifyAccountBTN_Click);
            // 
            // rosterBTN
            // 
            this.rosterBTN.Location = new System.Drawing.Point(1006, 436);
            this.rosterBTN.MaximumSize = new System.Drawing.Size(235, 96);
            this.rosterBTN.MinimumSize = new System.Drawing.Size(235, 96);
            this.rosterBTN.Name = "rosterBTN";
            this.rosterBTN.Size = new System.Drawing.Size(235, 96);
            this.rosterBTN.TabIndex = 4;
            this.rosterBTN.Text = "Roster";
            this.rosterBTN.UseVisualStyleBackColor = true;
            this.rosterBTN.Click += new System.EventHandler(this.rosterBTN_Click);
            // 
            // hoursBTN
            // 
            this.hoursBTN.Location = new System.Drawing.Point(225, 436);
            this.hoursBTN.MaximumSize = new System.Drawing.Size(235, 96);
            this.hoursBTN.MinimumSize = new System.Drawing.Size(235, 96);
            this.hoursBTN.Name = "hoursBTN";
            this.hoursBTN.Size = new System.Drawing.Size(235, 96);
            this.hoursBTN.TabIndex = 5;
            this.hoursBTN.Text = "Hours";
            this.hoursBTN.UseVisualStyleBackColor = true;
            this.hoursBTN.Click += new System.EventHandler(this.hoursBTN_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 896);
            this.Controls.Add(this.hoursBTN);
            this.Controls.Add(this.rosterBTN);
            this.Controls.Add(this.modifyAccountBTN);
            this.Controls.Add(this.scheduleBTN);
            this.Controls.Add(this.announcementsBTN);
            this.Controls.Add(this.notesBTN);
            this.MaximumSize = new System.Drawing.Size(1580, 952);
            this.MinimumSize = new System.Drawing.Size(1580, 952);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button notesBTN;
        private System.Windows.Forms.Button announcementsBTN;
        private System.Windows.Forms.Button scheduleBTN;
        private System.Windows.Forms.Button modifyAccountBTN;
        private System.Windows.Forms.Button rosterBTN;
        private System.Windows.Forms.Button hoursBTN;
    }
}