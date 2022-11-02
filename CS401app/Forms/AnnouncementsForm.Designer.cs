
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
            this.components = new System.ComponentModel.Container();
            this.AnnouncementsTXT = new System.Windows.Forms.TextBox();
            this.subjectcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editbtn = new System.Windows.Forms.Button();
            this.modifyPNL = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.createNewLBL = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyPNL.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnnouncementsTXT
            // 
            this.AnnouncementsTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AnnouncementsTXT.HideSelection = false;
            this.AnnouncementsTXT.Location = new System.Drawing.Point(43, 86);
            this.AnnouncementsTXT.Multiline = true;
            this.AnnouncementsTXT.Name = "AnnouncementsTXT";
            this.AnnouncementsTXT.ReadOnly = true;
            this.AnnouncementsTXT.Size = new System.Drawing.Size(674, 327);
            this.AnnouncementsTXT.TabIndex = 5;
            this.AnnouncementsTXT.TextChanged += new System.EventHandler(this.AnnouncementsTXT_TextChanged);
            // 
            // subjectcomboBox
            // 
            this.subjectcomboBox.FormattingEnabled = true;
            this.subjectcomboBox.Location = new System.Drawing.Point(287, 48);
            this.subjectcomboBox.Name = "subjectcomboBox";
            this.subjectcomboBox.Size = new System.Drawing.Size(155, 21);
            this.subjectcomboBox.TabIndex = 9;
            this.subjectcomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(32, 57);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(118, 23);
            this.editbtn.TabIndex = 11;
            this.editbtn.Text = "Edit";
            this.editbtn.UseVisualStyleBackColor = true;
            // 
            // modifyPNL
            // 
            this.modifyPNL.Controls.Add(this.saveBtn);
            this.modifyPNL.Controls.Add(this.editbtn);
            this.modifyPNL.Location = new System.Drawing.Point(199, 419);
            this.modifyPNL.Name = "modifyPNL";
            this.modifyPNL.Size = new System.Drawing.Size(381, 101);
            this.modifyPNL.TabIndex = 12;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(208, 57);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(102, 23);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(448, 51);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 13;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // createNewLBL
            // 
            this.createNewLBL.AutoSize = true;
            this.createNewLBL.Location = new System.Drawing.Point(330, 22);
            this.createNewLBL.Name = "createNewLBL";
            this.createNewLBL.Size = new System.Drawing.Size(63, 13);
            this.createNewLBL.TabIndex = 14;
            this.createNewLBL.TabStop = true;
            this.createNewLBL.Text = "Create New";
            this.createNewLBL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewLBL_LinkClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // AnnouncementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.createNewLBL);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.modifyPNL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subjectcomboBox);
            this.Controls.Add(this.AnnouncementsTXT);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnnouncementsForm";
            this.Text = "Announcements";
            this.modifyPNL.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox AnnouncementsTXT;
        private System.Windows.Forms.ComboBox subjectcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Panel modifyPNL;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.LinkLabel createNewLBL;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
    }
}