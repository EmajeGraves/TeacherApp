namespace TeacherApp
{
    partial class CreateClass
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
            this.courseNameLBL = new System.Windows.Forms.Label();
            this.nameTXT = new System.Windows.Forms.TextBox();
            this.saveBTN = new System.Windows.Forms.Button();
            this.creditsComboBox1 = new System.Windows.Forms.ComboBox();
            this.creditLBL = new System.Windows.Forms.Label();
            this.termLBL = new System.Windows.Forms.Label();
            this.termTXT = new System.Windows.Forms.TextBox();
            this.titleLBL = new System.Windows.Forms.Label();
            this.titleTXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // courseNameLBL
            // 
            this.courseNameLBL.AutoSize = true;
            this.courseNameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLBL.Location = new System.Drawing.Point(43, 60);
            this.courseNameLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.courseNameLBL.Name = "courseNameLBL";
            this.courseNameLBL.Size = new System.Drawing.Size(90, 16);
            this.courseNameLBL.TabIndex = 0;
            this.courseNameLBL.Text = "Course name:";
            // 
            // nameTXT
            // 
            this.nameTXT.Location = new System.Drawing.Point(141, 60);
            this.nameTXT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameTXT.Name = "nameTXT";
            this.nameTXT.Size = new System.Drawing.Size(398, 21);
            this.nameTXT.TabIndex = 1;
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(286, 266);
            this.saveBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveBTN.MaximumSize = new System.Drawing.Size(88, 27);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(88, 27);
            this.saveBTN.TabIndex = 2;
            this.saveBTN.Text = "Save";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // creditsComboBox1
            // 
            this.creditsComboBox1.FormattingEnabled = true;
            this.creditsComboBox1.Items.AddRange(new object[] {
            "4",
            "3",
            "2",
            "1"});
            this.creditsComboBox1.Location = new System.Drawing.Point(139, 133);
            this.creditsComboBox1.Name = "creditsComboBox1";
            this.creditsComboBox1.Size = new System.Drawing.Size(121, 23);
            this.creditsComboBox1.TabIndex = 3;
            // 
            // creditLBL
            // 
            this.creditLBL.AutoSize = true;
            this.creditLBL.Location = new System.Drawing.Point(85, 136);
            this.creditLBL.Name = "creditLBL";
            this.creditLBL.Size = new System.Drawing.Size(48, 15);
            this.creditLBL.TabIndex = 4;
            this.creditLBL.Text = "Credits:";
            // 
            // termLBL
            // 
            this.termLBL.AutoSize = true;
            this.termLBL.Location = new System.Drawing.Point(94, 169);
            this.termLBL.Name = "termLBL";
            this.termLBL.Size = new System.Drawing.Size(39, 15);
            this.termLBL.TabIndex = 5;
            this.termLBL.Text = "Term:";
            // 
            // termTXT
            // 
            this.termTXT.Location = new System.Drawing.Point(139, 169);
            this.termTXT.Name = "termTXT";
            this.termTXT.Size = new System.Drawing.Size(207, 21);
            this.termTXT.TabIndex = 6;
            // 
            // titleLBL
            // 
            this.titleLBL.AutoSize = true;
            this.titleLBL.Location = new System.Drawing.Point(100, 100);
            this.titleLBL.Name = "titleLBL";
            this.titleLBL.Size = new System.Drawing.Size(33, 15);
            this.titleLBL.TabIndex = 7;
            this.titleLBL.Text = "Title:";
            this.titleLBL.Click += new System.EventHandler(this.titleLBL_Click);
            // 
            // titleTXT
            // 
            this.titleTXT.Location = new System.Drawing.Point(141, 100);
            this.titleTXT.Name = "titleTXT";
            this.titleTXT.Size = new System.Drawing.Size(348, 21);
            this.titleTXT.TabIndex = 8;
            // 
            // CreateClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 350);
            this.Controls.Add(this.titleTXT);
            this.Controls.Add(this.titleLBL);
            this.Controls.Add(this.termTXT);
            this.Controls.Add(this.termLBL);
            this.Controls.Add(this.creditLBL);
            this.Controls.Add(this.creditsComboBox1);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.nameTXT);
            this.Controls.Add(this.courseNameLBL);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CreateClass";
            this.Text = "Create Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label courseNameLBL;
        private System.Windows.Forms.TextBox nameTXT;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.ComboBox creditsComboBox1;
        private System.Windows.Forms.Label creditLBL;
        private System.Windows.Forms.Label termLBL;
        private System.Windows.Forms.TextBox termTXT;
        private System.Windows.Forms.Label titleLBL;
        private System.Windows.Forms.TextBox titleTXT;
    }
}