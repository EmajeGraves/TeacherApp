
namespace TeacherApp
{
    partial class ModifyAnnouncements
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
            this.selectSubjectComboBox = new System.Windows.Forms.ComboBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.AnnouncementTXT = new System.Windows.Forms.TextBox();
            this.selectSubjectLBL = new System.Windows.Forms.Label();
            this.editLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 12;
            // 
            // selectSubjectComboBox
            // 
            this.selectSubjectComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSubjectComboBox.FormattingEnabled = true;
            this.selectSubjectComboBox.Location = new System.Drawing.Point(231, 55);
            this.selectSubjectComboBox.Name = "selectSubjectComboBox";
            this.selectSubjectComboBox.Size = new System.Drawing.Size(212, 21);
            this.selectSubjectComboBox.TabIndex = 10;
            this.selectSubjectComboBox.SelectedIndexChanged += new System.EventHandler(this.selectSubjectComboBox_SelectedIndexChanged);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(303, 305);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 26);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.submitAnnouncementBtn_Click);
            // 
            // AnnouncementTXT
            // 
            this.AnnouncementTXT.Enabled = false;
            this.AnnouncementTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnouncementTXT.Location = new System.Drawing.Point(130, 106);
            this.AnnouncementTXT.Multiline = true;
            this.AnnouncementTXT.Name = "AnnouncementTXT";
            this.AnnouncementTXT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AnnouncementTXT.Size = new System.Drawing.Size(454, 179);
            this.AnnouncementTXT.TabIndex = 6;
            // 
            // selectSubjectLBL
            // 
            this.selectSubjectLBL.AutoSize = true;
            this.selectSubjectLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSubjectLBL.Location = new System.Drawing.Point(181, 57);
            this.selectSubjectLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectSubjectLBL.Name = "selectSubjectLBL";
            this.selectSubjectLBL.Size = new System.Drawing.Size(46, 13);
            this.selectSubjectLBL.TabIndex = 13;
            this.selectSubjectLBL.Text = "Subject:";
            // 
            // editLBL
            // 
            this.editLBL.AutoSize = true;
            this.editLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLBL.Location = new System.Drawing.Point(98, 106);
            this.editLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editLBL.Name = "editLBL";
            this.editLBL.Size = new System.Drawing.Size(28, 13);
            this.editLBL.TabIndex = 14;
            this.editLBL.Text = "Edit:";
            // 
            // ModifyAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 354);
            this.Controls.Add(this.editLBL);
            this.Controls.Add(this.selectSubjectLBL);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.AnnouncementTXT);
            this.Controls.Add(this.selectSubjectComboBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(702, 404);
            this.MinimumSize = new System.Drawing.Size(702, 367);
            this.Name = "ModifyAnnouncements";
            this.Text = "Modify Announcements";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectSubjectComboBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox AnnouncementTXT;
        private System.Windows.Forms.Label selectSubjectLBL;
        private System.Windows.Forms.Label editLBL;
    }
}