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
            this.rosterTXT = new System.Windows.Forms.TextBox();
            this.addComboBox = new System.Windows.Forms.ComboBox();
            this.deleteComboBox = new System.Windows.Forms.ComboBox();
            this.doneBTN = new System.Windows.Forms.Button();
            this.selectComboBox1 = new System.Windows.Forms.ComboBox();
            this.SelectLBL = new System.Windows.Forms.Label();
            this.createLinkLabel = new System.Windows.Forms.LinkLabel();
            this.modifyPNL = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.refreshBTN = new System.Windows.Forms.Button();
            this.modifyPNL.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rosterTXT
            // 
            this.rosterTXT.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.rosterTXT.HideSelection = false;
            this.rosterTXT.Location = new System.Drawing.Point(58, 100);
            this.rosterTXT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rosterTXT.Multiline = true;
            this.rosterTXT.Name = "rosterTXT";
            this.rosterTXT.ReadOnly = true;
            this.rosterTXT.Size = new System.Drawing.Size(1009, 581);
            this.rosterTXT.TabIndex = 3;
            // 
            // addComboBox
            // 
            this.addComboBox.FormattingEnabled = true;
            this.addComboBox.Location = new System.Drawing.Point(94, 40);
            this.addComboBox.Name = "addComboBox";
            this.addComboBox.Size = new System.Drawing.Size(223, 28);
            this.addComboBox.TabIndex = 6;
            this.addComboBox.SelectedIndexChanged += new System.EventHandler(this.addComboBox_SelectedIndexChanged_1);
            // 
            // deleteComboBox
            // 
            this.deleteComboBox.FormattingEnabled = true;
            this.deleteComboBox.Location = new System.Drawing.Point(624, 40);
            this.deleteComboBox.Name = "deleteComboBox";
            this.deleteComboBox.Size = new System.Drawing.Size(223, 28);
            this.deleteComboBox.TabIndex = 7;
            this.deleteComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // doneBTN
            // 
            this.doneBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBTN.Location = new System.Drawing.Point(474, 105);
            this.doneBTN.Name = "doneBTN";
            this.doneBTN.Size = new System.Drawing.Size(108, 49);
            this.doneBTN.TabIndex = 12;
            this.doneBTN.Text = "Done";
            this.doneBTN.UseVisualStyleBackColor = true;
            this.doneBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // selectComboBox1
            // 
            this.selectComboBox1.FormattingEnabled = true;
            this.selectComboBox1.Location = new System.Drawing.Point(465, 46);
            this.selectComboBox1.Name = "selectComboBox1";
            this.selectComboBox1.Size = new System.Drawing.Size(248, 28);
            this.selectComboBox1.TabIndex = 13;
            this.selectComboBox1.SelectedIndexChanged += new System.EventHandler(this.selectComboBox1_SelectedIndexChanged);
            // 
            // SelectLBL
            // 
            this.SelectLBL.AutoSize = true;
            this.SelectLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectLBL.Location = new System.Drawing.Point(372, 48);
            this.SelectLBL.Name = "SelectLBL";
            this.SelectLBL.Size = new System.Drawing.Size(58, 17);
            this.SelectLBL.TabIndex = 14;
            this.SelectLBL.Text = "Select:";
            // 
            // createLinkLabel
            // 
            this.createLinkLabel.AutoSize = true;
            this.createLinkLabel.Location = new System.Drawing.Point(546, 23);
            this.createLinkLabel.Name = "createLinkLabel";
            this.createLinkLabel.Size = new System.Drawing.Size(92, 20);
            this.createLinkLabel.TabIndex = 15;
            this.createLinkLabel.TabStop = true;
            this.createLinkLabel.Text = "Create New";
            this.createLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createLinkLabel_LinkClicked);
            // 
            // modifyPNL
            // 
            this.modifyPNL.Controls.Add(this.deleteButton);
            this.modifyPNL.Controls.Add(this.addButton);
            this.modifyPNL.Controls.Add(this.doneBTN);
            this.modifyPNL.Controls.Add(this.deleteComboBox);
            this.modifyPNL.Controls.Add(this.addComboBox);
            this.modifyPNL.Location = new System.Drawing.Point(58, 709);
            this.modifyPNL.Name = "modifyPNL";
            this.modifyPNL.Size = new System.Drawing.Size(1010, 189);
            this.modifyPNL.TabIndex = 16;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(856, 37);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(112, 35);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(327, 37);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 35);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Enabled = false;
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(57, 19);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1190, 25);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // refreshBTN
            // 
            this.refreshBTN.Enabled = false;
            this.refreshBTN.Location = new System.Drawing.Point(723, 46);
            this.refreshBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refreshBTN.Name = "refreshBTN";
            this.refreshBTN.Size = new System.Drawing.Size(112, 35);
            this.refreshBTN.TabIndex = 18;
            this.refreshBTN.Text = "Refresh";
            this.refreshBTN.UseVisualStyleBackColor = true;
            this.refreshBTN.Click += new System.EventHandler(this.refreshBTN_Click);
            // 
            // RosterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1190, 911);
            this.Controls.Add(this.refreshBTN);
            this.Controls.Add(this.modifyPNL);
            this.Controls.Add(this.createLinkLabel);
            this.Controls.Add(this.SelectLBL);
            this.Controls.Add(this.selectComboBox1);
            this.Controls.Add(this.rosterTXT);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1206, 950);
            this.MinimumSize = new System.Drawing.Size(1202, 717);
            this.Name = "RosterForm";
            this.Text = "Roster";
            this.modifyPNL.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox rosterTXT;
        private System.Windows.Forms.ComboBox addComboBox;
        private System.Windows.Forms.ComboBox deleteComboBox;
        private System.Windows.Forms.Button modifyBTN;
        private System.Windows.Forms.Button doneBTN;
        private System.Windows.Forms.ComboBox selectComboBox1;
        private System.Windows.Forms.Label SelectLBL;
        private System.Windows.Forms.LinkLabel createLinkLabel;
        private System.Windows.Forms.Panel modifyPNL;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button refreshBTN;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

