namespace TeacherApp.Forms.CalendarControls
{
    partial class UserControlDay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.displayEventLBL = new System.Windows.Forms.Label();
            this.daysLBL = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // displayEventLBL
            // 
            this.displayEventLBL.AutoSize = true;
            this.displayEventLBL.BackColor = System.Drawing.Color.WhiteSmoke;
            this.displayEventLBL.Location = new System.Drawing.Point(3, 40);
            this.displayEventLBL.Name = "displayEventLBL";
            this.displayEventLBL.Size = new System.Drawing.Size(0, 16);
            this.displayEventLBL.TabIndex = 3;
            // 
            // daysLBL
            // 
            this.daysLBL.AutoSize = true;
            this.daysLBL.Location = new System.Drawing.Point(3, 11);
            this.daysLBL.Name = "daysLBL";
            this.daysLBL.Size = new System.Drawing.Size(21, 16);
            this.daysLBL.TabIndex = 2;
            this.daysLBL.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControlDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.displayEventLBL);
            this.Controls.Add(this.daysLBL);
            this.Name = "UserControlDay";
            this.Size = new System.Drawing.Size(156, 88);
            this.Load += new System.EventHandler(this.UserControlDay_Load);
            this.Click += new System.EventHandler(this.UserControlDay_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayEventLBL;
        private System.Windows.Forms.Label daysLBL;
        private System.Windows.Forms.Timer timer1;
    }
}
