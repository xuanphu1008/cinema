using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Services;
using BusinessLogic.DTOs;
using Presentation.Forms.admin.add;
using Presentation.Forms.admin.edit;
using System.Collections.Generic;
using Presentation.Forms;

namespace Presentation
{
    public partial class frmMain : Form
    {
        private Button currentButton;
        private int tempIndex;
        private Form activeForm;

        public frmMain()
        {
            InitializeComponent();
            OpenChildForm(new Forms.admin.frmMovie(), btnFilm);

        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.admin.frmMovie(), sender);
        }

        private void btnScreening_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.admin.frmScreen(), sender);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.admin.frmProduct(), sender);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.admin.frmEmployee(), sender);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.admin.frmCustomer(), sender);
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.admin.frmRevenue(), sender);
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                this.Hide();
                var loginservice = new LoginService();
                frmLogin frmLogin = new frmLogin(loginservice);
                frmLogin.ShowDialog();
                this.Close();
            }
        }

        #region methods
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDesktop.Controls.Add(childForm);
            this.pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#256BB0");
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(44, 46, 72);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        public void SetPermissions(string role)
        {
            // Mặc định ẩn tất cả các chức năng
            btnFilm.Visible = false;
            btnProduct.Visible = false;
            btnEmployee.Visible = false;
            btnCustomer.Visible = false;
            btnRevenue.Visible = false;

            // Luôn hiển thị chức năng quản lý suất chiếu và đăng xuất
            btnScreening.Visible = true;
            btnLogout.Visible = true;

            if (role == "Quản trị viên")
            {
                
                // Quản trị viên có quyền truy cập tất cả các chức năng
                btnFilm.Visible = true;
                btnProduct.Visible = true;
                btnEmployee.Visible = true;
                btnCustomer.Visible = true;
                btnRevenue.Visible = true;
            }
            else if (role == "Nhân viên")
            {
                // Nhân viên chỉ được truy cập quản lý suất chiếu và đăng xuất
                btnScreening.Visible = true;
                btnLogout.Visible = true;
                ActivateButton(btnScreening);
                OpenChildForm(new Forms.admin.frmScreen(), btnScreening);
            }
        }

        #endregion

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hiển thị hộp thoại xác nhận thoát
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Kiểm tra kết quả và quyết định có hủy sự kiện không
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy sự kiện đóng Form
            }
            else
            {
                // Giải phóng tài nguyên hoặc dừng các luồng phụ nếu cần
                Application.Exit(); // Đảm bảo thoát chương trình
            }
        }

    }
}