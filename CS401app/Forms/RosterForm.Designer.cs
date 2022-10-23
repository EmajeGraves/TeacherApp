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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.viewBTN = new System.Windows.Forms.Button();
            this.modifyBTN = new System.Windows.Forms.Button();
            this.addLBL = new System.Windows.Forms.Label();
            this.deleteLBL = new System.Windows.Forms.Label();
            this.saveBTN = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(1190, 33);
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
            this.rosterTXT.Enabled = false;
            this.rosterTXT.HideSelection = false;
            this.rosterTXT.Location = new System.Drawing.Point(69, 89);
            this.rosterTXT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rosterTXT.Multiline = true;
            this.rosterTXT.Name = "rosterTXT";
            this.rosterTXT.ReadOnly = true;
            this.rosterTXT.Size = new System.Drawing.Size(1009, 528);
            this.rosterTXT.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(297, 666);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(738, 666);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // viewBTN
            // 
            this.viewBTN.Location = new System.Drawing.Point(453, 36);
            this.viewBTN.Name = "viewBTN";
            this.viewBTN.Size = new System.Drawing.Size(75, 33);
            this.viewBTN.TabIndex = 8;
            this.viewBTN.Text = "View";
            this.viewBTN.UseVisualStyleBackColor = true;
            this.viewBTN.Click += new System.EventHandler(this.viewBTN_Click);
            // 
            // modifyBTN
            // 
            this.modifyBTN.Location = new System.Drawing.Point(587, 36);
            this.modifyBTN.Name = "modifyBTN";
            this.modifyBTN.Size = new System.Drawing.Size(75, 33);
            this.modifyBTN.TabIndex = 9;
            this.modifyBTN.Text = "Modify";
            this.modifyBTN.UseVisualStyleBackColor = true;
            this.modifyBTN.Click += new System.EventHandler(this.modifyBTN_Click);
            // 
            // addLBL
            // 
            this.addLBL.AutoSize = true;
            this.addLBL.Location = new System.Drawing.Point(253, 669);
            this.addLBL.Name = "addLBL";
            this.addLBL.Size = new System.Drawing.Size(38, 20);
            this.addLBL.TabIndex = 10;
            this.addLBL.Text = "Add";
            this.addLBL.Visible = false;
            // 
            // deleteLBL
            // 
            this.deleteLBL.AutoSize = true;
            this.deleteLBL.Location = new System.Drawing.Point(676, 669);
            this.deleteLBL.Name = "deleteLBL";
            this.deleteLBL.Size = new System.Drawing.Size(56, 20);
            this.deleteLBL.TabIndex = 11;
            this.deleteLBL.Text = "Delete";
            this.deleteLBL.Visible = false;
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(494, 702);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(108, 34);
            this.saveBTN.TabIndex = 12;
            this.saveBTN.Text = "Save";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Visible = false;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // RosterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1190, 832);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.deleteLBL);
            this.Controls.Add(this.addLBL);
            this.Controls.Add(this.modifyBTN);
            this.Controls.Add(this.viewBTN);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rosterTXT);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1202, 718);
            this.Name = "RosterForm";
            this.Text = "Roster";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TextBox rosterTXT;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button viewBTN;
        private System.Windows.Forms.Button modifyBTN;
        private System.Windows.Forms.Label addLBL;
        private System.Windows.Forms.Label deleteLBL;
        private System.Windows.Forms.Button saveBTN;
    }
}

