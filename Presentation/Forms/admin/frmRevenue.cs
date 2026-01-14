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
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Markup;
using Excel = Microsoft.Office.Interop.Excel;

namespace Presentation.Forms.admin
{
    public partial class frmRevenue : Form
    {
        private int currentPageMovie = 1;
        private int currentPageProduct = 1;
        private int pageSize = 10;
        private int totalPagesMovie = 1;
        private int totalPagesProduct = 1;

        private readonly RevenueService revenueService = new RevenueService();
        public frmRevenue()
        {
            InitializeComponent();
            LoadData();
            RefreshChart();
            LoadPieChart();
            cbxMovie.SelectedIndexChanged += CbxMovie_SelectedIndexChanged;
        }
        private void MenuListControl_CloseParentForm(object sender, EventArgs e)
        {
            this.Close(); // Đóng Form cha
        }
        private void frmRevenue_Load(object sender, EventArgs e)
        {
            LoadComboBoxOptions();
            cbxMovie.SelectedIndexChanged += (s, ev) => FilterData();
            cbxDate.SelectedIndexChanged += (s, ev) => FilterData();
        }

        private void CbxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDate.SelectedValue is int selectedDays && selectedDays > 0) // Kiểm tra giá trị hợp lệ
            {
                DateTime startDate = DateTime.Now.AddDays(-selectedDays); // Ngày bắt đầu
                DateTime endDate = DateTime.Now; // Ngày kết thúc là hiện tại

                // Gọi hàm lấy dữ liệu theo khoảng thời gian
                DataTable data = revenueService.GetRevenueByRange(startDate, endDate);

                if (data != null && data.Rows.Count > 0)
                {
                    dgvRMovie.DataSource = data; // Hiển thị dữ liệu trong DataGridView
                    RefreshChartByDate(data);   // Làm mới biểu đồ
                }
                else
                {
                    dgvRMovie.DataSource = null; // Xóa dữ liệu nếu không có kết quả
                }
            }
        }


        #region methods
        private void LoadData()
        {
            try
            {
                dgvRMovie.SuspendLayout();
                dgvRProduct.SuspendLayout();

                dgvRMovie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvRProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Load data for movies
                DataTable movieData = revenueService.GetMovies();
                totalPagesMovie = (int)Math.Ceiling((double)movieData.Rows.Count / pageSize);
                DataTable pagedMovieData = GetPagedData(movieData, currentPageMovie);
                dgvRMovie.DataSource = pagedMovieData;
                UpdateMoviePageInfo();

                // Load data for products
                DataTable productData = revenueService.GetProducts();
                totalPagesProduct = (int)Math.Ceiling((double)productData.Rows.Count / pageSize);
                DataTable pagedProductData = GetPagedData(productData, currentPageProduct);
                dgvRProduct.DataSource = pagedProductData;
                UpdateProductPageInfo();

                // Các thiết lập khác
                AddSerialNumberColumn(dgvRMovie);
                AddSerialNumberColumn(dgvRProduct);
                SetColumnHeadersMovie();
                SetColumnHeadersProduct();
                RefreshChart();
                LoadPieChart();
            }
            finally
            {
                dgvRMovie.ResumeLayout();
                dgvRProduct.ResumeLayout();
            }
        }

        private DataTable GetPagedData(DataTable data, int pageNumber)
        {
            DataTable pagedData = data.Clone();
            int startIndex = (pageNumber - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, data.Rows.Count);

            for (int i = startIndex; i < endIndex; i++)
            {
                pagedData.ImportRow(data.Rows[i]);
            }

            return pagedData;
        }

        private void UpdateMoviePageInfo()
        {
            lblMoviePageInfo.Text = $"Trang {currentPageMovie}/{totalPagesMovie}";
            btnPrevMovie.Enabled = currentPageMovie > 1;
            btnNextMovie.Enabled = currentPageMovie < totalPagesMovie;
        }

        private void UpdateProductPageInfo()
        {
            lblProductPageInfo.Text = $"Trang {currentPageProduct}/{totalPagesProduct}";
            btnPrevProduct.Enabled = currentPageProduct > 1;
            btnNextProduct.Enabled = currentPageProduct < totalPagesProduct;
        }

        private void SetColumnHeadersMovie()
        {
            if (dgvRMovie.Columns.Contains("MovieName"))
                dgvRMovie.Columns["MovieName"].HeaderText = "Tên phim";
            if (dgvRMovie.Columns.Contains("TotalTickets"))
                dgvRMovie.Columns["TotalTickets"].HeaderText = "Số lượng vé";
            if (dgvRMovie.Columns.Contains("RevenueDate"))
                dgvRMovie.Columns["RevenueDate"].HeaderText = "Ngày";
            if (dgvRMovie.Columns.Contains("TotalRevenue"))
                dgvRMovie.Columns["TotalRevenue"].HeaderText = "Doanh thu";
        }

        private void SetColumnHeadersProduct()
        {
            if (dgvRProduct.Columns.Contains("productName"))
                dgvRProduct.Columns["productName"].HeaderText = "Tên sản phẩm";
            if (dgvRProduct.Columns.Contains("sold"))
                dgvRProduct.Columns["sold"].HeaderText = "Đã bán";
            if (dgvRProduct.Columns.Contains("totalPrice"))
                dgvRProduct.Columns["totalPrice"].HeaderText = "Doanh thu";

        }

        private void RefreshChart()
        {
            // Xóa dữ liệu cũ trên biểu đồ
            chartMovie.Series.Clear();

            // Tạo Series mới
            Series series = new Series
            {
                Name = "Doanh thu",
                ChartType = SeriesChartType.Column
            };

            chartMovie.Series.Add(series);

            // Lấy dữ liệu từ DataGridView và thêm vào biểu đồ
            foreach (DataGridViewRow row in dgvRMovie.Rows)
            {
                if (row.Cells["MovieName"].Value != null && row.Cells["TotalRevenue"].Value != null)
                {
                    string movieName = row.Cells["MovieName"].Value.ToString();
                    double revenue = Convert.ToDouble(row.Cells["TotalRevenue"].Value);

                    series.Points.AddXY(movieName, revenue);
                }
            }

            // Đặt tiêu đề cho biểu đồ
            chartMovie.Titles.Clear();
            chartMovie.Titles.Add("Biểu đồ doanh thu phim");
        }

        // Hàm tạo biểu đồ tròn
        private void LoadPieChart()
        {
            // Xóa dữ liệu cũ trong biểu đồ
            chartProduct.Series.Clear();
            chartProduct.ChartAreas.Clear();

            // Tạo ChartArea mới
            ChartArea chartArea = new ChartArea();
            chartProduct.ChartAreas.Add(chartArea);

            // Tạo Series mới cho biểu đồ tròn
            Series pieSeries = new Series
            {
                Name = "RevenueSeries",
                ChartType = SeriesChartType.Pie
            };
            chartProduct.Series.Add(pieSeries);

            // Duyệt qua DataGridView để thêm dữ liệu vào biểu đồ
            foreach (DataGridViewRow row in dgvRProduct.Rows)
            {
                if (row.Cells["productName"].Value != null && row.Cells["totalPrice"].Value != null)
                {
                    string movieName = row.Cells["productName"].Value.ToString();
                    double revenue = Convert.ToDouble(row.Cells["totalPrice"].Value);

                    // Thêm dữ liệu vào Series
                    pieSeries.Points.AddXY(movieName, revenue);
                }
            }

            // Tùy chỉnh hiển thị (nếu cần)
            //pieSeries["PieLabelStyle"] = "Outside"; // Hiển thị tên và giá trị bên ngoài
            pieSeries.LegendText = "#VALX: #PERCENT"; // Gán tên phim và phần trăm
            chartProduct.Legends.Clear();
            chartProduct.Legends.Add(new Legend("Legend"));
            chartProduct.Titles.Clear();
            chartProduct.Titles.Add("Biểu đồ doanh thu sản phẩm");
        }

        //Hàm gán giá trị combobox
        private void ComboBoxMovie()
        {
            cbxMovie.Items.Clear(); // Xóa các mục cũ trong ComboBox nếu có

            foreach (DataGridViewRow row in dgvRMovie.Rows)
            {
                if (row.Cells["MovieName"].Value != null)
                {
                    string movieName = row.Cells["MovieName"].Value.ToString();
                    cbxMovie.Items.Add(movieName); // Thêm tên phim vào ComboBox
                }
            }

            cbxMovie.SelectedIndex = -1; // Không chọn mục nào mặc định
        }

        private void AddSerialNumberColumn(DataGridView dgv)
        {
            // Kiểm tra và thêm cột STT nếu chưa có
            if (!dgv.Columns.Contains("STT"))
            {
                DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn
                {
                    Name = "STT",
                    HeaderText = "STT",
                    Width = 50,
                    ReadOnly = true
                };
                dgv.Columns.Insert(0, sttColumn);
            }

            // Xử lý cập nhật STT khi dữ liệu thay đổi
            dgv.RowsAdded += (sender, e) => UpdateRowNumbers(dgv);
            dgv.RowsRemoved += (sender, e) => UpdateRowNumbers(dgv);
            dgv.DataBindingComplete += (sender, e) => UpdateRowNumbers(dgv);

            if (dgv.Columns.Contains("ID"))
            {
                dgv.Columns["ID"].Visible = false;
            }
        }

        private void UpdateRowNumbers(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow && row.Cells["STT"] != null)
                {
                    row.Cells["STT"].Value = row.Index + 1;
                }
            }
        }

        private void CbxMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMovie.SelectedItem != null)
            {
                string selectedMovie = cbxMovie.SelectedItem.ToString(); // Lấy tên phim được chọn
                DataTable data = revenueService.GetMovies(); // Lấy toàn bộ dữ liệu phim từ service

                if (data != null && data.Rows.Count > 0)
                {
                    // Lọc dữ liệu dựa trên tên phim
                    DataView view = new DataView(data);
                    view.RowFilter = $"MovieName = '{selectedMovie}'";

                    // Gán dữ liệu đã lọc vào DataGridView
                    dgvRMovie.DataSource = view.ToTable();

                    // Làm mới biểu đồ để hiển thị doanh thu của phim được chọn
                    RefreshChart();
                }
            }
        }

        private void RefreshChartByDate(DataTable data)
        {
            chartMovie.Series[0].Points.Clear();
            foreach (DataRow row in data.Rows)
            {
                string movieName = row["MovieName"].ToString();
                decimal revenue = Convert.ToDecimal(row["TotalRevenue"]);
                chartMovie.Series[0].Points.AddXY(movieName, revenue);
            }
        }

        private void LoadComboBoxOptions()
        {
            // Tùy chọn hiển thị
            var options = new List<KeyValuePair<string, int>>
            {
                new KeyValuePair<string, int>("", 0),               // Thêm mục trống
                new KeyValuePair<string, int>("7 ngày", 7),
                new KeyValuePair<string, int>("14 ngày", 14),
                new KeyValuePair<string, int>("30 ngày", 30)
            };

            cbxDate.DataSource = new BindingSource(options, null);          // Gắn dữ liệu vào ComboBox
            cbxDate.DisplayMember = "Key";         // Hiển thị (Key)
            cbxDate.ValueMember = "Value";         // Giá trị (Value)
            cbxDate.SelectedIndex = 0;             // Mặc định chọn mục trống
        }

        private void FilterData()
        {
            currentPageMovie = 1; // Reset về trang đầu khi lọc

            string selectedMovie = cbxMovie.SelectedItem?.ToString();
            int selectedDays = cbxDate.SelectedValue is int ? (int)cbxDate.SelectedValue : 0;
            string filterCondition = string.Empty;

            if (!string.IsNullOrEmpty(selectedMovie))
            {
                filterCondition += $"MovieName = '{selectedMovie}'";
            }

            if (selectedDays > 0)
            {
                DateTime startDate = DateTime.Now.AddDays(-selectedDays);
                if (!string.IsNullOrEmpty(filterCondition)) filterCondition += " AND ";
                filterCondition += $"RevenueDate >= #{startDate:yyyy-MM-dd}#";
            }

            DataTable data = revenueService.GetMovies();
            if (data != null && data.Rows.Count > 0)
            {
                DataView view = new DataView(data);
                view.RowFilter = filterCondition;

                totalPagesMovie = (int)Math.Ceiling((double)view.Count / pageSize);
                DataTable pagedData = GetPagedData(view.ToTable(), currentPageMovie);

                dgvRMovie.DataSource = pagedData;
                RefreshChartByDate(pagedData);
            }
            else
            {
                dgvRMovie.DataSource = null;
                chartMovie.Series[0].Points.Clear();
                totalPagesMovie = 1;
            }

            UpdateMoviePageInfo();
        }

        #endregion

        private void FileExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRMovie.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Excel Files (*.xlsx)|*.xlsx",
                    FileName = "DoanhThuPhim.xlsx"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel(dgvRMovie, sfd.FileName);
                    MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRProduct.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Excel Files (*.xlsx)|*.xlsx",
                    FileName = "DoanhThuSanPham.xlsx"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel(dgvRProduct, sfd.FileName);
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
            DataTable exportData;
            if (dgv == dgvRMovie)
            {
                exportData = revenueService.GetMovies(); // Lấy toàn bộ dữ liệu phim
            }
            else
            {
                exportData = revenueService.GetProducts(); // Lấy toàn bộ dữ liệu sản phẩm
            }

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Add(Type.Missing);
            Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Sheets[1];

            // Header
            for (int i = 1; i <= exportData.Columns.Count; i++)
            {
                xlWorkSheet.Cells[1, i] = exportData.Columns[i - 1].ColumnName;
            }

            // Data
            for (int i = 0; i < exportData.Rows.Count; i++)
            {
                for (int j = 0; j < exportData.Columns.Count; j++)
                {
                    var value = exportData.Rows[i][j];
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

        private void btnPrevMovie_Click_1(object sender, EventArgs e)
        {
            if (currentPageMovie > 1)
            {
                currentPageMovie--;
                LoadData();
            }
        }

        private void btnNextMovie_Click_1(object sender, EventArgs e)
        {
            if (currentPageMovie < totalPagesMovie)
            {
                currentPageMovie++;
                LoadData();
            }
        }

        private void btnPrevProduct_Click_1(object sender, EventArgs e)
        {
            if (currentPageProduct > 1)
            {
                currentPageProduct--;
                LoadData();
            }
        }

        private void btnNextProduct_Click_1(object sender, EventArgs e)
        {
            if (currentPageProduct < totalPagesProduct)
            {
                currentPageProduct++;
                LoadData();
            }
        }

    }
}
