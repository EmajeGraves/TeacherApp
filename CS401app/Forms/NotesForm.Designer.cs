namespace TeacherApp
{
    partial class NotesForm
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
            this.NotesTxtBox = new System.Windows.Forms.TextBox();
            this.notesComboBox = new System.Windows.Forms.ComboBox();
            this.SelectLBL = new System.Windows.Forms.Label();
            this.createNoteLinkLabel = new System.Windows.Forms.LinkLabel();
            this.viewBTN = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotesTxtBox
            // 
            this.NotesTxtBox.Location = new System.Drawing.Point(79, 78);
            this.NotesTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.NotesTxtBox.Multiline = true;
            this.NotesTxtBox.Name = "NotesTxtBox";
            this.NotesTxtBox.ReadOnly = true;
            this.NotesTxtBox.Size = new System.Drawing.Size(891, 597);
            this.NotesTxtBox.TabIndex = 1;
            // 
            // notesComboBox
            // 
            this.notesComboBox.Enabled = false;
            this.notesComboBox.FormattingEnabled = true;
            this.notesComboBox.Location = new System.Drawing.Point(385, 39);
            this.notesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.notesComboBox.Name = "notesComboBox";
            this.notesComboBox.Size = new System.Drawing.Size(179, 21);
            this.notesComboBox.TabIndex = 2;
            this.notesComboBox.SelectedIndexChanged += new System.EventHandler(this.notesComboBox_SelectedIndexChanged);
            // 
            // SelectLBL
            // 
            this.SelectLBL.AutoSize = true;
            this.SelectLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectLBL.Location = new System.Drawing.Point(326, 39);
            this.SelectLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectLBL.Name = "SelectLBL";
            this.SelectLBL.Size = new System.Drawing.Size(58, 20);
            this.SelectLBL.TabIndex = 3;
            this.SelectLBL.Text = "Select:";
            // 
            // createNoteLinkLabel
            // 
            this.createNoteLinkLabel.AutoSize = true;
            this.createNoteLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNoteLinkLabel.Location = new System.Drawing.Point(441, 6);
            this.createNoteLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.createNoteLinkLabel.Name = "createNoteLinkLabel";
            this.createNoteLinkLabel.Size = new System.Drawing.Size(81, 17);
            this.createNoteLinkLabel.TabIndex = 6;
            this.createNoteLinkLabel.TabStop = true;
            this.createNoteLinkLabel.Text = "Create New";
            this.createNoteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // viewBTN
            // 
            this.viewBTN.Location = new System.Drawing.Point(585, 38);
            this.viewBTN.Margin = new System.Windows.Forms.Padding(2);
            this.viewBTN.Name = "viewBTN";
            this.viewBTN.Size = new System.Drawing.Size(50, 19);
            this.viewBTN.TabIndex = 7;
            this.viewBTN.Text = "View";
            this.viewBTN.UseVisualStyleBackColor = true;
            this.viewBTN.Click += new System.EventHandler(this.viewBTN_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1041, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Enabled = false;
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Enabled = false;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 746);
            this.Controls.Add(this.viewBTN);
            this.Controls.Add(this.createNoteLinkLabel);
            this.Controls.Add(this.SelectLBL);
            this.Controls.Add(this.notesComboBox);
            this.Controls.Add(this.NotesTxtBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1057, 785);
            this.Name = "NotesForm";
            this.Text = "Notes ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NotesTxtBox;
        private System.Windows.Forms.ComboBox notesComboBox;
        private System.Windows.Forms.Label SelectLBL;
        private System.Windows.Forms.LinkLabel createNoteLinkLabel;
        private System.Windows.Forms.Button viewBTN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}