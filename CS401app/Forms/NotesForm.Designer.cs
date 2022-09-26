namespace CS401app.Forms
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ModifyNoteBTN = new System.Windows.Forms.Button();
            this.SaveNoteBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // CreateNotesBTN
            // 
            this.CreateNotesBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNotesBTN.Location = new System.Drawing.Point(256, 950);
            this.CreateNotesBTN.MinimumSize = new System.Drawing.Size(164, 76);
            this.CreateNotesBTN.Name = "CreateNotesBTN";
            this.CreateNotesBTN.Size = new System.Drawing.Size(164, 76);
            this.CreateNotesBTN.TabIndex = 0;
            this.CreateNotesBTN.Text = "Create";
            this.CreateNotesBTN.UseVisualStyleBackColor = true;
            // 
            // NotesTxtBox
            // 
            this.NotesTxtBox.Location = new System.Drawing.Point(119, 120);
            this.NotesTxtBox.Multiline = true;
            this.NotesTxtBox.Name = "NotesTxtBox";
            this.NotesTxtBox.Size = new System.Drawing.Size(1335, 776);
            this.NotesTxtBox.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(578, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(267, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Notes:";
            // 
            // ModifyNoteBTN
            // 
            this.ModifyNoteBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyNoteBTN.Location = new System.Drawing.Point(668, 950);
            this.ModifyNoteBTN.MinimumSize = new System.Drawing.Size(164, 76);
            this.ModifyNoteBTN.Name = "ModifyNoteBTN";
            this.ModifyNoteBTN.Size = new System.Drawing.Size(164, 76);
            this.ModifyNoteBTN.TabIndex = 4;
            this.ModifyNoteBTN.Text = "Modify";
            this.ModifyNoteBTN.UseVisualStyleBackColor = true;
            // 
            // SaveNoteBTN
            // 
            this.SaveNoteBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveNoteBTN.Location = new System.Drawing.Point(1091, 950);
            this.SaveNoteBTN.Name = "SaveNoteBTN";
            this.SaveNoteBTN.Size = new System.Drawing.Size(164, 76);
            this.SaveNoteBTN.TabIndex = 5;
            this.SaveNoteBTN.Text = "Save";
            this.SaveNoteBTN.UseVisualStyleBackColor = true;
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 1131);
            this.Controls.Add(this.SaveNoteBTN);
            this.Controls.Add(this.ModifyNoteBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.NotesTxtBox);
            this.Controls.Add(this.CreateNotesBTN);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1578, 1187);
            this.Name = "NotesForm";
            this.Text = "Notes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button CreateNotesBTN;
        private System.Windows.Forms.TextBox NotesTxtBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ModifyNoteBTN;
        private System.Windows.Forms.Button SaveNoteBTN;
    }
}