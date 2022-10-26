namespace TeacherApp
{
    partial class CreateNotesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.noteNameTxtBOX = new System.Windows.Forms.TextBox();
            this.saveBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // noteNameTxtBOX
            // 
            this.noteNameTxtBOX.Location = new System.Drawing.Point(138, 67);
            this.noteNameTxtBOX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noteNameTxtBOX.Name = "noteNameTxtBOX";
            this.noteNameTxtBOX.Size = new System.Drawing.Size(243, 26);
            this.noteNameTxtBOX.TabIndex = 1;
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(221, 118);
            this.saveBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(66, 24);
            this.saveBTN.TabIndex = 2;
            this.saveBTN.Text = "Save";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // CreateNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 176);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.noteNameTxtBOX);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(523, 226);
            this.Name = "CreateNotesForm";
            this.Text = "New Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox noteNameTxtBOX;
        private System.Windows.Forms.Button saveBTN;
    }
}