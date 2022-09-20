
namespace TeacherApp
{
    partial class LoginForm
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
            this.UserName = new System.Windows.Forms.Label();
            this.userPassword = new System.Windows.Forms.Label();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.userPasswordInput = new System.Windows.Forms.TextBox();
            this.createNewLink = new System.Windows.Forms.LinkLabel();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(83, 66);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(58, 13);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "Username:";
            // 
            // userPassword
            // 
            this.userPassword.AutoSize = true;
            this.userPassword.Location = new System.Drawing.Point(85, 137);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(56, 13);
            this.userPassword.TabIndex = 1;
            this.userPassword.Text = "Password:";
            // 
            // userNameInput
            // 
            this.userNameInput.Location = new System.Drawing.Point(147, 66);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(379, 20);
            this.userNameInput.TabIndex = 2;
            // 
            // userPasswordInput
            // 
            this.userPasswordInput.Location = new System.Drawing.Point(147, 130);
            this.userPasswordInput.Name = "userPasswordInput";
            this.userPasswordInput.Size = new System.Drawing.Size(379, 20);
            this.userPasswordInput.TabIndex = 3;
            // 
            // createNewLink
            // 
            this.createNewLink.AutoSize = true;
            this.createNewLink.Location = new System.Drawing.Point(240, 199);
            this.createNewLink.Name = "createNewLink";
            this.createNewLink.Size = new System.Drawing.Size(106, 13);
            this.createNewLink.TabIndex = 4;
            this.createNewLink.TabStop = true;
            this.createNewLink.Text = "Create New Account";
            this.createNewLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewLink_LinkClicked);
            // 
            // LoginBTN
            // 
            this.LoginBTN.Location = new System.Drawing.Point(147, 267);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(98, 39);
            this.LoginBTN.TabIndex = 5;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.UseVisualStyleBackColor = true;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click_1);
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(378, 267);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(92, 40);
            this.CancelBTN.TabIndex = 6;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 398);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.createNewLink);
            this.Controls.Add(this.userPasswordInput);
            this.Controls.Add(this.userNameInput);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.UserName);
            this.Name = "Login";
            this.Text = "Login Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label userPassword;
        private System.Windows.Forms.TextBox userNameInput;
        private System.Windows.Forms.TextBox userPasswordInput;
        private System.Windows.Forms.LinkLabel createNewLink;
        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.Button CancelBTN;
    }
}

