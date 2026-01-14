using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BusinessLogic.DTOs;
using BusinessLogic.Services;

namespace Presentation.Forms.admin.add
{
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) return;

                var employeeDTO = new EmployeeDTO
                {
                    EmployeeName = txtTenNV.Text.Trim(),
                    Gender = txtGioiTinh.Text.Trim(),
                    DateOfBirth = dtpNgaySinh.Value,
                    Shift = dtpCaLam.Value.ToString("HH:mm"),
                    PhoneNumber = txtSoDienThoai.Text.Trim(),
                    Salary = decimal.Parse(txtLuong.Text.Trim()),
                    Role = txtRole.Text.Trim(),
                    UserName = txtUsername.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                };

                var employeeService = new EmployeeService();
                if (employeeService.AddEmployee(employeeDTO))
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
          

            if (string.IsNullOrWhiteSpace(txtTenNV.Text) ||
                !Regex.IsMatch(txtTenNV.Text.Trim(), @"^[\p{L}\s]+$"))
            {
                ShowValidationError("Tên nhân viên không được để trống và chỉ chứa chữ cái.", txtTenNV);
                return false;
            }

            string gender = txtGioiTinh.Text.Trim().ToLower();
            if (gender != "nam" && gender != "nữ")
            {
                ShowValidationError("Giới tính phải là 'Nam' hoặc 'Nữ'.", txtGioiTinh);
                return false;
            }

            if (dtpNgaySinh.Value.Date >= DateTime.Today)
            {
                MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ||
                !Regex.IsMatch(txtSoDienThoai.Text.Trim(), @"^\d{10}$"))
            {
                ShowValidationError("Số điện thoại phải có 10 chữ số.", txtSoDienThoai);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLuong.Text) ||
                !decimal.TryParse(txtLuong.Text.Trim(), out decimal salary) || salary <= 0)
            {
                ShowValidationError("Lương phải là số dương.", txtLuong);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtRole.Text))
            {
                ShowValidationError("Vui lòng nhập vai trò.", txtRole);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                ShowValidationError("Vui lòng nhập tên đăng nhập.", txtUsername);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowValidationError("Vui lòng nhập mật khẩu.", txtPassword);
                return false;
            }

            return true;
        }

        private void ShowValidationError(string message, Control control)
        {
            MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
