using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.DTOs;
using BusinessLogic.Services;

namespace Presentation.Forms.admin.edit
{
    public partial class frmEditProduct : Form
    {
        private readonly ProductDTO _product;
        public frmEditProduct(ProductDTO product)
        {
            InitializeComponent();
            _product = product;

            this.Load += new System.EventHandler(this.frmEditProduct_Load);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate dữ liệu đầu vào
                string name = txtTenSP.Text.Trim();
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Tên sản phẩm không được để trống.");
                    return;
                }
                if (name.Any(ch => !char.IsLetterOrDigit(ch) && !char.IsWhiteSpace(ch)))
                {
                    MessageBox.Show("Tên sản phẩm không được chứa ký tự đặc biệt.");
                    return;
                }

                if (!int.TryParse(txtSoLuong.Text, out int quantity) || quantity < 0)
                {
                    MessageBox.Show("Số lượng phải là số nguyên không âm.");
                    return;
                }

                if (!int.TryParse(txtSold.Text, out int sold) || sold < 0)
                {
                    MessageBox.Show("Số đã bán phải là số nguyên không âm.");
                    return;
                }

                if (!decimal.TryParse(txtDonGia.Text, out decimal price) || price <= 0)
                {
                    MessageBox.Show("Đơn giá phải là số thực dương.");
                    return;
                }

                // Cập nhật vào DTO
                _product.ProductName = name;
                _product.Quantity = quantity;
                _product.Sold = sold;
                _product.ImportDate = dtpNgayNhap.Value;
                _product.Price = price;

                ProductService productService = new ProductService();
                bool success = productService.UpdateProduct(_product);

                if (success)
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công!");
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi khi cập nhật sản phẩm.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }


        private void frmEditProduct_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin sản phẩm lên form
            txtTenSP.Text = _product.ProductName;
            txtSoLuong.Text = _product.Quantity.ToString();
            txtSold.Text = _product.Sold.ToString();
            dtpNgayNhap.Value = _product.ImportDate;
            txtDonGia.Text = _product.Price.ToString();

            // Hiển thị ảnh nếu có
            if (!string.IsNullOrEmpty(_product.Image))
            {
                try
                {
                    ptProduct.Image = Image.FromFile(_product.Image);
                }
                catch
                {
                    // Xử lý nếu không load được ảnh
                    ptProduct.Image = Properties.Resources.coca;
                }
            }
        }

        #region methods
        public ProductDTO GetEditedProduct()
        {
            return new ProductDTO
            {
                ID = _product.ID,
                ProductName = txtTenSP.Text,
                Quantity = int.Parse(txtSoLuong.Text),
                Sold = int.Parse(txtSold.Text),
                ImportDate = dtpNgayNhap.Value,
                Price = decimal.Parse(txtDonGia.Text),
                Image = _product.Image // Giữ nguyên ảnh hoặc cập nhật nếu có chọn ảnh mới
            };
        }
        #endregion

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileName = Path.GetFileName(openFileDialog.FileName);
                    string destinationFolder = Path.Combine(Application.StartupPath, "Resources", "ProductImages");

                    // Tạo thư mục nếu chưa tồn tại
                    if (!Directory.Exists(destinationFolder))
                    {
                        Directory.CreateDirectory(destinationFolder);
                    }

                    string filePath = Path.Combine(destinationFolder, fileName);

                    // Sao chép ảnh vào thư mục đích (ghi đè nếu đã tồn tại)
                    File.Copy(openFileDialog.FileName, filePath, true);

                    // Cập nhật đường dẫn ảnh
                    _product.Image = filePath;

                    // Hiển thị hình ảnh
                    ptProduct.Image = Image.FromFile(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void txtPrice_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!decimal.TryParse(txtDonGia.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Vui lòng nhập giá hợp lệ (số dương)");
                e.Cancel = true;
            }
        }
    }
}
