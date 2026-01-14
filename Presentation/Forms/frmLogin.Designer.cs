namespace Presentation.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lklRegister = new System.Windows.Forms.LinkLabel();
            this.lklForgotPass = new System.Windows.Forms.LinkLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 578);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lklRegister);
            this.panel3.Controls.Add(this.lklForgotPass);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(430, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 572);
            this.panel3.TabIndex = 5;
            // 
            // lklRegister
            // 
            this.lklRegister.AutoSize = true;
            this.lklRegister.LinkColor = System.Drawing.Color.Black;
            this.lklRegister.Location = new System.Drawing.Point(15, 372);
            this.lklRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lklRegister.Name = "lklRegister";
            this.lklRegister.Size = new System.Drawing.Size(276, 20);
            this.lklRegister.TabIndex = 5;
            this.lklRegister.TabStop = true;
            this.lklRegister.Text = "Bạn chưa có tài khoản? Đăng ký ngay";
            this.lklRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklRegister_LinkClicked);
            // 
            // lklForgotPass
            // 
            this.lklForgotPass.AutoSize = true;
            this.lklForgotPass.LinkColor = System.Drawing.Color.Black;
            this.lklForgotPass.Location = new System.Drawing.Point(390, 372);
            this.lklForgotPass.Name = "lklForgotPass";
            this.lklForgotPass.Size = new System.Drawing.Size(127, 20);
            this.lklForgotPass.TabIndex = 4;
            this.lklForgotPass.TabStop = true;
            this.lklForgotPass.Text = "Quên mật khẩu?";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnLogin);
            this.panel7.Location = new System.Drawing.Point(9, 434);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(508, 112);
            this.panel7.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(170, 31);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 52);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Location = new System.Drawing.Point(9, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 125);
            this.panel2.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(129, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(275, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Đăng nhập";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtPassword);
            this.panel6.Controls.Add(this.lblPassword);
            this.panel6.Location = new System.Drawing.Point(9, 252);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(508, 112);
            this.panel6.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(10, 54);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(494, 46);
            this.txtPassword.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(3, 9);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(141, 40);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblUserName);
            this.panel5.Controls.Add(this.txtUserName);
            this.panel5.Location = new System.Drawing.Point(9, 134);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(508, 112);
            this.panel5.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(3, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(211, 40);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Tên đăng nhập";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(9, 55);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(496, 46);
            this.txtUserName.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(422, 572);
            this.panel4.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(978, 603);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Đăng nhập";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chbRemember;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.LinkLabel lklForgotPass;
        private System.Windows.Forms.LinkLabel lklRegister;
    }
}