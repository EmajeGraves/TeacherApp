namespace TeacherApp.Forms
{
    partial class Calendar
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
            this.monthYearLBL = new System.Windows.Forms.Label();
            this.saturdayLBL = new System.Windows.Forms.Label();
            this.fridayLBL = new System.Windows.Forms.Label();
            this.thursdayLBL = new System.Windows.Forms.Label();
            this.wednesdayLBL = new System.Windows.Forms.Label();
            this.tuesdayLBL = new System.Windows.Forms.Label();
            this.mondayLBL = new System.Windows.Forms.Label();
            this.sundayLBL = new System.Windows.Forms.Label();
            this.NextBTN = new System.Windows.Forms.Button();
            this.PreviousBTN = new System.Windows.Forms.Button();
            this.dayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // monthYearLBL
            // 
            this.monthYearLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthYearLBL.Location = new System.Drawing.Point(400, 13);
            this.monthYearLBL.Name = "monthYearLBL";
            this.monthYearLBL.Size = new System.Drawing.Size(409, 25);
            this.monthYearLBL.TabIndex = 21;
            this.monthYearLBL.Text = "MONTH YEAR";
            this.monthYearLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saturdayLBL
            // 
            this.saturdayLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saturdayLBL.Location = new System.Drawing.Point(1038, 52);
            this.saturdayLBL.Name = "saturdayLBL";
            this.saturdayLBL.Size = new System.Drawing.Size(91, 25);
            this.saturdayLBL.TabIndex = 20;
            this.saturdayLBL.Text = "Saturday";
            // 
            // fridayLBL
            // 
            this.fridayLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fridayLBL.Location = new System.Drawing.Point(886, 52);
            this.fridayLBL.Name = "fridayLBL";
            this.fridayLBL.Size = new System.Drawing.Size(66, 25);
            this.fridayLBL.TabIndex = 19;
            this.fridayLBL.Text = "Friday";
            // 
            // thursdayLBL
            // 
            this.thursdayLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thursdayLBL.Location = new System.Drawing.Point(714, 52);
            this.thursdayLBL.Name = "thursdayLBL";
            this.thursdayLBL.Size = new System.Drawing.Size(95, 25);
            this.thursdayLBL.TabIndex = 18;
            this.thursdayLBL.Text = "Thursday";
            // 
            // wednesdayLBL
            // 
            this.wednesdayLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wednesdayLBL.Location = new System.Drawing.Point(541, 52);
            this.wednesdayLBL.Name = "wednesdayLBL";
            this.wednesdayLBL.Size = new System.Drawing.Size(118, 25);
            this.wednesdayLBL.TabIndex = 17;
            this.wednesdayLBL.Text = "Wednesday";
            // 
            // tuesdayLBL
            // 
            this.tuesdayLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuesdayLBL.Location = new System.Drawing.Point(395, 52);
            this.tuesdayLBL.Name = "tuesdayLBL";
            this.tuesdayLBL.Size = new System.Drawing.Size(89, 25);
            this.tuesdayLBL.TabIndex = 16;
            this.tuesdayLBL.Text = "Tuesday";
            // 
            // mondayLBL
            // 
            this.mondayLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mondayLBL.Location = new System.Drawing.Point(231, 52);
            this.mondayLBL.Name = "mondayLBL";
            this.mondayLBL.Size = new System.Drawing.Size(83, 25);
            this.mondayLBL.TabIndex = 15;
            this.mondayLBL.Text = "Monday";
            // 
            // sundayLBL
            // 
            this.sundayLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sundayLBL.Location = new System.Drawing.Point(73, 52);
            this.sundayLBL.Name = "sundayLBL";
            this.sundayLBL.Size = new System.Drawing.Size(80, 25);
            this.sundayLBL.TabIndex = 14;
            this.sundayLBL.Text = "Sunday";
            // 
            // NextBTN
            // 
            this.NextBTN.Location = new System.Drawing.Point(1069, 662);
            this.NextBTN.Name = "NextBTN";
            this.NextBTN.Size = new System.Drawing.Size(78, 35);
            this.NextBTN.TabIndex = 13;
            this.NextBTN.Text = "Next";
            this.NextBTN.UseVisualStyleBackColor = true;
            this.NextBTN.Click += new System.EventHandler(this.NextBTN_Click);
            // 
            // PreviousBTN
            // 
            this.PreviousBTN.Location = new System.Drawing.Point(985, 662);
            this.PreviousBTN.Name = "PreviousBTN";
            this.PreviousBTN.Size = new System.Drawing.Size(78, 35);
            this.PreviousBTN.TabIndex = 12;
            this.PreviousBTN.Text = "Previous";
            this.PreviousBTN.UseVisualStyleBackColor = true;
            this.PreviousBTN.Click += new System.EventHandler(this.PreviousBTN_Click);
            // 
            // dayContainer
            // 
            this.dayContainer.Location = new System.Drawing.Point(31, 87);
            this.dayContainer.Name = "dayContainer";
            this.dayContainer.Size = new System.Drawing.Size(1145, 569);
            this.dayContainer.TabIndex = 11;
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 732);
            this.Controls.Add(this.monthYearLBL);
            this.Controls.Add(this.saturdayLBL);
            this.Controls.Add(this.fridayLBL);
            this.Controls.Add(this.thursdayLBL);
            this.Controls.Add(this.wednesdayLBL);
            this.Controls.Add(this.tuesdayLBL);
            this.Controls.Add(this.mondayLBL);
            this.Controls.Add(this.sundayLBL);
            this.Controls.Add(this.NextBTN);
            this.Controls.Add(this.PreviousBTN);
            this.Controls.Add(this.dayContainer);
            this.Name = "Calendar";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label monthYearLBL;
        private System.Windows.Forms.Label saturdayLBL;
        private System.Windows.Forms.Label fridayLBL;
        private System.Windows.Forms.Label thursdayLBL;
        private System.Windows.Forms.Label wednesdayLBL;
        private System.Windows.Forms.Label tuesdayLBL;
        private System.Windows.Forms.Label mondayLBL;
        private System.Windows.Forms.Label sundayLBL;
        private System.Windows.Forms.Button NextBTN;
        private System.Windows.Forms.Button PreviousBTN;
        private System.Windows.Forms.FlowLayoutPanel dayContainer;
    }
}