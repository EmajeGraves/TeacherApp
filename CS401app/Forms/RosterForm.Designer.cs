namespace TeacherApp
{
    partial class RosterForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rosterTXT = new System.Windows.Forms.TextBox();
            this.viewRosterBTN = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1190, 35);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // rosterTXT
            // 
            this.rosterTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rosterTXT.HideSelection = false;
            this.rosterTXT.Location = new System.Drawing.Point(76, 65);
            this.rosterTXT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rosterTXT.Multiline = true;
            this.rosterTXT.Name = "rosterTXT";
            this.rosterTXT.ReadOnly = true;
            this.rosterTXT.Size = new System.Drawing.Size(1009, 476);
            this.rosterTXT.TabIndex = 3;
            // 
            // viewRosterBTN
            // 
            this.viewRosterBTN.Location = new System.Drawing.Point(215, 587);
            this.viewRosterBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewRosterBTN.Name = "viewRosterBTN";
            this.viewRosterBTN.Size = new System.Drawing.Size(190, 35);
            this.viewRosterBTN.TabIndex = 4;
            this.viewRosterBTN.Text = "View Roster";
            this.viewRosterBTN.UseVisualStyleBackColor = true;
            this.viewRosterBTN.Click += new System.EventHandler(this.viewRosterBTN_Click);
            // 
            // RosterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1190, 688);
            this.Controls.Add(this.viewRosterBTN);
            this.Controls.Add(this.rosterTXT);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1202, 718);
            this.Name = "RosterForm";
            this.Text = "Accounts Table";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TextBox rosterTXT;
        private System.Windows.Forms.Button viewRosterBTN;
    }
}

