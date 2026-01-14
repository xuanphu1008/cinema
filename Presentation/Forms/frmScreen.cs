using BusinessLogic.DTOs;
using BusinessLogic.Services;
using Presentation.Forms.admin.add;
using Presentation.Forms.admin.edit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class frmScreen : Form
    {
        private readonly ScreeningService screeningService = new ScreeningService();
        private List<ScreeningDTO> allScreenings;
        private DateTime? selectedDateFilter = null;
        private string selectedRoomFilter = null;

        public frmScreen()
        {
            InitializeComponent();
            dgvScreenings.CellContentClick += dgvScreenings_CellContentClick;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddScreen frm = new frmAddScreen();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadAllScreenings();
            }
        }

        private void frmScreen_Load(object sender, EventArgs e)
        {
            DeleteOldScreenings();
            LoadAllScreenings();
        }

        private void dgvScreenings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvScreenings.Rows.Count) return;

            int screeningID = Convert.ToInt32(dgvScreenings.Rows[e.RowIndex].Cells["ScreeningID"].Value);

            if (dgvScreenings.Columns[e.ColumnIndex].Name == "View")
            {
                using (var frm = new frmViewScreen(screeningID))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadAllScreenings();
                    }
                }
            }
            else if (dgvScreenings.Columns[e.ColumnIndex].Name == "Delete")
            {
                var confirm = MessageBox.Show("Bạn có chắc muốn xóa suất chiếu này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    bool deleted = screeningService.DeleteScreening(screeningID);
                    if (deleted)
                    {
                        MessageBox.Show("Đã xóa suất chiếu.");
                        LoadAllScreenings();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại.");
                    }
                }
            }
        }

        private void btnRoom1_Click(object sender, EventArgs e)
        {
            selectedRoomFilter = "Phòng 1";
            ApplyFilters();
        }

        private void btnRoom2_Click(object sender, EventArgs e)
        {
            selectedRoomFilter = "Phòng 2";
            ApplyFilters();
        }

        private void btnRoom3_Click(object sender, EventArgs e)
        {
            selectedRoomFilter = "Phòng 3";
            ApplyFilters();

        }

        private void btnRoom4_Click(object sender, EventArgs e)
        {
            selectedRoomFilter = "Phòng 4";
            ApplyFilters();
        }

        private void btnRoom5_Click(object sender, EventArgs e)
        {
            selectedRoomFilter = "Phòng 5";
            ApplyFilters();
        }

        private void btnAllRoom_Click(object sender, EventArgs e)
        {
            selectedRoomFilter = null;
            ApplyFilters();
        }

        private void dtpScreeningDate_ValueChanged(object sender, EventArgs e)
        {
            selectedDateFilter = dtpScreeningDate.Value.Date;
            ApplyFilters();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            var filtered = allScreenings.Where(x => x.MovieTitle.ToLower().Contains(keyword)).ToList();
            LoadScreeningsToGrid(filtered);
        }

        #region methods 
        private void DeleteOldScreenings()
        {
            DateTime today = DateTime.Today;
            screeningService.DeleteOldScreenings(today);
        }

        private void LoadAllScreenings()
        {
            DataTable dt = screeningService.GetAllScreenings();
            allScreenings = new List<ScreeningDTO>();

            foreach (DataRow row in dt.Rows)
            {
                allScreenings.Add(new ScreeningDTO
                {
                    ScreeningID = row["ScreeningID"] != DBNull.Value ? Convert.ToInt32(row["ScreeningID"]) : 0,
                    MovieID = row["MovieID"] != DBNull.Value ? Convert.ToInt32(row["MovieID"]) : 0,
                    MovieTitle = row["Title"] != DBNull.Value ? row["Title"].ToString() : "",
                    Genre = row["Genre"] != DBNull.Value ? row["Genre"].ToString() : "",
                    Duration = row["Duration"] != DBNull.Value ? Convert.ToInt32(row["Duration"]) : 0,
                    ScreeningDate = row["ScreeningDate"] != DBNull.Value ? Convert.ToDateTime(row["ScreeningDate"]) : DateTime.MinValue,
                    ScreeningTime = row["ScreeningTime"] != DBNull.Value ? (TimeSpan)row["ScreeningTime"] : TimeSpan.Zero,
                    Room = row["Room"] != DBNull.Value ? row["Room"].ToString() : ""
                });
            }

            ApplyFilters();
        }

        private void LoadScreeningsToGrid(List<ScreeningDTO> data)
        {
            dgvScreenings.Columns.Clear();
            dgvScreenings.Rows.Clear();

            dgvScreenings.Columns.Add("ScreeningID", "ID");
            dgvScreenings.Columns.Add("MovieTitle", "Tên phim");
            dgvScreenings.Columns.Add("Genre", "Thể loại");
            dgvScreenings.Columns.Add("Duration", "Thời lượng");
            dgvScreenings.Columns.Add("ScreeningTime", "Giờ chiếu");
            dgvScreenings.Columns.Add("Room", "Phòng");
            dgvScreenings.Columns.Add("ScreeningDate", "Ngày chiếu");

            foreach (var item in data)
            {
                dgvScreenings.Rows.Add(
                    item.ScreeningID,
                    item.MovieTitle,
                    item.Genre,
                    $"{item.Duration} phút",
                    item.ScreeningTime.ToString(@"hh\:mm"),
                    item.Room,
                    item.ScreeningDate.ToString("dd/MM/yyyy")
                );
            }

            AddActionColumns();
        }

        private void AddActionColumns()
        {
            if (dgvScreenings.Columns.Contains("Edit") || dgvScreenings.Columns.Contains("Delete"))
                return;

            var editImage = Properties.Resources.edit_image;
            if (editImage != null)
            {
                DataGridViewImageColumn editColumn = new DataGridViewImageColumn
                {
                    Name = "View",
                    HeaderText = "Chi tiết",
                    Image = (Image)editImage.GetThumbnailImage(20, 20, null, IntPtr.Zero),
                    Width = 50
                };
                dgvScreenings.Columns.Add(editColumn);
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
                dgvScreenings.Columns.Add(deleteColumn);
            }
        }

        private void ApplyFilters()
        {
            var filtered = allScreenings.AsEnumerable();

            if (selectedDateFilter != null)
                filtered = filtered.Where(x => x.ScreeningDate.Date == selectedDateFilter.Value.Date);

            if (!string.IsNullOrEmpty(selectedRoomFilter))
                filtered = filtered.Where(x => x.Room.Equals(selectedRoomFilter, StringComparison.OrdinalIgnoreCase));

            LoadScreeningsToGrid(filtered.ToList());
        }
        #endregion

    }
}
