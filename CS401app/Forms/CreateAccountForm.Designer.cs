
namespace TeacherApp
{
    partial class CreateAccountForm
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
            this.mainContentPNL = new System.Windows.Forms.Panel();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.createBTN = new System.Windows.Forms.Button();
            this.lastnameLBL = new System.Windows.Forms.Label();
            this.firstNameLBL = new System.Windows.Forms.Label();
            this.passwordLBL = new System.Windows.Forms.Label();
            this.usernameLBL = new System.Windows.Forms.Label();
            this.lastNameTXT = new System.Windows.Forms.TextBox();
            this.firstNameTXT = new System.Windows.Forms.TextBox();
            this.passwordTXT = new System.Windows.Forms.TextBox();
            this.usernameTXT = new System.Windows.Forms.TextBox();
            this.contactInfoGPBX = new System.Windows.Forms.GroupBox();
            this.schoolEmailLBL = new System.Windows.Forms.Label();
            this.schoolEmailTXT = new System.Windows.Forms.TextBox();
            this.phoneTXT = new System.Windows.Forms.TextBox();
            this.emailTXT = new System.Windows.Forms.TextBox();
            this.phonelLBL = new System.Windows.Forms.Label();
            this.emailLBL = new System.Windows.Forms.Label();
            this.addressInfoGPBX = new System.Windows.Forms.GroupBox();
            this.stateComboBX = new System.Windows.Forms.ComboBox();
            this.stateLBL = new System.Windows.Forms.Label();
            this.zipCodeLBL = new System.Windows.Forms.Label();
            this.cityLBL = new System.Windows.Forms.Label();
            this.zipCodeTXT = new System.Windows.Forms.TextBox();
            this.cityTXT = new System.Windows.Forms.TextBox();
            this.streetLBL = new System.Windows.Forms.Label();
            this.streetTXT = new System.Windows.Forms.TextBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.roleLBL = new System.Windows.Forms.Label();
            this.mainContentPNL.SuspendLayout();
            this.contactInfoGPBX.SuspendLayout();
            this.addressInfoGPBX.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContentPNL
            // 
            this.mainContentPNL.Controls.Add(this.roleLBL);
            this.mainContentPNL.Controls.Add(this.roleComboBox);
            this.mainContentPNL.Controls.Add(this.CancelBTN);
            this.mainContentPNL.Controls.Add(this.createBTN);
            this.mainContentPNL.Controls.Add(this.lastnameLBL);
            this.mainContentPNL.Controls.Add(this.firstNameLBL);
            this.mainContentPNL.Controls.Add(this.passwordLBL);
            this.mainContentPNL.Controls.Add(this.usernameLBL);
            this.mainContentPNL.Controls.Add(this.lastNameTXT);
            this.mainContentPNL.Controls.Add(this.firstNameTXT);
            this.mainContentPNL.Controls.Add(this.passwordTXT);
            this.mainContentPNL.Controls.Add(this.usernameTXT);
            this.mainContentPNL.Controls.Add(this.contactInfoGPBX);
            this.mainContentPNL.Controls.Add(this.addressInfoGPBX);
            this.mainContentPNL.Location = new System.Drawing.Point(54, 12);
            this.mainContentPNL.Name = "mainContentPNL";
            this.mainContentPNL.Size = new System.Drawing.Size(782, 609);
            this.mainContentPNL.TabIndex = 0;
            this.mainContentPNL.Paint += new System.Windows.Forms.PaintEventHandler(this.mainContentPNL_Paint);
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(456, 510);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(137, 53);
            this.CancelBTN.TabIndex = 15;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // createBTN
            // 
            this.createBTN.Location = new System.Drawing.Point(233, 510);
            this.createBTN.Name = "createBTN";
            this.createBTN.Size = new System.Drawing.Size(137, 53);
            this.createBTN.TabIndex = 14;
            this.createBTN.Text = "Create Account";
            this.createBTN.UseVisualStyleBackColor = true;
            this.createBTN.Click += new System.EventHandler(this.createBTN_Click_1);
            // 
            // lastnameLBL
            // 
            this.lastnameLBL.AutoSize = true;
            this.lastnameLBL.Location = new System.Drawing.Point(375, 72);
            this.lastnameLBL.Name = "lastnameLBL";
            this.lastnameLBL.Size = new System.Drawing.Size(61, 13);
            this.lastnameLBL.TabIndex = 12;
            this.lastnameLBL.Text = "Last Name:";
            // 
            // firstNameLBL
            // 
            this.firstNameLBL.AutoSize = true;
            this.firstNameLBL.Location = new System.Drawing.Point(375, 22);
            this.firstNameLBL.Name = "firstNameLBL";
            this.firstNameLBL.Size = new System.Drawing.Size(60, 13);
            this.firstNameLBL.TabIndex = 11;
            this.firstNameLBL.Text = "First Name:";
            // 
            // passwordLBL
            // 
            this.passwordLBL.AutoSize = true;
            this.passwordLBL.Location = new System.Drawing.Point(32, 72);
            this.passwordLBL.Name = "passwordLBL";
            this.passwordLBL.Size = new System.Drawing.Size(56, 13);
            this.passwordLBL.TabIndex = 10;
            this.passwordLBL.Text = "Password:";
            // 
            // usernameLBL
            // 
            this.usernameLBL.AutoSize = true;
            this.usernameLBL.Location = new System.Drawing.Point(30, 22);
            this.usernameLBL.Name = "usernameLBL";
            this.usernameLBL.Size = new System.Drawing.Size(58, 13);
            this.usernameLBL.TabIndex = 9;
            this.usernameLBL.Text = "Username:";
            // 
            // lastNameTXT
            // 
            this.lastNameTXT.Location = new System.Drawing.Point(442, 69);
            this.lastNameTXT.Name = "lastNameTXT";
            this.lastNameTXT.Size = new System.Drawing.Size(265, 20);
            this.lastNameTXT.TabIndex = 8;
            // 
            // firstNameTXT
            // 
            this.firstNameTXT.Location = new System.Drawing.Point(442, 19);
            this.firstNameTXT.Name = "firstNameTXT";
            this.firstNameTXT.Size = new System.Drawing.Size(265, 20);
            this.firstNameTXT.TabIndex = 7;
            // 
            // passwordTXT
            // 
            this.passwordTXT.Location = new System.Drawing.Point(88, 69);
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.Size = new System.Drawing.Size(247, 20);
            this.passwordTXT.TabIndex = 6;
            // 
            // usernameTXT
            // 
            this.usernameTXT.Location = new System.Drawing.Point(88, 19);
            this.usernameTXT.Name = "usernameTXT";
            this.usernameTXT.Size = new System.Drawing.Size(247, 20);
            this.usernameTXT.TabIndex = 5;
            // 
            // contactInfoGPBX
            // 
            this.contactInfoGPBX.Controls.Add(this.schoolEmailLBL);
            this.contactInfoGPBX.Controls.Add(this.schoolEmailTXT);
            this.contactInfoGPBX.Controls.Add(this.phoneTXT);
            this.contactInfoGPBX.Controls.Add(this.emailTXT);
            this.contactInfoGPBX.Controls.Add(this.phonelLBL);
            this.contactInfoGPBX.Controls.Add(this.emailLBL);
            this.contactInfoGPBX.Location = new System.Drawing.Point(19, 367);
            this.contactInfoGPBX.Name = "contactInfoGPBX";
            this.contactInfoGPBX.Size = new System.Drawing.Size(740, 98);
            this.contactInfoGPBX.TabIndex = 1;
            this.contactInfoGPBX.TabStop = false;
            this.contactInfoGPBX.Text = "Contact Info";
            // 
            // schoolEmailLBL
            // 
            this.schoolEmailLBL.AutoSize = true;
            this.schoolEmailLBL.Location = new System.Drawing.Point(346, 36);
            this.schoolEmailLBL.Name = "schoolEmailLBL";
            this.schoolEmailLBL.Size = new System.Drawing.Size(71, 13);
            this.schoolEmailLBL.TabIndex = 7;
            this.schoolEmailLBL.Text = "School Email:";
            // 
            // schoolEmailTXT
            // 
            this.schoolEmailTXT.Location = new System.Drawing.Point(422, 29);
            this.schoolEmailTXT.Name = "schoolEmailTXT";
            this.schoolEmailTXT.Size = new System.Drawing.Size(266, 20);
            this.schoolEmailTXT.TabIndex = 6;
            // 
            // phoneTXT
            // 
            this.phoneTXT.Location = new System.Drawing.Point(69, 64);
            this.phoneTXT.Name = "phoneTXT";
            this.phoneTXT.Size = new System.Drawing.Size(138, 20);
            this.phoneTXT.TabIndex = 5;
            // 
            // emailTXT
            // 
            this.emailTXT.Location = new System.Drawing.Point(69, 29);
            this.emailTXT.Name = "emailTXT";
            this.emailTXT.Size = new System.Drawing.Size(266, 20);
            this.emailTXT.TabIndex = 4;
            // 
            // phonelLBL
            // 
            this.phonelLBL.AutoSize = true;
            this.phonelLBL.Location = new System.Drawing.Point(28, 67);
            this.phonelLBL.Name = "phonelLBL";
            this.phonelLBL.Size = new System.Drawing.Size(41, 13);
            this.phonelLBL.TabIndex = 3;
            this.phonelLBL.Text = "Phone:";
            // 
            // emailLBL
            // 
            this.emailLBL.AutoSize = true;
            this.emailLBL.Location = new System.Drawing.Point(28, 32);
            this.emailLBL.Name = "emailLBL";
            this.emailLBL.Size = new System.Drawing.Size(35, 13);
            this.emailLBL.TabIndex = 2;
            this.emailLBL.Text = "Email:";
            this.emailLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // addressInfoGPBX
            // 
            this.addressInfoGPBX.Controls.Add(this.stateComboBX);
            this.addressInfoGPBX.Controls.Add(this.stateLBL);
            this.addressInfoGPBX.Controls.Add(this.zipCodeLBL);
            this.addressInfoGPBX.Controls.Add(this.cityLBL);
            this.addressInfoGPBX.Controls.Add(this.zipCodeTXT);
            this.addressInfoGPBX.Controls.Add(this.cityTXT);
            this.addressInfoGPBX.Controls.Add(this.streetLBL);
            this.addressInfoGPBX.Controls.Add(this.streetTXT);
            this.addressInfoGPBX.Location = new System.Drawing.Point(19, 162);
            this.addressInfoGPBX.Name = "addressInfoGPBX";
            this.addressInfoGPBX.Size = new System.Drawing.Size(740, 167);
            this.addressInfoGPBX.TabIndex = 0;
            this.addressInfoGPBX.TabStop = false;
            this.addressInfoGPBX.Text = "Address Info";
            // 
            // stateComboBX
            // 
            this.stateComboBX.FormattingEnabled = true;
            this.stateComboBX.Items.AddRange(new object[] {
            "Alabama",
            "California",
            "Georgia",
            "Oregon",
            "Washington"});
            this.stateComboBX.Location = new System.Drawing.Point(89, 117);
            this.stateComboBX.Name = "stateComboBX";
            this.stateComboBX.Size = new System.Drawing.Size(69, 21);
            this.stateComboBX.TabIndex = 8;
            // 
            // stateLBL
            // 
            this.stateLBL.AutoSize = true;
            this.stateLBL.Location = new System.Drawing.Point(47, 120);
            this.stateLBL.Name = "stateLBL";
            this.stateLBL.Size = new System.Drawing.Size(35, 13);
            this.stateLBL.TabIndex = 7;
            this.stateLBL.Text = "State:";
            // 
            // zipCodeLBL
            // 
            this.zipCodeLBL.AutoSize = true;
            this.zipCodeLBL.Location = new System.Drawing.Point(211, 120);
            this.zipCodeLBL.Name = "zipCodeLBL";
            this.zipCodeLBL.Size = new System.Drawing.Size(53, 13);
            this.zipCodeLBL.TabIndex = 5;
            this.zipCodeLBL.Text = "Zip Code:";
            // 
            // cityLBL
            // 
            this.cityLBL.AutoSize = true;
            this.cityLBL.Location = new System.Drawing.Point(47, 76);
            this.cityLBL.Name = "cityLBL";
            this.cityLBL.Size = new System.Drawing.Size(27, 13);
            this.cityLBL.TabIndex = 4;
            this.cityLBL.Text = "City:";
            // 
            // zipCodeTXT
            // 
            this.zipCodeTXT.Location = new System.Drawing.Point(270, 117);
            this.zipCodeTXT.Name = "zipCodeTXT";
            this.zipCodeTXT.Size = new System.Drawing.Size(129, 20);
            this.zipCodeTXT.TabIndex = 3;
            // 
            // cityTXT
            // 
            this.cityTXT.Location = new System.Drawing.Point(87, 73);
            this.cityTXT.Name = "cityTXT";
            this.cityTXT.Size = new System.Drawing.Size(346, 20);
            this.cityTXT.TabIndex = 2;
            // 
            // streetLBL
            // 
            this.streetLBL.AutoSize = true;
            this.streetLBL.Location = new System.Drawing.Point(36, 30);
            this.streetLBL.Name = "streetLBL";
            this.streetLBL.Size = new System.Drawing.Size(38, 13);
            this.streetLBL.TabIndex = 1;
            this.streetLBL.Text = "Street:";
            // 
            // streetTXT
            // 
            this.streetTXT.Location = new System.Drawing.Point(87, 23);
            this.streetTXT.Name = "streetTXT";
            this.streetTXT.Size = new System.Drawing.Size(600, 20);
            this.streetTXT.TabIndex = 0;
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Admin"});
            this.roleComboBox.Location = new System.Drawing.Point(88, 121);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(96, 21);
            this.roleComboBox.TabIndex = 16;
            // 
            // roleLBL
            // 
            this.roleLBL.AutoSize = true;
            this.roleLBL.Location = new System.Drawing.Point(56, 124);
            this.roleLBL.Name = "roleLBL";
            this.roleLBL.Size = new System.Drawing.Size(32, 13);
            this.roleLBL.TabIndex = 17;
            this.roleLBL.Text = "Role:";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 976);
            this.Controls.Add(this.mainContentPNL);
            this.MinimumSize = new System.Drawing.Size(900, 690);
            this.Name = "AccountForm";
            this.Text = "Create Account";
            this.mainContentPNL.ResumeLayout(false);
            this.mainContentPNL.PerformLayout();
            this.contactInfoGPBX.ResumeLayout(false);
            this.contactInfoGPBX.PerformLayout();
            this.addressInfoGPBX.ResumeLayout(false);
            this.addressInfoGPBX.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainContentPNL;
        private System.Windows.Forms.GroupBox contactInfoGPBX;
        private System.Windows.Forms.GroupBox addressInfoGPBX;
        private System.Windows.Forms.TextBox phoneTXT;
        private System.Windows.Forms.TextBox emailTXT;
        private System.Windows.Forms.Label phonelLBL;
        private System.Windows.Forms.Label emailLBL;
        private System.Windows.Forms.Label zipCodeLBL;
        private System.Windows.Forms.Label cityLBL;
        private System.Windows.Forms.TextBox cityTXT;
        private System.Windows.Forms.Label streetLBL;
        private System.Windows.Forms.TextBox streetTXT;
        private System.Windows.Forms.Label lastnameLBL;
        private System.Windows.Forms.Label firstNameLBL;
        private System.Windows.Forms.Label passwordLBL;
        private System.Windows.Forms.Label usernameLBL;
        private System.Windows.Forms.TextBox lastNameTXT;
        private System.Windows.Forms.TextBox firstNameTXT;
        private System.Windows.Forms.TextBox passwordTXT;
        private System.Windows.Forms.TextBox usernameTXT;
        private System.Windows.Forms.ComboBox stateComboBX;
        private System.Windows.Forms.Label stateLBL;
        private System.Windows.Forms.TextBox zipCodeTXT;
        private System.Windows.Forms.Label schoolEmailLBL;
        private System.Windows.Forms.TextBox schoolEmailTXT;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button createBTN;
        private System.Windows.Forms.Label roleLBL;
        private System.Windows.Forms.ComboBox roleComboBox;
    }
}