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

namespace Presentation.Forms.admin.edit
{
    public partial class frmViewScreen : Form
    {
        private readonly int screeningID;
        private readonly ScreeningService screeningService;
        public frmViewScreen(int screeningID)
        {
            InitializeComponent();
            this.screeningID = screeningID;
            screeningService = new ScreeningService();
        }

        private void frmViewScreen_Load(object sender, EventArgs e)
        {
            LoadScreeningDetails();
            GenerateSeats();
        }

        private void LoadScreeningDetails()
        {
            try
            {
                ScreeningDTO screening = screeningService.GetScreeningById(screeningID);

                if (screening != null)
                {
                    lbMovieName.Text = screening.MovieTitle;
                    lbDate.Text = screening.ScreeningDate.ToString("dd/MM/yyyy");
                    lbTime.Text = screening.ScreeningTime.ToString(@"hh\:mm");
                    lbRoom.Text = screening.Room;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin suất chiếu.");
                    this.Close(); // KHÔNG đặt DialogResult ở đây
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết suất chiếu: " + ex.Message);
                this.Close(); // KHÔNG đặt DialogResult ở đây
            }
        }

        private void GenerateSeats(int rows = 5, int cols = 10)
        {
            panelSeat.Controls.Clear();
            int seatWidth = 45;
            int seatHeight = 45;
            int margin = 5;

            int totalSeats = 0;

            for (int row = 0; row < rows; row++)
            {
                char rowLabel = (char)('A' + row);

                for (int col = 1; col <= cols; col++)
                {
                    string seatName = rowLabel + col.ToString();

                    Button seatButton = new Button
                    {
                        Text = seatName,
                        Width = seatWidth,
                        Height = seatHeight,
                        BackColor = Color.LightGray,
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Segoe UI", 9),
                        Margin = new Padding(margin),
                        Tag = seatName // dùng để lưu tên ghế
                    };

                    seatButton.FlatAppearance.BorderSize = 1;

                    // Thêm sự kiện click
                    seatButton.Click += SeatButton_Click;

                    panelSeat.Controls.Add(seatButton);
                    totalSeats++;
                }
            }

            lbSeat.Text = $"Tổng số ghế: {totalSeats}";
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            if (sender is Button seatButton)
            {
                string seatName = seatButton.Tag.ToString();
                DialogResult result = MessageBox.Show(
                    $"Bạn có muốn đặt ghế {seatName} không?",
                    "Đặt ghế",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    seatButton.BackColor = Color.Red; // Màu ghế đã đặt
                }
                else if (result == DialogResult.No)
                {
                    seatButton.BackColor = Color.LightGray; // Màu ghế chưa đặt
                }
                // Cancel thì không làm gì
            }
        }


    }
}
