using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Services;
using BusinessLogic.DTOs;
using Utilities;
using Presentation.Forms.admin;

namespace Presentation.Forms
{
    public partial class frmLogin : Form
    {
        private readonly LoginService _loginservice;
        private frmMain _mainForm;
        private frmScreen _screen;

        public frmLogin(LoginService loginservice)
        {
            InitializeComponent();
            _loginservice = loginservice;
            _mainForm = new frmMain();
            _screen = new frmScreen();
        }

        private void lklRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var registerService = new RegisterService();
            frmRegister register = new frmRegister(registerService);
            register.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var loginDTO = new LoginDTO
                {
                    userName = txtUserName.Text,
                    passWord = txtPassword.Text
                };

                var role = _loginservice.LoginAccount(loginDTO); 

                if (!string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Đăng nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _mainForm.SetPermissions(role);
                    this.Hide();
                    //if (role == "Quản trị viên")
                    //{
                    //    _mainForm.Show();
                    //}
                    //else if (role == "Nhân viên")
                    //{
                    //    _screen.Show();
                    //}
                    _mainForm.Show();
                }
                else if (string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Bạn cần được cấp quyền để đăng nhập vào hệ thống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.SavedUsername))
            {
                txtUserName.Text = Properties.Settings.Default.SavedUsername;
                txtPassword.Text = Properties.Settings.Default.SavedPassword;
            }
        }

    }
}
