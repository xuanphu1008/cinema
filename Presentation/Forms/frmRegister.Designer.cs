namespace Presentation.Forms
{
    partial class frmRegister
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lkblLogin = new System.Windows.Forms.LinkLabel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblRePassword = new System.Windows.Forms.Label();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.chbPolicy = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lbl_DateOfBirth = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlMain.Controls.Add(this.lkblLogin);
            this.pnlMain.Controls.Add(this.panel8);
            this.pnlMain.Controls.Add(this.btnRegister);
            this.pnlMain.Controls.Add(this.panel7);
            this.pnlMain.Controls.Add(this.panel6);
            this.pnlMain.Controls.Add(this.panel5);
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Location = new System.Drawing.Point(18, 18);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(946, 931);
            this.pnlMain.TabIndex = 0;
            // 
            // lkblLogin
            // 
            this.lkblLogin.AutoSize = true;
            this.lkblLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkblLogin.LinkColor = System.Drawing.Color.Black;
            this.lkblLogin.Location = new System.Drawing.Point(698, 861);
            this.lkblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lkblLogin.Name = "lkblLogin";
            this.lkblLogin.Size = new System.Drawing.Size(234, 28);
            this.lkblLogin.TabIndex = 10;
            this.lkblLogin.TabStop = true;
            this.lkblLogin.Text = "Quay lại trang đăng nhập";
            this.lkblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkblLogin_LinkClicked);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lblRePassword);
            this.panel8.Controls.Add(this.txtRePassword);
            this.panel8.Location = new System.Drawing.Point(4, 649);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(939, 74);
            this.panel8.TabIndex = 6;
            // 
            // lblRePassword
            // 
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRePassword.Location = new System.Drawing.Point(8, 28);
            this.lblRePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(223, 36);
            this.lblRePassword.TabIndex = 17;
            this.lblRePassword.Text = "Nhập lại mật khẩu";
            // 
            // txtRePassword
            // 
            this.txtRePassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePassword.Location = new System.Drawing.Point(248, 14);
            this.txtRePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRePassword.Multiline = true;
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '*';
            this.txtRePassword.Size = new System.Drawing.Size(577, 44);
            this.txtRePassword.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(382, 849);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(183, 51);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.linkLabel1);
            this.panel7.Controls.Add(this.chbPolicy);
            this.panel7.Location = new System.Drawing.Point(4, 734);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(939, 74);
            this.panel7.TabIndex = 7;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(374, 20);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(314, 36);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Điều khoản của 4SCinema";
            // 
            // chbPolicy
            // 
            this.chbPolicy.AutoSize = true;
            this.chbPolicy.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPolicy.Location = new System.Drawing.Point(182, 18);
            this.chbPolicy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbPolicy.Name = "chbPolicy";
            this.chbPolicy.Size = new System.Drawing.Size(201, 40);
            this.chbPolicy.TabIndex = 8;
            this.chbPolicy.Text = "Tôi đồng ý với";
            this.chbPolicy.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblPassword);
            this.panel6.Controls.Add(this.txtPassword);
            this.panel6.Location = new System.Drawing.Point(4, 557);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(939, 74);
            this.panel6.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(108, 28);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(123, 36);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(248, 14);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(577, 44);
            this.txtPassword.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblUsername);
            this.panel5.Controls.Add(this.txtUserName);
            this.panel5.Location = new System.Drawing.Point(4, 466);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(939, 74);
            this.panel5.TabIndex = 4;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(44, 28);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(185, 36);
            this.lblUsername.TabIndex = 16;
            this.lblUsername.Text = "Tên đăng nhập";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(248, 14);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(577, 44);
            this.txtUserName.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtpDateOfBirth);
            this.panel4.Controls.Add(this.lbl_DateOfBirth);
            this.panel4.Location = new System.Drawing.Point(4, 375);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(939, 74);
            this.panel4.TabIndex = 3;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Location = new System.Drawing.Point(248, 18);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(312, 39);
            this.dtpDateOfBirth.TabIndex = 16;
            // 
            // lbl_DateOfBirth
            // 
            this.lbl_DateOfBirth.AutoSize = true;
            this.lbl_DateOfBirth.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateOfBirth.Location = new System.Drawing.Point(99, 28);
            this.lbl_DateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DateOfBirth.Name = "lbl_DateOfBirth";
            this.lbl_DateOfBirth.Size = new System.Drawing.Size(129, 36);
            this.lbl_DateOfBirth.TabIndex = 15;
            this.lbl_DateOfBirth.Text = "Ngày sinh";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblEmail);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Location = new System.Drawing.Point(4, 285);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 74);
            this.panel3.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(148, 28);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(75, 36);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(248, 14);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(577, 44);
            this.txtEmail.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPhoneNumber);
            this.panel2.Controls.Add(this.txtPhoneNumber);
            this.panel2.Location = new System.Drawing.Point(4, 194);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 74);
            this.panel2.TabIndex = 1;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(64, 28);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(166, 36);
            this.lblPhoneNumber.TabIndex = 13;
            this.lblPhoneNumber.Text = "Số điện thoại";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(248, 14);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(577, 44);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFullName);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Location = new System.Drawing.Point(4, 103);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 74);
            this.panel1.TabIndex = 0;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(138, 28);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(93, 36);
            this.lblFullName.TabIndex = 12;
            this.lblFullName.Text = "Họ tên";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(248, 14);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(577, 44);
            this.txtFullName.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(4, 5);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(939, 89);
            this.pnlHeader.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(376, 17);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 55);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Đăng Ký";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 963);
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Đăng ký";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegister_FormClosing);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbl_DateOfBirth;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox chbPolicy;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblRePassword;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.LinkLabel lkblLogin;
    }
}