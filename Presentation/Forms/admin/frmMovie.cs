using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Services;
using BusinessLogic.DTOs;
using Presentation.Forms.admin.add;
using Presentation.Forms.admin.edit;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

namespace Presentation.Forms.admin
{
    public partial class frmMovie : Form
    {
        private readonly MovieService movieService = new MovieService();
        public frmMovie()
        {
            InitializeComponent();
            LoadMovies();
            dgvManagerFilm.CellContentClick += dgvManagerFilm_CellContentClick;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmAddMovie addMovieForm = new frmAddMovie())
                {
                    if (addMovieForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadMovies();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm phim: {ex.Message}", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim();

                if (string.IsNullOrEmpty(searchText))
                {
                    LoadMovies();
                    return;
                }

                dgvManagerFilm.SuspendLayout();
                dgvManagerFilm.DataSource = null;
                dgvManagerFilm.Columns.Clear();

                // Sử dụng phương thức search mới
                DataTable data = movieService.SearchMovies(searchText);

                if (data != null && data.Rows.Count > 0)
                {
                    dgvManagerFilm.DataSource = data;
                    dgvManagerFilm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvManagerFilm.AllowUserToAddRows = false;
                    AddActionColumns();
                    SetColumnHeaders();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phim nào phù hợp.", "Thông báo",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMovies();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm phim: {ex.Message}", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvManagerFilm.ResumeLayout();
            }
        }

        private void dgvManagerFilm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra index hợp lệ
            if (e.RowIndex < 0 || e.ColumnIndex < 0 ||
                e.RowIndex >= dgvManagerFilm.Rows.Count ||
                dgvManagerFilm.Rows[e.RowIndex].IsNewRow)
                return;

            // Kiểm tra nếu cột "movie_id" tồn tại
            if (!dgvManagerFilm.Columns.Contains("movie_id"))
            {
                MessageBox.Show("Không tìm thấy cột 'movie_id' trong DataGridView.", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            object movieIdObj = dgvManagerFilm.Rows[e.RowIndex].Cells["movie_id"].Value;
            if (movieIdObj == null || string.IsNullOrEmpty(movieIdObj.ToString()))
            {
                MessageBox.Show("Không thể lấy ID phim.", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string movieId = movieIdObj.ToString();

            // Kiểm tra tên cột trước khi xử lý
            if (e.ColumnIndex >= 0 && e.ColumnIndex < dgvManagerFilm.Columns.Count)
            {
                string columnName = dgvManagerFilm.Columns[e.ColumnIndex].Name;

                if (columnName == "Edit")
                {
                    EditMovie(movieId);
                }
                else if (columnName == "Delete")
                {
                    DeleteMovie(movieId);
                }
            }
        }

        private void dgvManagerFilm_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra index hợp lệ
            if (e.RowIndex < 0 || e.RowIndex >= dgvManagerFilm.Rows.Count)
                return;

            if (dgvManagerFilm.Rows[e.RowIndex].IsNewRow)
                return;

            // Kiểm tra tên cột hợp lệ
            if (e.ColumnIndex >= 0 && e.ColumnIndex < dgvManagerFilm.Columns.Count)
            {
                string columnName = dgvManagerFilm.Columns[e.ColumnIndex].Name;

                if (columnName == "Edit" || columnName == "Delete")
                {
                    e.Value = null;
                    e.FormattingApplied = true;
                }
            }
        }

        private void MenuListControl_CloseParentForm(object sender, EventArgs e)
        {
            this.Close(); // Đóng Form cha
        }

        #region methods
        private void LoadMovies()
        {
            try
            {
                dgvManagerFilm.SuspendLayout();

                // Lấy toàn bộ dữ liệu từ database
                movieData = movieService.GetAllMovies();

                if (movieData != null && movieData.Rows.Count > 0)
                {
                    totalPage = (int)Math.Ceiling(movieData.Rows.Count / (double)pageSize);
                    LoadPage(currentPage);
                }
                else
                {
                    dgvManagerFilm.DataSource = null;
                    dgvManagerFilm.Columns.Clear();
                    MessageBox.Show("Không có dữ liệu phim.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvManagerFilm.ResumeLayout();
            }
        }

        private void LoadPage(int page)
        {
            try
            {
                int startIndex = (page - 1) * pageSize;
                int endIndex = Math.Min(startIndex + pageSize, movieData.Rows.Count);

                // Lấy dữ liệu của trang hiện tại
                DataTable pageData = movieData.Clone(); // Tạo một bảng rỗng với cấu trúc giống dữ liệu gốc
                for (int i = startIndex; i < endIndex; i++)
                {
                    pageData.ImportRow(movieData.Rows[i]);
                }

                dgvManagerFilm.DataSource = pageData;
                dgvManagerFilm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvManagerFilm.AllowUserToAddRows = false;

                AddActionColumns();
                SetColumnHeaders();

                UpdatePaginationControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị trang: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePaginationControls()
        {
            lblPagination.Text = $"Trang {currentPage}/{totalPage}";
            btnPrevious.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPage;
            //btnFirst.Enabled = currentPage > 1;
            //btnLast.Enabled = currentPage < totalPage;
        }

        private void EditMovie(string movieId)
        {
            MovieDTO movieDTO = new MovieDTO();
            DialogResult rs = MessageBox.Show($"Chỉnh sửa phim có ID: {movieId}", "Thông báo", MessageBoxButtons.YesNo);

            if (rs == DialogResult.Yes)
            {
                // Mở Form chỉnh sửa phim ở đây
                frmEditMovie frmEditMovie = new frmEditMovie(movieDTO);
                this.Hide();
                if (dgvManagerFilm.CurrentRow != null)
                {
                    MovieDTO selectedMovie = new MovieDTO
                    {
                        Movie_ID = Convert.ToInt32(dgvManagerFilm.CurrentRow.Cells["movie_id"].Value),
                        Title = dgvManagerFilm.CurrentRow.Cells["Title"].Value.ToString(),
                        Genre = dgvManagerFilm.CurrentRow.Cells["Genre"].Value.ToString(),
                        Rated = dgvManagerFilm.CurrentRow.Cells["Rated"].Value.ToString(),
                        Director = dgvManagerFilm.CurrentRow.Cells["Director"].Value.ToString(),
                        Country = dgvManagerFilm.CurrentRow.Cells["Country"].Value.ToString(),
                        RunningTime = dgvManagerFilm.CurrentRow.Cells["RunningTime"].Value.ToString(),
                        Status = dgvManagerFilm.CurrentRow.Cells["Status"].Value.ToString(),
                        Description = dgvManagerFilm.CurrentRow.Cells["Description"].Value.ToString()
                    };
                    frmEditMovie toForm = new frmEditMovie(selectedMovie);
                    if (toForm.ShowDialog() == DialogResult.Yes)
                    {
                        MovieDTO updatedMovie = toForm.GetEditedMovie();
                        MovieService movieService = new MovieService();
                        bool success = movieService.UpdateMovie(updatedMovie);

                        // Cập nhật lại giao diện sau khi sửa thành công
                        if (success)
                        {
                            MessageBox.Show("Phim đã được cập nhật.");
                            // Load lại dữ liệu phim (ví dụ: gọi lại phương thức LoadMovies())
                            toForm.Close();
                            LoadMovies();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật phim thất bại.");
                        }
                    }
                }
            }
        }

        private void DeleteMovie(string movieId)
        {
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa phim này?", "Xác nhận xóa",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    bool isDeleted = movieService.DeleteMovie(movieId);
                    if (isDeleted)
                    {
                        MessageBox.Show("Xóa phim thành công!", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadMovies();
                    }
                    else
                    {
                        MessageBox.Show("Xóa phim thất bại. Vui lòng thử lại.", "Lỗi",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa phim: {ex.Message}", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void SetColumnHeaders()
        {
            if (dgvManagerFilm.Columns.Contains("Movie_ID"))
                dgvManagerFilm.Columns["Movie_ID"].HeaderText = "Mã phim";
            if (dgvManagerFilm.Columns.Contains("Title"))
                dgvManagerFilm.Columns["Title"].HeaderText = "Tên phim";
            if (dgvManagerFilm.Columns.Contains("Genre"))
                dgvManagerFilm.Columns["Genre"].HeaderText = "Thể loại";
            if (dgvManagerFilm.Columns.Contains("Rated"))
                dgvManagerFilm.Columns["Rated"].HeaderText = "Độ tuổi";
            if (dgvManagerFilm.Columns.Contains("Country"))
                dgvManagerFilm.Columns["Country"].HeaderText = "Quốc gia";
            if (dgvManagerFilm.Columns.Contains("Status"))
                dgvManagerFilm.Columns["Status"].HeaderText = "Trạng thái";
            if (dgvManagerFilm.Columns.Contains("Director"))
                dgvManagerFilm.Columns["Director"].HeaderText = "Đạo diễn";
            if (dgvManagerFilm.Columns.Contains("RunningTime"))
                dgvManagerFilm.Columns["RunningTime"].HeaderText = "Thời lượng";
            if (dgvManagerFilm.Columns.Contains("Description"))
                dgvManagerFilm.Columns["Description"].HeaderText = "Mô tả";
        }

        private void AddActionColumns()
        {
            // Kiểm tra nếu đã có các cột action thì không thêm lại
            if (dgvManagerFilm.Columns.Contains("Edit") || dgvManagerFilm.Columns.Contains("Delete"))
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
                dgvManagerFilm.Columns.Add(editColumn);
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
                dgvManagerFilm.Columns.Add(deleteColumn);
            }
        }
        #endregion

        #region Pagination Variables
        private int pageSize = 10; // Số lượng dòng hiển thị mỗi trang
        private int currentPage = 1; // Trang hiện tại
        private int totalPage = 1; // Tổng số trang
        private DataTable movieData = new DataTable(); // Lưu dữ liệu toàn bộ phim
        #endregion
        private void btnAddd_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmAddMovie addMovieForm = new frmAddMovie())
                {
                    if (addMovieForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadMovies();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm phim: {ex.Message}", "Lỗi",
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
                    LoadMovies();
                    return;
                }

                dgvManagerFilm.SuspendLayout();
                dgvManagerFilm.DataSource = null;
                dgvManagerFilm.Columns.Clear();

                // Sử dụng phương thức search mới
                DataTable data = movieService.SearchMovies(searchText);

                if (data != null && data.Rows.Count > 0)
                {
                    dgvManagerFilm.DataSource = data;
                    dgvManagerFilm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvManagerFilm.AllowUserToAddRows = false;
                    AddActionColumns();
                    SetColumnHeaders();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phim nào phù hợp.", "Thông báo",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMovies();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm phim: {ex.Message}", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvManagerFilm.ResumeLayout();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadPage(currentPage);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPage)
            {
                currentPage++;
                LoadPage(currentPage);
            }
        }

        private void FileExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvManagerFilm.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Excel Files (*.xlsx)|*.xlsx",
                    FileName = "DanhSachPhim.xlsx"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel(dgvManagerFilm, sfd.FileName);
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
    }
}
