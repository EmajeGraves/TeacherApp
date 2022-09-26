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
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.CreateNotesBTN = new System.Windows.Forms.Button();
            this.NotesTxtBox = new System.Windows.Forms.TextBox();
            this.notesComboBox = new System.Windows.Forms.ComboBox();
            this.SelectLBL = new System.Windows.Forms.Label();
            this.ModifyNoteBTN = new System.Windows.Forms.Button();
            this.SaveNoteBTN = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // CreateNotesBTN
            // 
            this.CreateNotesBTN.Location = new System.Drawing.Point(0, 0);
            this.CreateNotesBTN.Name = "CreateNotesBTN";
            this.CreateNotesBTN.Size = new System.Drawing.Size(75, 23);
            this.CreateNotesBTN.TabIndex = 7;
            // 
            // NotesTxtBox
            // 
            this.NotesTxtBox.Location = new System.Drawing.Point(119, 120);
            this.NotesTxtBox.Multiline = true;
            this.NotesTxtBox.Name = "NotesTxtBox";
            this.NotesTxtBox.Size = new System.Drawing.Size(1335, 776);
            this.NotesTxtBox.TabIndex = 1;
            // 
            // notesComboBox
            // 
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
            this.ModifyNoteBTN.Location = new System.Drawing.Point(434, 950);
            this.ModifyNoteBTN.MinimumSize = new System.Drawing.Size(164, 76);
            this.ModifyNoteBTN.Name = "ModifyNoteBTN";
            this.ModifyNoteBTN.Size = new System.Drawing.Size(164, 76);
            this.ModifyNoteBTN.TabIndex = 4;
            this.ModifyNoteBTN.Text = "Modify";
            this.ModifyNoteBTN.UseVisualStyleBackColor = true;
            this.ModifyNoteBTN.Click += new System.EventHandler(this.ModifyNoteBTN_Click);
            // 
            // SaveNoteBTN
            // 
            this.SaveNoteBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveNoteBTN.Location = new System.Drawing.Point(808, 950);
            this.SaveNoteBTN.Name = "SaveNoteBTN";
            this.SaveNoteBTN.Size = new System.Drawing.Size(164, 76);
            this.SaveNoteBTN.TabIndex = 5;
            this.SaveNoteBTN.Text = "Save";
            this.SaveNoteBTN.UseVisualStyleBackColor = true;
            this.SaveNoteBTN.Click += new System.EventHandler(this.SaveNoteBTN_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(883, 60);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(115, 25);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create New";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 1131);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.SaveNoteBTN);
            this.Controls.Add(this.ModifyNoteBTN);
            this.Controls.Add(this.SelectLBL);
            this.Controls.Add(this.notesComboBox);
            this.Controls.Add(this.NotesTxtBox);
            this.Controls.Add(this.CreateNotesBTN);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1578, 1187);
            this.Name = "NotesForm";
            this.Text = "Notes ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button CreateNotesBTN;
        private System.Windows.Forms.TextBox NotesTxtBox;
        private System.Windows.Forms.ComboBox notesComboBox;
        private System.Windows.Forms.Label SelectLBL;
        private System.Windows.Forms.Button ModifyNoteBTN;
        private System.Windows.Forms.Button SaveNoteBTN;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}