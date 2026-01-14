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
    public partial class frmProduct : Form
    {
        private readonly ProductService productService = new ProductService();
        public frmProduct()
        {
            InitializeComponent();
            LoadProducts();
            dgvProduct.CellContentClick += dgvProduct_CellContentClick;
            SetColumnHeaders();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmAddProduct addProductForm = new frmAddProduct())
                {
                    if (addProductForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadProducts();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sản phẩm: {ex.Message}", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MenuListControl_CloseParentForm(object sender, EventArgs e)
        {
            this.Close(); // Đóng Form cha
        }
        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra index hợp lệ
            if (e.RowIndex < 0 || e.ColumnIndex < 0 ||
                e.RowIndex >= dgvProduct.Rows.Count ||
                dgvProduct.Rows[e.RowIndex].IsNewRow)
                return;

      
            if (!dgvProduct.Columns.Contains("ID"))
            {
                MessageBox.Show("Không tìm thấy cột 'ID' trong DataGridView.", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            object productIdObj = dgvProduct.Rows[e.RowIndex].Cells["ID"].Value;
            if (productIdObj == null || string.IsNullOrEmpty(productIdObj.ToString()))
            {
                MessageBox.Show("Không thể lấy ID sản phẩm.", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ID = productIdObj.ToString();

            // Kiểm tra tên cột trước khi xử lý
            if (e.ColumnIndex >= 0 && e.ColumnIndex < dgvProduct.Columns.Count)
            {
                string columnName = dgvProduct.Columns[e.ColumnIndex].Name;

                if (columnName == "Edit")
                {
                    EditProduct(ID);
                }
                else if (columnName == "Delete")
                {
                    DeleteProduct(ID);
                }
            }
        }

        private void dgvProduct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra index hợp lệ
            if (e.RowIndex < 0 || e.RowIndex >= dgvProduct.Rows.Count)
                return;

            if (dgvProduct.Rows[e.RowIndex].IsNewRow)
                return;

            // Kiểm tra tên cột hợp lệ
            if (e.ColumnIndex >= 0 && e.ColumnIndex < dgvProduct.Columns.Count)
            {
                string columnName = dgvProduct.Columns[e.ColumnIndex].Name;

                if (columnName == "Edit" || columnName == "Delete")
                {
                    e.Value = null;
                    e.FormattingApplied = true;
                }
            }
        }

        #region methods
        private void EditProduct(string ID)
        {
            DialogResult rs = MessageBox.Show($"Chỉnh sửa sản phẩm có ID: {ID}", "Thông báo", MessageBoxButtons.YesNo);

            if (rs == DialogResult.Yes)
            {
                if (dgvProduct.CurrentRow != null)
                {
                    // Lấy thông tin cơ bản từ DataGridView
                    ProductDTO selectedProduct = new ProductDTO
                    {
                        ID = Convert.ToInt32(dgvProduct.CurrentRow.Cells["ID"].Value),
                        ProductName = dgvProduct.CurrentRow.Cells["ProductName"].Value.ToString(),
                        Quantity = Convert.ToInt32(dgvProduct.CurrentRow.Cells["Quantity"].Value),
                        Sold = Convert.ToInt32(dgvProduct.CurrentRow.Cells["Sold"].Value),
                        ImportDate = Convert.ToDateTime(dgvProduct.CurrentRow.Cells["ImportDate"].Value),
                        Price = Convert.ToDecimal(dgvProduct.CurrentRow.Cells["Price"].Value),
                        FormattedPrice = Convert.ToDecimal(dgvProduct.CurrentRow.Cells["Price"].Value).ToString("N0") + " đ",

                        // Thêm xử lý hình ảnh (nếu có cột Image trong DataGridView)
                        Image = dgvProduct.Columns.Contains("Image")
                               ? dgvProduct.CurrentRow.Cells["Image"]?.Value?.ToString()
                               : null
                    };

                    // Nếu không có cột Image, lấy từ service
                    if (selectedProduct.Image == null)
                    {
                        var fullProductInfo = productService.GetProductById(selectedProduct.ID);
                        if (fullProductInfo != null)
                        {
                            selectedProduct.Image = fullProductInfo.Image;
                        }
                    }

                    frmEditProduct editForm = new frmEditProduct(selectedProduct);
                    this.Hide();

                    if (editForm.ShowDialog() == DialogResult.Yes)
                    {
                        ProductDTO updatedProduct = editForm.GetEditedProduct();
                        bool success = productService.UpdateProduct(updatedProduct);

                        if (success)
                        {
                            MessageBox.Show("Sản phẩm đã được cập nhật.");
                            editForm.Close();
                            LoadProducts();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật sản phẩm thất bại.");
                        }
                    }
                    else
                    {
                        this.Show();
                    }
                }
            }
        }


        private void DeleteProduct(string ID)
        {
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm?", "Xác nhận xóa",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    bool isDeleted = productService.DeleteProduct(ID);
                    if (isDeleted)
                    {
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProducts();
                    }
                    else
                    {
                        MessageBox.Show("Xóa sản phẩm thất bại. Vui lòng thử lại.", "Lỗi",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa sản phẩm: {ex.Message}", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadProducts()
        {
            try
            {
                dgvProduct.SuspendLayout();
                var currentDataSource = dgvProduct.DataSource; // Lưu lại DataSource hiện tại

                // Thay vì xóa toàn bộ columns, chỉ cần cập nhật DataSource
                DataTable data = productService.GetAllProducts();
                dgvProduct.DataSource = data;

                if (data != null && data.Rows.Count > 0)
                {
                    dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvProduct.AllowUserToAddRows = false;

                    // Kiểm tra và thêm cột action nếu chưa có
                    if (!dgvProduct.Columns.Contains("Edit") || !dgvProduct.Columns.Contains("Delete"))
                    {
                        AddActionColumns();
                    }

                    SetColumnHeaders(); // Gọi lại sau khi cập nhật DataSource
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvProduct.ResumeLayout();
            }
        }

        private void AddActionColumns()
        {

            // Kiểm tra nếu đã có các cột action thì không thêm lại
            if (dgvProduct.Columns.Contains("Edit") || dgvProduct.Columns.Contains("Delete"))
                return;

            // Thêm cột Edit với kiểm tra null
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
                dgvProduct.Columns.Add(editColumn);
            }

            // Thêm cột Delete với kiểm tra null
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
                dgvProduct.Columns.Add(deleteColumn);
            }
        }

        private void SetColumnHeaders()
        {
            if (dgvProduct.Columns.Contains("ID"))
                dgvProduct.Columns["ID"].HeaderText = "Mã sản phẩm";
            if (dgvProduct.Columns.Contains("productName"))
                dgvProduct.Columns["productName"].HeaderText = "Tên sản phẩm";
            if (dgvProduct.Columns.Contains("quantity"))
                dgvProduct.Columns["quantity"].HeaderText = "Tồn kho";
            if (dgvProduct.Columns.Contains("sold"))
                dgvProduct.Columns["sold"].HeaderText = "Đã bán";
            if (dgvProduct.Columns.Contains("importDate"))
                dgvProduct.Columns["importDate"].HeaderText = "Ngày nhập";
            if (dgvProduct.Columns.Contains("price"))
            {
                dgvProduct.Columns["price"].HeaderText = "Giá";
                // Format as VND currency
                dgvProduct.Columns["price"].DefaultCellStyle.Format = "N0";
                dgvProduct.Columns["price"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("vi-VN");
            }
        }

        #endregion

        private void btnAddd_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmAddProduct addProductForm = new frmAddProduct())
                {
                    if (addProductForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadProducts();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sản phẩm: {ex.Message}", "Lỗi",
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
                    LoadProducts();
                    return;
                }

                dgvProduct.SuspendLayout();
                DataTable data = productService.SearchProducts(searchText);
                dgvProduct.DataSource = data; // Chỉ cần gán DataSource, không xóa Columns

                if (data != null && data.Rows.Count > 0)
                {
                    dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvProduct.AllowUserToAddRows = false;

                    if (!dgvProduct.Columns.Contains("Edit") || !dgvProduct.Columns.Contains("Delete"))
                    {
                        AddActionColumns();
                    }

                    SetColumnHeaders(); // Gọi lại sau khi tìm kiếm
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm nào phù hợp.", "Thông báo",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm sản phẩm: {ex.Message}", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvProduct.ResumeLayout();
            }
        }

        private void FileExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProduct.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Excel Files (*.xlsx)|*.xlsx",
                    FileName = "DanhSachSanPham.xlsx"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel(dgvProduct, sfd.FileName);
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
