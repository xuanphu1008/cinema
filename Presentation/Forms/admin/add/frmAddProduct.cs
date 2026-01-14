using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.DTOs;
using BusinessLogic.Services;

namespace Presentation.Forms.admin.add
{
    public partial class frmAddProduct : Form
    {
        private readonly ProductService _productService;

        public frmAddProduct()
        {
            InitializeComponent();
            _productService = new ProductService();
            ConfigureForm();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) return;

                var productDTO = new ProductDTO
                {
                    ProductName = txtTenSP.Text.Trim(),
                    Quantity = int.Parse(txtSoLuong.Text.Trim()),
                    Sold = int.Parse(txtSold.Text.Trim()),
                    ImportDate = dtpNgayNhap.Value,
                    Price = decimal.Parse(txtDonGia.Text.Trim()),
                    Image = ptProduct.Image != null ? SaveImageToFolder() : null
                };

                _productService.AddProduct(productDTO);
                MessageBox.Show("Thêm sản phẩm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region methods

        private void ConfigureForm()
        {
            ptProduct.SizeMode = PictureBoxSizeMode.Zoom;
            ptProduct.BorderStyle = BorderStyle.FixedSingle;
            btnAddProduct.Text = "Thêm";
            btnClose.Text = "Hủy";
        }

        private bool ValidateInput()
        {
            // Tên sản phẩm
            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                ShowValidationError("Vui lòng nhập tên sản phẩm.", txtTenSP);
                return false;
            }
            else if (!Regex.IsMatch(txtTenSP.Text.Trim(), @"^[\p{L}0-9\s]+$"))
            {
                ShowValidationError("Tên sản phẩm chỉ được chứa chữ cái, số và khoảng trắng.", txtTenSP);
                return false;
            }

            // Số lượng
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                ShowValidationError("Vui lòng nhập số lượng.", txtSoLuong);
                return false;
            }
            else if (!int.TryParse(txtSoLuong.Text.Trim(), out int quantity) || quantity <= 0)
            {
                ShowValidationError("Số lượng phải là số nguyên dương.", txtSoLuong);
                return false;
            }

            // Đã bán (nếu có TextBox Sold)
            if (!string.IsNullOrWhiteSpace(txtSold.Text) && (!int.TryParse(txtSold.Text.Trim(), out int sold) || sold < 0))
            {
                ShowValidationError("Số lượng đã bán phải là số nguyên không âm.", txtSold);
                return false;
            }

            // Đơn giá
            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                ShowValidationError("Vui lòng nhập đơn giá.", txtDonGia);
                return false;
            }
            else if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal price) || price <= 0)
            {
                ShowValidationError("Đơn giá phải là số thực dương.", txtDonGia);
                return false;
            }

            // Ngày nhập
            if (dtpNgayNhap.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Ngày nhập không được lớn hơn ngày hôm nay.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayNhap.Focus();
                return false;
            }

            // Ảnh
            if (ptProduct.Image == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private string SaveImageToFolder()
        {
            string resourcesPath = Path.Combine(Application.StartupPath, "Resources", "Images");
            Directory.CreateDirectory(resourcesPath);

            string imageName = $"{Guid.NewGuid()}.jpg";
            string fullPath = Path.Combine(resourcesPath, imageName);

            ptProduct.Image.Save(fullPath, System.Drawing.Imaging.ImageFormat.Jpeg);

            return $"Resources/Images/{imageName}";
        }

        private void ShowValidationError(string message, Control control)
        {
            MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
        }

        #endregion

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Chọn ảnh sản phẩm";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ptProduct.Image = new Bitmap(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void frmAddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            ptProduct.Image?.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
