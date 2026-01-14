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
using Excel = Microsoft.Office.Interop.Excel;


namespace Presentation.Forms.admin
{
    public partial class frmCustomer : Form
    {
        private readonly CustomerService _customerService;
        private readonly CustomerService customerService = new CustomerService();
        private DataTable _customersData;

        private int _currentPage = 1; // Trang hiện tại
        private int _totalPages; // Tổng số trang
        private int _rowsPerPage = 10; // Số dòng hiển thị mỗi trang
        public frmCustomer()
        {
            InitializeComponent();
            _customerService = new CustomerService();

            dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;


            _currentPage = 1;
            LoadCustomers(_currentPage);
            AddActionColumns();

            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            SetColumnHeaders();
            UpdatePaginationInfo();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            // Đảm bảo các cột được định dạng đúng khi form load
            dgvCustomers.AutoGenerateColumns = true;
            dgvCustomers.AllowUserToAddRows = false; // Đảm bảo không có dòng mới
        }

        private void MenuListControl_CloseParentForm(object sender, EventArgs e)
        {
            this.Close(); // Đóng Form cha
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvCustomers.Columns[e.ColumnIndex].Name == "Delete")
            {
                DeleteCustomer(e.RowIndex);
            }
        }

        private void dgvCustomers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra index hợp lệ
            if (e.RowIndex < 0 || e.RowIndex >= dgvCustomers.Rows.Count)
                return;

            // Ẩn icon X trên dòng mới (nếu có)
            if (dgvCustomers.Rows[e.RowIndex].IsNewRow)
            {
                if (dgvCustomers.Columns[e.ColumnIndex].Name == "Delete")
                {
                    e.Value = null;
                    e.FormattingApplied = true;
                }
            }
        }

        #region methods
        private void LoadCustomers(int page = 1)
        {
            try
            {
                _customersData = _customerService.GetAllCustomers();

                if (_customersData == null) return;

                int totalRows = _customersData.Rows.Count;
                _totalPages = (int)Math.Ceiling((double)totalRows / _rowsPerPage);

                // Lấy dữ liệu cho trang hiện tại
                var paginatedData = _customersData.AsEnumerable()
                    .Skip((page - 1) * _rowsPerPage)
                    .Take(_rowsPerPage)
                    .CopyToDataTable();

                dgvCustomers.DataSource = paginatedData;

                dgvCustomers.AllowUserToAddRows = false;

                // Ẩn cột password nếu có
                if (dgvCustomers.Columns.Contains("passWord"))
                    dgvCustomers.Columns["passWord"].Visible = false;

                SetColumnHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu khách hàng: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePaginationInfo()
        {
            lblPagination.Text = $"Trang {_currentPage}/{_totalPages}";
        }


        private void AddActionColumns()
        {
            // Kiểm tra nếu cột Delete đã tồn tại thì không thêm lại
            if (dgvCustomers.Columns.Contains("Delete"))
                return;

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
                dgvCustomers.Columns.Add(deleteColumn);
            }
        }

        private void DeleteCustomer(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= dgvCustomers.Rows.Count) return;
            if (dgvCustomers.Rows[rowIndex].IsNewRow) return;

            var id = Convert.ToInt32(dgvCustomers.Rows[rowIndex].Cells["ID"].Value);

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (_customerService.DeleteCustomer(id))
                    {
                        foreach (DataRow row in _customersData.Rows)
                        {
                            if (Convert.ToInt32(row["ID"]) == id)
                            {
                                row.Delete();
                                break;
                            }
                        }
                        _customersData.AcceptChanges();

                        // Cập nhật lại danh sách và phân trang
                        LoadCustomers(_currentPage);
                        UpdatePaginationInfo();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa khách hàng.",
                                      "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message,
                                  "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void SetColumnHeaders()
        {
            if (dgvCustomers.Columns.Contains("ID"))
                dgvCustomers.Columns["ID"].HeaderText = "Mã khách hàng";
            if (dgvCustomers.Columns.Contains("fullName"))
                dgvCustomers.Columns["fullName"].HeaderText = "Họ tên";
            if (dgvCustomers.Columns.Contains("phoneNumber"))
                dgvCustomers.Columns["phoneNumber"].HeaderText = "Số điện thoại";
            if (dgvCustomers.Columns.Contains("dateOfBirth"))
                dgvCustomers.Columns["dateOfBirth"].HeaderText = "Ngày sinh";
            if (dgvCustomers.Columns.Contains("userName"))
                dgvCustomers.Columns["userName"].HeaderText = "Tên đăng nhập";
        }
        #endregion

        private void btnSearchh_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim();

                if (string.IsNullOrEmpty(searchText))
                {
                    LoadCustomers();
                    return;
                }

                dgvCustomers.SuspendLayout();
                dgvCustomers.DataSource = null;
                dgvCustomers.Columns.Clear();

                // Sử dụng phương thức search mới
                DataTable data = customerService.SearchCustomers(searchText);

                if (data != null && data.Rows.Count > 0)
                {
                    dgvCustomers.DataSource = data;
                    dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvCustomers.AllowUserToAddRows = false;
                    AddActionColumns();
                    SetColumnHeaders();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phim nào phù hợp.", "Thông báo",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm phim: {ex.Message}", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvCustomers.ResumeLayout();
            }
        }

            private void btnPrevious_Click(object sender, EventArgs e)
            {
                if (_currentPage > 1)
                {
                    _currentPage--;
                    LoadCustomers(_currentPage);
                    UpdatePaginationInfo();
                }
            }

            private void btnNext_Click(object sender, EventArgs e)
            {
                if (_currentPage < _totalPages)
                {
                    _currentPage++;
                    LoadCustomers(_currentPage);
                    UpdatePaginationInfo();
                }
            }

        private void lblPagination_Click(object sender, EventArgs e)
        {

        }

        private void FileExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomers.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Excel Files (*.xlsx)|*.xlsx",
                    FileName = "DanhSachKhachHang.xlsx"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel(dgvCustomers, sfd.FileName);
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
    }
}
