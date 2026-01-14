using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.DTOs;
using BusinessLogic.Services;
using Presentation.Forms.admin.add;
using Presentation.Forms.admin.edit;
using Excel = Microsoft.Office.Interop.Excel;

namespace Presentation.Forms.admin
    {
        public partial class frmEmployee : Form
        {
            private readonly EmployeeService employeeService = new EmployeeService();
            private List<EmployeeDTO> allEmployees = new List<EmployeeDTO>();
            public frmEmployee()
            {
                InitializeComponent();
                LoadEmployees();
                dgvEmployee.CellContentClick += dgvEmployee_CellContentClick;
                SetColumnHeaders();
            }
            private void MenuListControl_CloseParentForm(object sender, EventArgs e)
            {
                this.Close(); // Đóng Form cha
            }
            private void frmEmployee_Load(object sender, EventArgs e)
            {
                LoadEmployees();
            }

            private void btnAdd_Click(object sender, EventArgs e)
            {
                try
                {
                    using (frmAddEmployee addEmployeeForm = new frmAddEmployee())
                    {
                        if (addEmployeeForm.ShowDialog() == DialogResult.OK)
                        {
                            LoadEmployees();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm nhân viên: {ex.Message}", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0 ||
                    e.RowIndex >= dgvEmployee.Rows.Count ||
                    dgvEmployee.Rows[e.RowIndex].IsNewRow)
                    return;

                if (!dgvEmployee.Columns.Contains("employee_id"))
                {
                    MessageBox.Show("Không tìm thấy cột 'EmployeeId' trong DataGridView.", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                object employeeIdObj = dgvEmployee.Rows[e.RowIndex].Cells["employee_id"].Value;
                if (employeeIdObj == null || string.IsNullOrEmpty(employeeIdObj.ToString()))
                {
                    MessageBox.Show("Không thể lấy ID nhân viên.", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string employeeId = employeeIdObj.ToString();

                if (e.ColumnIndex >= 0 && e.ColumnIndex < dgvEmployee.Columns.Count)
                {
                    string columnName = dgvEmployee.Columns[e.ColumnIndex].Name;

                    if (columnName == "Edit")
                    {
                        EditEmployee(employeeId);
                    }
                    else if (columnName == "Delete")
                    {
                        DeleteEmployee(employeeId);
                    }
                }
            }

            private void dgvEmployee_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
            {
                if (e.RowIndex < 0 || e.RowIndex >= dgvEmployee.Rows.Count)
                    return;

                if (dgvEmployee.Rows[e.RowIndex].IsNewRow)
                    return;

                if (e.ColumnIndex >= 0 && e.ColumnIndex < dgvEmployee.Columns.Count)
                {
                    string columnName = dgvEmployee.Columns[e.ColumnIndex].Name;

                    if (columnName == "Edit" || columnName == "Delete")
                    {
                        e.Value = null;
                        e.FormattingApplied = true;
                    }
                }
            }

            private void btnSearch_Click(object sender, EventArgs e)
            {
                try
                {
                    string searchText = txtSearch.Text.Trim();

                    if (string.IsNullOrEmpty(searchText))
                    {
                        LoadEmployees();  // Nếu không có từ khóa tìm kiếm, tải tất cả nhân viên.
                        return;
                    }

                    dgvEmployee.SuspendLayout();
                    dgvEmployee.DataSource = null;
                    dgvEmployee.Columns.Clear();

                    // Tìm kiếm nhân viên theo tên hoặc các trường khác trong EmployeeService.
                    DataTable data = employeeService.SearchEmployees(searchText);

                    if (data != null && data.Rows.Count > 0)
                    {
                        dgvEmployee.DataSource = data;
                        dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvEmployee.AllowUserToAddRows = false;
                        AddActionColumns();  // Thêm các cột hành động (nếu có).
                        SetColumnHeaders();  // Đặt tiêu đề các cột.
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên nào phù hợp.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEmployees();  // Nếu không có kết quả, tải lại danh sách nhân viên.
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tìm kiếm nhân viên: {ex.Message}", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dgvEmployee.ResumeLayout();
                }
            }

            #region Methods
            private void EditEmployee(string employeeId)
            {
                DialogResult rs = MessageBox.Show($"Chỉnh sửa nhân viên có ID: {employeeId}", "Thông báo", MessageBoxButtons.YesNo);

                if (rs == DialogResult.Yes)
                {
                    if (dgvEmployee.CurrentRow != null)
                    {
                        EmployeeDTO selectedEmployee = new EmployeeDTO
                        {
                            EmployeeId = Convert.ToInt32(dgvEmployee.CurrentRow.Cells["employee_Id"].Value),
                            EmployeeName = dgvEmployee.CurrentRow.Cells["employee_name"].Value.ToString(),
                            Gender = dgvEmployee.CurrentRow.Cells["Gender"].Value.ToString(),
                            DateOfBirth = Convert.ToDateTime(dgvEmployee.CurrentRow.Cells["date_of_birth"].Value),
                            Shift = dgvEmployee.CurrentRow.Cells["Shift"].Value?.ToString(),
                            PhoneNumber = dgvEmployee.CurrentRow.Cells["phone_number"].Value?.ToString(),
                            Salary = Convert.ToDecimal(dgvEmployee.CurrentRow.Cells["Salary"].Value),
                            Role = dgvEmployee.CurrentRow.Cells["Role"].Value.ToString(),
                        };

                        frmEditEmployee editForm = new frmEditEmployee(selectedEmployee);
                        this.Hide();

                        if (editForm.ShowDialog() == DialogResult.Yes)
                        {
                            EmployeeDTO updatedEmployee = editForm.GetEditedEmployee();
                            bool success = employeeService.UpdateEmployee(updatedEmployee);

                            if (success)
                            {
                                MessageBox.Show("Nhân viên đã được cập nhật.");
                                editForm.Close();
                                LoadEmployees();
                                this.Show();
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật nhân viên thất bại.");
                            }
                        }
                        else
                        {
                            this.Show();
                        }
                    }
                }
            }


            private void DeleteEmployee(string employeeId)
            {
                var confirm = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận xóa",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        bool isDeleted = employeeService.DeleteEmployee(employeeId);
                        if (isDeleted)
                        {
                            MessageBox.Show("Xóa nhân viên thành công!", "Thông báo",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadEmployees();
                        }
                        else
                        {
                            MessageBox.Show("Xóa nhân viên thất bại. Vui lòng thử lại.", "Lỗi",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa nhân viên: {ex.Message}", "Lỗi",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            private void LoadEmployees()
            {
                try
                {
                    dgvEmployee.SuspendLayout();
                    dgvEmployee.DataSource = null;
                    dgvEmployee.Columns.Clear();

                    DataTable data = employeeService.GetAllEmployees();

                    if (data != null && data.Rows.Count > 0)
                    {
                        dgvEmployee.DataSource = data;
                        dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvEmployee.AllowUserToAddRows = false;

                        AddActionColumns();
                        SetColumnHeaders();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải dữ liệu nhân viên: {ex.Message}", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dgvEmployee.ResumeLayout();
                }
            }

            private void AddActionColumns()
            {
                if (dgvEmployee.Columns.Contains("Edit") || dgvEmployee.Columns.Contains("Delete"))
                    return;

                var editImage = Properties.Resources.edit_image;
                if (editImage != null)
                {
                    DataGridViewImageColumn editColumn = new DataGridViewImageColumn
                    {
                        Name = "Edit",
                        HeaderText = "Sửa",
                        Image = (Image)editImage.GetThumbnailImage(20, 20, null, IntPtr.Zero),
                        Width = 50
                    };
                    dgvEmployee.Columns.Add(editColumn);
                }

                var deleteImage = Properties.Resources.delete;
                if (deleteImage != null)
                {
                    DataGridViewImageColumn deleteColumn = new DataGridViewImageColumn
                    {
                        Name = "Delete",
                        HeaderText = "Xóa",
                        Image = (Image)deleteImage.GetThumbnailImage(20, 20, null, IntPtr.Zero),
                        Width = 50
                    };
                    dgvEmployee.Columns.Add(deleteColumn);
                }
            }

            private void SetColumnHeaders()
            {
                if (dgvEmployee.Columns.Contains("employee_Id"))
                    dgvEmployee.Columns["employee_Id"].HeaderText = "Mã nhân viên";
                if (dgvEmployee.Columns.Contains("employee_name"))
                    dgvEmployee.Columns["employee_name"].HeaderText = "Họ và tên";
                if (dgvEmployee.Columns.Contains("Gender"))
                    dgvEmployee.Columns["Gender"].HeaderText = "Giới tính";
                if (dgvEmployee.Columns.Contains("date_of_birth"))
                    dgvEmployee.Columns["date_of_birth"].HeaderText = "Ngày sinh";
                if (dgvEmployee.Columns.Contains("Shift"))
                    dgvEmployee.Columns["Shift"].HeaderText = "Ca làm";
                if (dgvEmployee.Columns.Contains("phone_number"))
                    dgvEmployee.Columns["phone_number"].HeaderText = "Số điện thoại";
                if (dgvEmployee.Columns.Contains("Salary"))
                    dgvEmployee.Columns["Salary"].HeaderText = "Lương";
                if (dgvEmployee.Columns.Contains("Role"))
                    dgvEmployee.Columns["Role"].HeaderText = "Chức vụ";
            }

        #endregion

        private void btnAddd_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmAddEmployee addEmployeeForm = new frmAddEmployee())
                {
                    if (addEmployeeForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadEmployees();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm nhân viên: {ex.Message}", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchh_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim();

                if (string.IsNullOrEmpty(searchText))
                {
                    LoadEmployees();  
                    return;
                }

                dgvEmployee.SuspendLayout();
                dgvEmployee.DataSource = null;
                dgvEmployee.Columns.Clear();

                // Tìm kiếm nhân viên theo tên hoặc các trường khác trong EmployeeService.
                DataTable data = employeeService.SearchEmployees(searchText);

                if (data != null && data.Rows.Count > 0)
                {
                    dgvEmployee.DataSource = data;
                    dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvEmployee.AllowUserToAddRows = false;
                    AddActionColumns();  // Thêm các cột hành động (nếu có).
                    SetColumnHeaders();  // Đặt tiêu đề các cột.
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên nào phù hợp.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEmployees();  // Nếu không có kết quả, tải lại danh sách nhân viên.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm nhân viên: {ex.Message}", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvEmployee.ResumeLayout();
            }
        }

        private void FileExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployee.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Excel Files (*.xlsx)|*.xlsx",
                    FileName = "DanhSachNhanVien.xlsx"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel(dgvEmployee, sfd.FileName);
                    MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExportToExcel(DataGridView dgv, string filePath)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Add(Type.Missing);
            Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Sheets[1];

            // Header
            for (int i = 1; i <= dgv.Columns.Count; i++)
            {
                xlWorkSheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
            }

            // Data
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    var value = dgv.Rows[i].Cells[j].Value;
                    xlWorkSheet.Cells[i + 2, j + 1] = value?.ToString();
                }
            }

            // Save and cleanup
            xlWorkBook.SaveAs(filePath);
            xlWorkBook.Close();
            xlApp.Quit();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
        }

        private void lblPagination_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
