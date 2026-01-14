using BusinessLogic.DTOs;
using BusinessLogic.Services;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Presentation.Forms.admin.add
{
    public partial class frmAddMovie : Form
    {
        private readonly MovieService _movieService;

        public frmAddMovie()
        {
            InitializeComponent();
            _movieService = new MovieService();
            ConfigureForm();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Chọn ảnh phim";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                        if (fileInfo.Length > 5 * 1024 * 1024)
                        {
                            MessageBox.Show("Kích thước ảnh vượt quá 5MB. Vui lòng chọn ảnh khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".bmp" };
                        string fileExtension = Path.GetExtension(openFileDialog.FileName).ToLower();
                        if (!allowedExtensions.Contains(fileExtension))
                        {
                            MessageBox.Show("Định dạng ảnh không hợp lệ. Vui lòng chọn ảnh có định dạng jpg, jpeg, png hoặc bmp.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        ptMovie.Image = new Bitmap(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}",
                                      "Lỗi",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ShowValidationError(string message, Control control)
        {
            MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
        }

        private void frmAddMovie_FormClosing(object sender, FormClosingEventArgs e)
        {
            ptMovie.Image?.Dispose();
        }

        private void btnThemMovie_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) return;

                var movieDTO = new MovieDTO
                {
                    Title = txtTenPhim.Text.Trim(),
                    Genre = txtTheLoai.Text.Trim(),
                    Rated = txtDoTuoi.Text.Trim(),
                    Status = txtTrangThai.Text.Trim(),
                    Director = txtDaoDien.Text.Trim(),
                    Country = txtQuocGia.Text.Trim(),
                    RunningTime = txtThoiLuong.Text.Trim(),
                    Description = txtMoTa.Text.Trim(),
                    ImageUrl = ptMovie.Image != null ? SaveImageToFolder() : null
                };

                _movieService.AddMovie(movieDTO);
                MessageBox.Show("Thêm phim thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region methods
        private void ConfigureForm()
        {
            ptMovie.SizeMode = PictureBoxSizeMode.Zoom;
            ptMovie.BorderStyle = BorderStyle.FixedSingle;
            btnThemMovie.Text = "Thêm";
            btnClose.Text = "Hủy";
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenPhim.Text))
            {
                ShowValidationError("Vui lòng nhập tên phim", txtTenPhim);
                return false;
            }
            if (!Regex.IsMatch(txtTenPhim.Text.Trim(), @"^[\p{L}\s]+$"))
            {
                ShowValidationError("Tên phim chỉ được chứa chữ cái và khoảng trắng", txtTenPhim);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTheLoai.Text))
            {
                ShowValidationError("Vui lòng nhập thể loại", txtTheLoai);
                return false;
            }
            if (!Regex.IsMatch(txtTheLoai.Text.Trim(), @"^[\p{L}\s,]+$"))
            {
                ShowValidationError("Thể loại chỉ được chứa chữ cái, dấu phẩy và khoảng trắng", txtTheLoai);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDaoDien.Text))
            {
                ShowValidationError("Vui lòng nhập tên đạo diễn", txtDaoDien);
                return false;
            }
            if (!Regex.IsMatch(txtDaoDien.Text.Trim(), @"^[\p{L}\s]+$"))
            {
                ShowValidationError("Tên đạo diễn chỉ được chứa chữ cái và khoảng trắng", txtDaoDien);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtQuocGia.Text) && !Regex.IsMatch(txtQuocGia.Text.Trim(), @"^[\p{L}\s]+$"))
            {
                ShowValidationError("Quốc gia chỉ được chứa chữ cái và khoảng trắng", txtQuocGia);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtDoTuoi.Text) && !Regex.IsMatch(txtDoTuoi.Text.Trim(), @"^[\p{L}\d\s]+$"))
            {
                ShowValidationError("Độ tuổi không hợp lệ", txtDoTuoi);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtThoiLuong.Text) && !Regex.IsMatch(txtThoiLuong.Text.Trim(), @"^\d{1,3}$"))
            {
                ShowValidationError("Thời lượng phải là số phút hợp lệ", txtThoiLuong);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtTrangThai.Text) && !Regex.IsMatch(txtTrangThai.Text.Trim(), @"^[\p{L}\s]+$"))
            {
                ShowValidationError("Trạng thái chỉ được chứa chữ cái và khoảng trắng", txtTrangThai);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMoTa.Text))
            {
                ShowValidationError("Vui lòng nhập mô tả phim", txtMoTa);
                return false;
            }

            if (ptMovie.Image == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh phim", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            ptMovie.Image.Save(fullPath, System.Drawing.Imaging.ImageFormat.Jpeg);

            return $"Resources/Images/{imageName}";
        }

        #endregion
    }
}
