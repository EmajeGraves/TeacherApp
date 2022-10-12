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
            this.ModifyNoteBTN = new System.Windows.Forms.Button();
            this.updateNoteBTN = new System.Windows.Forms.Button();
            this.createNoteLinkLabel = new System.Windows.Forms.LinkLabel();
            this.viewBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NotesTxtBox
            // 
            this.NotesTxtBox.Location = new System.Drawing.Point(119, 120);
            this.NotesTxtBox.Multiline = true;
            this.NotesTxtBox.Name = "NotesTxtBox";
            this.NotesTxtBox.ReadOnly = true;
            this.NotesTxtBox.Size = new System.Drawing.Size(1335, 776);
            this.NotesTxtBox.TabIndex = 1;
            // 
            // notesComboBox
            // 
            this.notesComboBox.Enabled = false;
            this.notesComboBox.FormattingEnabled = true;
            this.notesComboBox.Location = new System.Drawing.Point(578, 60);
            this.notesComboBox.Name = "notesComboBox";
            this.notesComboBox.Size = new System.Drawing.Size(267, 28);
            this.notesComboBox.TabIndex = 2;
            this.notesComboBox.SelectedIndexChanged += new System.EventHandler(this.notesComboBox_SelectedIndexChanged);
            // 
            // SelectLBL
            // 
            this.SelectLBL.AutoSize = true;
            this.SelectLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectLBL.Location = new System.Drawing.Point(489, 60);
            this.SelectLBL.Name = "SelectLBL";
            this.SelectLBL.Size = new System.Drawing.Size(87, 29);
            this.SelectLBL.TabIndex = 3;
            this.SelectLBL.Text = "Select:";
            // 
            // ModifyNoteBTN
            // 
            this.ModifyNoteBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyNoteBTN.Location = new System.Drawing.Point(494, 950);
            this.ModifyNoteBTN.MinimumSize = new System.Drawing.Size(164, 76);
            this.ModifyNoteBTN.Name = "ModifyNoteBTN";
            this.ModifyNoteBTN.Size = new System.Drawing.Size(164, 76);
            this.ModifyNoteBTN.TabIndex = 4;
            this.ModifyNoteBTN.Text = "Modify";
            this.ModifyNoteBTN.UseVisualStyleBackColor = true;
            this.ModifyNoteBTN.Click += new System.EventHandler(this.ModifyNoteBTN_Click);
            // 
            // updateNoteBTN
            // 
            this.updateNoteBTN.Enabled = false;
            this.updateNoteBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateNoteBTN.Location = new System.Drawing.Point(808, 950);
            this.updateNoteBTN.Name = "updateNoteBTN";
            this.updateNoteBTN.Size = new System.Drawing.Size(164, 76);
            this.updateNoteBTN.TabIndex = 5;
            this.updateNoteBTN.Text = "Update";
            this.updateNoteBTN.UseVisualStyleBackColor = true;
            this.updateNoteBTN.Click += new System.EventHandler(this.SaveNoteBTN_Click);
            // 
            // createNoteLinkLabel
            // 
            this.createNoteLinkLabel.AutoSize = true;
            this.createNoteLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNoteLinkLabel.Location = new System.Drawing.Point(662, 9);
            this.createNoteLinkLabel.Name = "createNoteLinkLabel";
            this.createNoteLinkLabel.Size = new System.Drawing.Size(115, 25);
            this.createNoteLinkLabel.TabIndex = 6;
            this.createNoteLinkLabel.TabStop = true;
            this.createNoteLinkLabel.Text = "Create New";
            this.createNoteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // viewBTN
            // 
            this.viewBTN.Location = new System.Drawing.Point(878, 59);
            this.viewBTN.Name = "viewBTN";
            this.viewBTN.Size = new System.Drawing.Size(75, 29);
            this.viewBTN.TabIndex = 7;
            this.viewBTN.Text = "View";
            this.viewBTN.UseVisualStyleBackColor = true;
            this.viewBTN.Click += new System.EventHandler(this.viewBTN_Click);
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 1131);
            this.Controls.Add(this.viewBTN);
            this.Controls.Add(this.createNoteLinkLabel);
            this.Controls.Add(this.updateNoteBTN);
            this.Controls.Add(this.ModifyNoteBTN);
            this.Controls.Add(this.SelectLBL);
            this.Controls.Add(this.notesComboBox);
            this.Controls.Add(this.NotesTxtBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1578, 1187);
            this.Name = "NotesForm";
            this.Text = "Notes ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NotesTxtBox;
        private System.Windows.Forms.ComboBox notesComboBox;
        private System.Windows.Forms.Label SelectLBL;
        private System.Windows.Forms.Button ModifyNoteBTN;
        private System.Windows.Forms.Button updateNoteBTN;
        private System.Windows.Forms.LinkLabel createNoteLinkLabel;
        private System.Windows.Forms.Button viewBTN;
    }
}