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
    public partial class frmEditMovie : Form
    {
        private readonly MovieDTO _movie = new MovieDTO();
        public frmEditMovie(MovieDTO movie)
        {
            InitializeComponent();
            _movie = movie;

            this.Load += new System.EventHandler(this.frmEditMovie_Load);
        }

        private void frmEditMovie_Load(object sender, EventArgs e)
        {
            txtEditTenPhim.Text = _movie.Title;
            txtEditTheLoai.Text = _movie.Genre;    
            txtEditDaoDien.Text = _movie.Director;
            txtEditQuocGia.Text = _movie.Country;
            txtEditThoiLuong.Text = _movie.RunningTime;
            txtEditDoTuoi.Text = _movie.Rated;
            txtEditTrangThai.Text = _movie.Status;
            txtEditMoTa.Text = _movie.Description;
            // = _movie.ImageUrl;
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(txtEditTenPhim.Text))
                {
                    MessageBox.Show("Tên phim không được để trống.");
                    txtEditTenPhim.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEditTheLoai.Text))
                {
                    MessageBox.Show("Thể loại không được để trống.");
                    txtEditTheLoai.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEditDaoDien.Text) || !txtEditDaoDien.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("Đạo diễn chỉ được chứa chữ cái và khoảng trắng.");
                    txtEditDaoDien.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEditQuocGia.Text) || !txtEditQuocGia.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("Quốc gia chỉ được chứa chữ cái và khoảng trắng.");
                    txtEditQuocGia.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEditThoiLuong.Text) || !int.TryParse(txtEditThoiLuong.Text, out int thoiLuong) || thoiLuong <= 0)
                {
                    MessageBox.Show("Thời lượng phải là số nguyên dương.");
                    txtEditThoiLuong.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEditDoTuoi.Text) || !int.TryParse(txtEditDoTuoi.Text, out int tuoi) || tuoi < 0)
                {
                    MessageBox.Show("Độ tuổi phải là số nguyên không âm.");
                    txtEditDoTuoi.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEditTrangThai.Text))
                {
                    MessageBox.Show("Trạng thái không được để trống.");
                    txtEditTrangThai.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEditMoTa.Text))
                {
                    MessageBox.Show("Mô tả không được để trống.");
                    txtEditMoTa.Focus();
                    return;
                }

                if (txtEditMoTa.Text.Length > 500)
                {
                    MessageBox.Show("Mô tả không được vượt quá 500 ký tự.");
                    txtEditMoTa.Focus();
                    return;
                }

                // Nếu hợp lệ thì cập nhật DTO
                _movie.Title = txtEditTenPhim.Text.Trim();
                _movie.Genre = txtEditTheLoai.Text.Trim();
                _movie.Rated = txtEditDoTuoi.Text.Trim();
                _movie.Status = txtEditTrangThai.Text.Trim();
                _movie.Director = txtEditDaoDien.Text.Trim();
                _movie.Country = txtEditQuocGia.Text.Trim();
                _movie.RunningTime = txtEditThoiLuong.Text.Trim();
                _movie.Description = txtEditMoTa.Text.Trim();

                MovieService movieService = new MovieService();
                bool success = movieService.UpdateMovie(_movie);

                if (success)
                {
                    MessageBox.Show("Cập nhật phim thành công!");
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi khi cập nhật phim.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        #region methods
        public MovieDTO GetEditedMovie()
        {
            // Lấy lại dữ liệu sau khi sửa
            return new MovieDTO
            {
                Movie_ID = _movie.Movie_ID,
                Title = txtEditTenPhim.Text,
                Genre = txtEditTheLoai.Text,
                Director = txtEditDaoDien.Text,
                Country = txtEditQuocGia.Text,
                RunningTime = txtEditThoiLuong.Text,
                Rated = txtEditDoTuoi.Text,
                Status = txtEditTrangThai.Text,
                Description = txtEditMoTa.Text
            };
        }

        #endregion

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            // Tạo OpenFileDialog để người dùng chọn ảnh
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(openFileDialog.FileName);
                string filePath = Path.Combine(@"D:\Workspace\BT C#\BTL\Presentation\Resource\image", fileName); // Lưu ảnh vào thư mục "Images"

                // Sao chép ảnh vào thư mục "Images"
                File.Copy(openFileDialog.FileName, filePath, true);

                // Cập nhật thuộc tính ImageUrl của MovieDTO
                _movie.ImageUrl = filePath;

                // Hiển thị hình ảnh trong PictureBox (nếu có)
                ptEditMovie.Image = Image.FromFile(filePath);
            }
        }
    }
}
