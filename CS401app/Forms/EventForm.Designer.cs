namespace TeacherApp.Forms
{
    partial class EventForm
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
            this.modifyBTN = new System.Windows.Forms.Button();
            this.saveBTN = new System.Windows.Forms.Button();
            this.eventTXT = new System.Windows.Forms.TextBox();
            this.dateTXT = new System.Windows.Forms.TextBox();
            this.eventLBL = new System.Windows.Forms.Label();
            this.dateLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modifyBTN
            // 
            this.modifyBTN.Location = new System.Drawing.Point(158, 226);
            this.modifyBTN.Name = "modifyBTN";
            this.modifyBTN.Size = new System.Drawing.Size(96, 41);
            this.modifyBTN.TabIndex = 11;
            this.modifyBTN.Text = "Modify";
            this.modifyBTN.UseVisualStyleBackColor = true;
            this.modifyBTN.Click += new System.EventHandler(this.modifyBTN_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(260, 226);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(96, 41);
            this.saveBTN.TabIndex = 10;
            this.saveBTN.Text = "Save";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // eventTXT
            // 
            this.eventTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventTXT.Location = new System.Drawing.Point(53, 101);
            this.eventTXT.Multiline = true;
            this.eventTXT.Name = "eventTXT";
            this.eventTXT.Size = new System.Drawing.Size(303, 110);
            this.eventTXT.TabIndex = 9;
            // 
            // dateTXT
            // 
            this.dateTXT.Enabled = false;
            this.dateTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTXT.Location = new System.Drawing.Point(53, 45);
            this.dateTXT.Name = "dateTXT";
            this.dateTXT.Size = new System.Drawing.Size(303, 28);
            this.dateTXT.TabIndex = 8;
            // 
            // eventLBL
            // 
            this.eventLBL.AutoSize = true;
            this.eventLBL.Location = new System.Drawing.Point(50, 82);
            this.eventLBL.Name = "eventLBL";
            this.eventLBL.Size = new System.Drawing.Size(48, 16);
            this.eventLBL.TabIndex = 7;
            this.eventLBL.Text = "Events";
            // 
            // dateLBL
            // 
            this.dateLBL.AutoSize = true;
            this.dateLBL.Location = new System.Drawing.Point(50, 26);
            this.dateLBL.Name = "dateLBL";
            this.dateLBL.Size = new System.Drawing.Size(36, 16);
            this.dateLBL.TabIndex = 6;
            this.dateLBL.Text = "Date";
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 311);
            this.Controls.Add(this.modifyBTN);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.eventTXT);
            this.Controls.Add(this.dateTXT);
            this.Controls.Add(this.eventLBL);
            this.Controls.Add(this.dateLBL);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modifyBTN;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.TextBox eventTXT;
        private System.Windows.Forms.TextBox dateTXT;
        private System.Windows.Forms.Label eventLBL;
        private System.Windows.Forms.Label dateLBL;
    }
}