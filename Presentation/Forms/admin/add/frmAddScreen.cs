using BusinessLogic.DTOs;
using BusinessLogic.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace Presentation.Forms.admin.add
{
    public partial class frmAddScreen : Form
    {
        private readonly ScreeningService _screeningService;
        private int? screeningID;

        public frmAddScreen(int? screeningID = null)
        {
            InitializeComponent();
            _screeningService = new ScreeningService();
            this.screeningID = screeningID;
        }

        private void frmAddScreen_Load(object sender, EventArgs e)
        {
            LoadMovies();
            LoadRooms();
            dtpSceeningDate.Value = DateTime.Today;
            dtpScreeningTime.Format = DateTimePickerFormat.Time;
            dtpScreeningTime.ShowUpDown = true;
        }

        private void LoadMovies()
        {
            DataTable movies = _screeningService.GetAllMovies();
            cbMovieName.DataSource = movies;
            cbMovieName.DisplayMember = "title";    
            cbMovieName.ValueMember = "movie_id";
        }

        private void LoadRooms()
        {
            cbRoom.Items.Clear();
            for (int i = 1; i <= 5; i++)
            {
                cbRoom.Items.Add("Phòng " + i);
            }

            cbRoom.SelectedIndex = 0;
        }

        private void btnAddSceen_Click(object sender, EventArgs e)
        {
            if (cbMovieName.SelectedValue == null || string.IsNullOrEmpty(cbRoom.Text))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpSceeningDate.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Ngày chiếu không được nhỏ hơn ngày hôm nay. Vui lòng chọn lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ScreeningDTO screening = new ScreeningDTO
            {
                MovieID = Convert.ToInt32(cbMovieName.SelectedValue),
                ScreeningDate = dtpSceeningDate.Value.Date,
                ScreeningTime = dtpScreeningTime.Value.TimeOfDay,
                Room = cbRoom.Text
            };

            bool result = _screeningService.AddScreening(screening);

            if (result)
            {
                MessageBox.Show("Thêm suất chiếu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
