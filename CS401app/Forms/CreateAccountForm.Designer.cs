
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
            this.roleLBL = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
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
            this.mainContentPNL.Location = new System.Drawing.Point(81, 18);
            this.mainContentPNL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainContentPNL.Name = "mainContentPNL";
            this.mainContentPNL.Size = new System.Drawing.Size(1173, 937);
            this.mainContentPNL.TabIndex = 0;
            this.mainContentPNL.Paint += new System.Windows.Forms.PaintEventHandler(this.mainContentPNL_Paint);
            // 
            // roleLBL
            // 
            this.roleLBL.AutoSize = true;
            this.roleLBL.Location = new System.Drawing.Point(84, 191);
            this.roleLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roleLBL.Name = "roleLBL";
            this.roleLBL.Size = new System.Drawing.Size(46, 20);
            this.roleLBL.TabIndex = 17;
            this.roleLBL.Text = "Role:";
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Admin"});
            this.roleComboBox.Location = new System.Drawing.Point(132, 186);
            this.roleComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roleComboBox.MaximumSize = new System.Drawing.Size(1000, 0);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(142, 28);
            this.roleComboBox.TabIndex = 16;
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(684, 785);
            this.CancelBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(206, 82);
            this.CancelBTN.TabIndex = 15;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // createBTN
            // 
            this.createBTN.Location = new System.Drawing.Point(350, 785);
            this.createBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createBTN.Name = "createBTN";
            this.createBTN.Size = new System.Drawing.Size(206, 82);
            this.createBTN.TabIndex = 14;
            this.createBTN.Text = "Create Account";
            this.createBTN.UseVisualStyleBackColor = true;
            this.createBTN.Click += new System.EventHandler(this.createBTN_Click_1);
            // 
            // lastnameLBL
            // 
            this.lastnameLBL.AutoSize = true;
            this.lastnameLBL.Location = new System.Drawing.Point(562, 111);
            this.lastnameLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastnameLBL.Name = "lastnameLBL";
            this.lastnameLBL.Size = new System.Drawing.Size(90, 20);
            this.lastnameLBL.TabIndex = 12;
            this.lastnameLBL.Text = "Last Name:";
            // 
            // firstNameLBL
            // 
            this.firstNameLBL.AutoSize = true;
            this.firstNameLBL.Location = new System.Drawing.Point(562, 34);
            this.firstNameLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLBL.Name = "firstNameLBL";
            this.firstNameLBL.Size = new System.Drawing.Size(90, 20);
            this.firstNameLBL.TabIndex = 11;
            this.firstNameLBL.Text = "First Name:";
            // 
            // passwordLBL
            // 
            this.passwordLBL.AutoSize = true;
            this.passwordLBL.Location = new System.Drawing.Point(48, 111);
            this.passwordLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLBL.Name = "passwordLBL";
            this.passwordLBL.Size = new System.Drawing.Size(82, 20);
            this.passwordLBL.TabIndex = 10;
            this.passwordLBL.Text = "Password:";
            // 
            // usernameLBL
            // 
            this.usernameLBL.AutoSize = true;
            this.usernameLBL.Location = new System.Drawing.Point(45, 34);
            this.usernameLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLBL.Name = "usernameLBL";
            this.usernameLBL.Size = new System.Drawing.Size(87, 20);
            this.usernameLBL.TabIndex = 9;
            this.usernameLBL.Text = "Username:";
            // 
            // lastNameTXT
            // 
            this.lastNameTXT.Location = new System.Drawing.Point(663, 106);
            this.lastNameTXT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastNameTXT.Name = "lastNameTXT";
            this.lastNameTXT.Size = new System.Drawing.Size(396, 26);
            this.lastNameTXT.TabIndex = 8;
            // 
            // firstNameTXT
            // 
            this.firstNameTXT.Location = new System.Drawing.Point(663, 29);
            this.firstNameTXT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstNameTXT.Name = "firstNameTXT";
            this.firstNameTXT.Size = new System.Drawing.Size(396, 26);
            this.firstNameTXT.TabIndex = 7;
            // 
            // passwordTXT
            // 
            this.passwordTXT.Location = new System.Drawing.Point(132, 106);
            this.passwordTXT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.Size = new System.Drawing.Size(368, 26);
            this.passwordTXT.TabIndex = 6;
            // 
            // usernameTXT
            // 
            this.usernameTXT.Location = new System.Drawing.Point(132, 29);
            this.usernameTXT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameTXT.Name = "usernameTXT";
            this.usernameTXT.Size = new System.Drawing.Size(368, 26);
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
            this.contactInfoGPBX.Location = new System.Drawing.Point(28, 565);
            this.contactInfoGPBX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contactInfoGPBX.Name = "contactInfoGPBX";
            this.contactInfoGPBX.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contactInfoGPBX.Size = new System.Drawing.Size(1110, 151);
            this.contactInfoGPBX.TabIndex = 1;
            this.contactInfoGPBX.TabStop = false;
            this.contactInfoGPBX.Text = "Contact Info";
            // 
            // schoolEmailLBL
            // 
            this.schoolEmailLBL.AutoSize = true;
            this.schoolEmailLBL.Location = new System.Drawing.Point(519, 55);
            this.schoolEmailLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.schoolEmailLBL.Name = "schoolEmailLBL";
            this.schoolEmailLBL.Size = new System.Drawing.Size(105, 20);
            this.schoolEmailLBL.TabIndex = 7;
            this.schoolEmailLBL.Text = "School Email:";
            // 
            // schoolEmailTXT
            // 
            this.schoolEmailTXT.Location = new System.Drawing.Point(633, 45);
            this.schoolEmailTXT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.schoolEmailTXT.Name = "schoolEmailTXT";
            this.schoolEmailTXT.Size = new System.Drawing.Size(397, 26);
            this.schoolEmailTXT.TabIndex = 6;
            // 
            // phoneTXT
            // 
            this.phoneTXT.Location = new System.Drawing.Point(104, 98);
            this.phoneTXT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneTXT.Name = "phoneTXT";
            this.phoneTXT.Size = new System.Drawing.Size(205, 26);
            this.phoneTXT.TabIndex = 5;
            // 
            // emailTXT
            // 
            this.emailTXT.Location = new System.Drawing.Point(104, 45);
            this.emailTXT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailTXT.Name = "emailTXT";
            this.emailTXT.Size = new System.Drawing.Size(397, 26);
            this.emailTXT.TabIndex = 4;
            // 
            // phonelLBL
            // 
            this.phonelLBL.AutoSize = true;
            this.phonelLBL.Location = new System.Drawing.Point(42, 103);
            this.phonelLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phonelLBL.Name = "phonelLBL";
            this.phonelLBL.Size = new System.Drawing.Size(59, 20);
            this.phonelLBL.TabIndex = 3;
            this.phonelLBL.Text = "Phone:";
            // 
            // emailLBL
            // 
            this.emailLBL.AutoSize = true;
            this.emailLBL.Location = new System.Drawing.Point(42, 49);
            this.emailLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLBL.Name = "emailLBL";
            this.emailLBL.Size = new System.Drawing.Size(52, 20);
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
            this.addressInfoGPBX.Location = new System.Drawing.Point(28, 249);
            this.addressInfoGPBX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addressInfoGPBX.Name = "addressInfoGPBX";
            this.addressInfoGPBX.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addressInfoGPBX.Size = new System.Drawing.Size(1110, 257);
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
            this.stateComboBX.Location = new System.Drawing.Point(134, 180);
            this.stateComboBX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stateComboBX.Name = "stateComboBX";
            this.stateComboBX.Size = new System.Drawing.Size(102, 28);
            this.stateComboBX.TabIndex = 8;
            // 
            // stateLBL
            // 
            this.stateLBL.AutoSize = true;
            this.stateLBL.Location = new System.Drawing.Point(70, 185);
            this.stateLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stateLBL.Name = "stateLBL";
            this.stateLBL.Size = new System.Drawing.Size(52, 20);
            this.stateLBL.TabIndex = 7;
            this.stateLBL.Text = "State:";
            // 
            // zipCodeLBL
            // 
            this.zipCodeLBL.AutoSize = true;
            this.zipCodeLBL.Location = new System.Drawing.Point(316, 185);
            this.zipCodeLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zipCodeLBL.Name = "zipCodeLBL";
            this.zipCodeLBL.Size = new System.Drawing.Size(77, 20);
            this.zipCodeLBL.TabIndex = 5;
            this.zipCodeLBL.Text = "Zip Code:";
            // 
            // cityLBL
            // 
            this.cityLBL.AutoSize = true;
            this.cityLBL.Location = new System.Drawing.Point(70, 117);
            this.cityLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLBL.Name = "cityLBL";
            this.cityLBL.Size = new System.Drawing.Size(39, 20);
            this.cityLBL.TabIndex = 4;
            this.cityLBL.Text = "City:";
            // 
            // zipCodeTXT
            // 
            this.zipCodeTXT.Location = new System.Drawing.Point(405, 180);
            this.zipCodeTXT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zipCodeTXT.Name = "zipCodeTXT";
            this.zipCodeTXT.Size = new System.Drawing.Size(192, 26);
            this.zipCodeTXT.TabIndex = 3;
            // 
            // cityTXT
            // 
            this.cityTXT.Location = new System.Drawing.Point(130, 112);
            this.cityTXT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cityTXT.Name = "cityTXT";
            this.cityTXT.Size = new System.Drawing.Size(517, 26);
            this.cityTXT.TabIndex = 2;
            // 
            // streetLBL
            // 
            this.streetLBL.AutoSize = true;
            this.streetLBL.Location = new System.Drawing.Point(54, 46);
            this.streetLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.streetLBL.Name = "streetLBL";
            this.streetLBL.Size = new System.Drawing.Size(57, 20);
            this.streetLBL.TabIndex = 1;
            this.streetLBL.Text = "Street:";
            // 
            // streetTXT
            // 
            this.streetTXT.Location = new System.Drawing.Point(130, 35);
            this.streetTXT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.streetTXT.Name = "streetTXT";
            this.streetTXT.Size = new System.Drawing.Size(898, 26);
            this.streetTXT.TabIndex = 0;
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 962);
            this.Controls.Add(this.mainContentPNL);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1339, 1018);
            this.MinimumSize = new System.Drawing.Size(1339, 1018);
            this.Name = "CreateAccountForm";
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