using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLogic.DTOs;
using BusinessLogic.Services;

namespace Presentation.Forms.admin.edit
{
    public partial class frmEditEmployee : Form
    {
        private readonly EmployeeDTO _employee;
        public frmEditEmployee(EmployeeDTO employee)
        {
            InitializeComponent();
            _employee = employee;
            this.Load += frmEditEmployee_Load;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(txtTenNV.Text))
                {
                    MessageBox.Show("Họ tên không được để trống.");
                    txtTenNV.Focus();
                    return;
                }

                if (!txtTenNV.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("Họ tên chỉ được chứa chữ cái và khoảng trắng.");
                    txtTenNV.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtGioiTinh.Text) || (txtGioiTinh.Text != "Nam" && txtGioiTinh.Text != "Nữ"))
                {
                    MessageBox.Show("Giới tính phải là 'Nam' hoặc 'Nữ'.");
                    txtGioiTinh.Focus();
                    return;
                }

                if (dtpNgaySinh.Value.Date >= DateTime.Now.Date)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ.");
                    dtpNgaySinh.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text) || txtSoDienThoai.Text.Length < 9 || !txtSoDienThoai.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Số điện thoại phải là số và có ít nhất 9 chữ số.");
                    txtSoDienThoai.Focus();
                    return;
                }

                if (!decimal.TryParse(txtLuong.Text, out decimal salary) || salary <= 0)
                {
                    MessageBox.Show("Lương phải là số dương hợp lệ.");
                    txtLuong.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtRole.Text))
                {
                    MessageBox.Show("Vai trò không được để trống.");
                    txtRole.Focus();
                    return;
                }

                // Nếu qua hết validate, cập nhật dữ liệu
                _employee.EmployeeName = txtTenNV.Text.Trim();
                _employee.Gender = txtGioiTinh.Text.Trim();
                _employee.DateOfBirth = dtpNgaySinh.Value;
                _employee.Shift = dtpCaLam.Value.ToShortTimeString();
                _employee.PhoneNumber = txtSoDienThoai.Text.Trim();
                _employee.Salary = salary;
                _employee.Role = txtRole.Text.Trim();

                EmployeeService service = new EmployeeService();
                bool result = service.UpdateEmployee(_employee);

                if (result)
                {
                    MessageBox.Show("Cập nhật nhân viên thành công!");
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }


        private void frmEditEmployee_Load(object sender, EventArgs e)
        {
            // Gán thông tin từ DTO lên control
            txtTenNV.Text = _employee.EmployeeName;
            txtGioiTinh.Text = _employee.Gender;
            dtpNgaySinh.Value = _employee.DateOfBirth;
            dtpCaLam.Value = DateTime.TryParse(_employee.Shift, out var shiftTime) ? shiftTime : DateTime.Now;
            txtSoDienThoai.Text = _employee.PhoneNumber;
            txtLuong.Text = _employee.Salary.ToString();
            txtRole.Text = _employee.Role;
        }

        private void txtLuong_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!decimal.TryParse(txtLuong.Text, out decimal salary) || salary <= 0)
            {
                MessageBox.Show("Lương phải là số dương hợp lệ.");
                e.Cancel = true;
            }
        }



        #region methods
        public EmployeeDTO GetEditedEmployee()
        {
            return new EmployeeDTO
            {
                EmployeeId = _employee.EmployeeId,
                EmployeeName = txtTenNV.Text,
                Gender = txtGioiTinh.Text,
                DateOfBirth = dtpNgaySinh.Value,
                Shift = dtpCaLam.Value.ToShortTimeString(),
                PhoneNumber = txtSoDienThoai.Text,
                Salary = decimal.Parse(txtLuong.Text),
                Role = txtRole.Text
            };
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
