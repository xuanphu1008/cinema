using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Services;
using BusinessLogic.DTOs;

namespace Presentation.Forms
{
    public partial class frmRegister : Form
    {
        private readonly RegisterService _registerService;
        private readonly LoginService loginservice;

        public frmRegister(RegisterService registerService)
        {
            InitializeComponent();
            _registerService = registerService;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var registerDTO = new RegisterDTO
                {
                    fullName = txtFullName.Text,
                    eMail = txtEmail.Text,
                    phoneNumber = txtPhoneNumber.Text,
                    dateOfBirth = dtpDateOfBirth.Value,
                    userName = txtUserName.Text,
                    passWord = txtPassword.Text
                };
                if (chbPolicy.Checked)
                {
                    var isSuccess = _registerService.RegisterNewCustomer(registerDTO);
                    if (isSuccess)
                    {
                        MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var loginservice = new LoginService();
                        frmLogin frmLogin = new frmLogin(loginservice);
                        this.Hide();
                        frmLogin.ShowDialog();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Đăng ký thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Bạn cần đồng ý với điều khoản của chúng tôi để đăng ký");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lkblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin(loginservice);
            this.Hide();
            frmLogin.ShowDialog();
            this.Close();
        }
    }
}
