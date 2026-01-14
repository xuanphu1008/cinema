namespace Presentation.Forms.admin
{
    partial class frmRevenue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRevenue));
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvRProduct = new System.Windows.Forms.DataGridView();
            this.chartProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxDate = new System.Windows.Forms.ComboBox();
            this.dgvRMovie = new System.Windows.Forms.DataGridView();
            this.cbxMovie = new System.Windows.Forms.ComboBox();
            this.chartMovie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMoviePageInfo = new System.Windows.Forms.Label();
            this.btnPrevMovie = new Presentation.Controls.ButtonDS();
            this.btnNextMovie = new Presentation.Controls.ButtonDS();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProductPageInfo = new System.Windows.Forms.Label();
            this.btnPrevProduct = new Presentation.Controls.ButtonDS();
            this.btnNextProduct = new Presentation.Controls.ButtonDS();
            this.panel4.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).BeginInit();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMovie)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.menuStrip2);
            this.panel4.Controls.Add(this.dgvRProduct);
            this.panel4.Controls.Add(this.chartProduct);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(969, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(208, 568);
            this.panel4.TabIndex = 13;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 544);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip2.Size = new System.Drawing.Size(208, 24);
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "Xuất file excel";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(91, 22);
            this.toolStripMenuItem1.Text = "Xuất file excel";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // dgvRProduct
            // 
            this.dgvRProduct.AllowUserToAddRows = false;
            this.dgvRProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRProduct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRProduct.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvRProduct.EnableHeadersVisualStyles = false;
            this.dgvRProduct.Location = new System.Drawing.Point(0, 312);
            this.dgvRProduct.Name = "dgvRProduct";
            this.dgvRProduct.RowHeadersWidth = 62;
            this.dgvRProduct.RowTemplate.Height = 30;
            this.dgvRProduct.Size = new System.Drawing.Size(208, 184);
            this.dgvRProduct.TabIndex = 1;
            // 
            // chartProduct
            // 
            chartArea5.Name = "ChartArea1";
            this.chartProduct.ChartAreas.Add(chartArea5);
            this.chartProduct.Dock = System.Windows.Forms.DockStyle.Top;
            legend5.Name = "Legend1";
            this.chartProduct.Legends.Add(legend5);
            this.chartProduct.Location = new System.Drawing.Point(0, 0);
            this.chartProduct.Name = "chartProduct";
            this.chartProduct.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartProduct.Series.Add(series5);
            this.chartProduct.Size = new System.Drawing.Size(208, 312);
            this.chartProduct.TabIndex = 0;
            this.chartProduct.Text = "chart2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Controls.Add(this.cbxDate);
            this.panel3.Controls.Add(this.dgvRMovie);
            this.panel3.Controls.Add(this.cbxMovie);
            this.panel3.Controls.Add(this.chartMovie);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(969, 568);
            this.panel3.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileExcelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 544);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(969, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "Xuất dữ liệu doanh thu phim";
            // 
            // FileExcelToolStripMenuItem
            // 
            this.FileExcelToolStripMenuItem.Name = "FileExcelToolStripMenuItem";
            this.FileExcelToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.FileExcelToolStripMenuItem.Text = "Xuất file excel";
            this.FileExcelToolStripMenuItem.Click += new System.EventHandler(this.FileExcelToolStripMenuItem_Click);
            // 
            // cbxDate
            // 
            this.cbxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDate.FormattingEnabled = true;
            this.cbxDate.Location = new System.Drawing.Point(815, 36);
            this.cbxDate.Name = "cbxDate";
            this.cbxDate.Size = new System.Drawing.Size(154, 26);
            this.cbxDate.TabIndex = 2;
            // 
            // dgvRMovie
            // 
            this.dgvRMovie.AllowUserToAddRows = false;
            this.dgvRMovie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRMovie.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRMovie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvRMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRMovie.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvRMovie.EnableHeadersVisualStyles = false;
            this.dgvRMovie.Location = new System.Drawing.Point(0, 312);
            this.dgvRMovie.Name = "dgvRMovie";
            this.dgvRMovie.RowHeadersWidth = 62;
            this.dgvRMovie.RowTemplate.Height = 30;
            this.dgvRMovie.Size = new System.Drawing.Size(969, 184);
            this.dgvRMovie.TabIndex = 1;
            // 
            // cbxMovie
            // 
            this.cbxMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMovie.FormattingEnabled = true;
            this.cbxMovie.Location = new System.Drawing.Point(815, 68);
            this.cbxMovie.Name = "cbxMovie";
            this.cbxMovie.Size = new System.Drawing.Size(154, 26);
            this.cbxMovie.TabIndex = 3;
            this.cbxMovie.Visible = false;
            // 
            // chartMovie
            // 
            chartArea6.Name = "ChartArea1";
            this.chartMovie.ChartAreas.Add(chartArea6);
            this.chartMovie.Dock = System.Windows.Forms.DockStyle.Top;
            legend6.Name = "Legend1";
            this.chartMovie.Legends.Add(legend6);
            this.chartMovie.Location = new System.Drawing.Point(0, 0);
            this.chartMovie.Name = "chartMovie";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartMovie.Series.Add(series6);
            this.chartMovie.Size = new System.Drawing.Size(969, 312);
            this.chartMovie.TabIndex = 0;
            this.chartMovie.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMoviePageInfo);
            this.panel2.Controls.Add(this.btnPrevMovie);
            this.panel2.Controls.Add(this.btnNextMovie);
            this.panel2.Location = new System.Drawing.Point(3, 502);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 39);
            this.panel2.TabIndex = 9;
            // 
            // lblMoviePageInfo
            // 
            this.lblMoviePageInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMoviePageInfo.AutoSize = true;
            this.lblMoviePageInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMoviePageInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMoviePageInfo.Location = new System.Drawing.Point(452, 12);
            this.lblMoviePageInfo.Name = "lblMoviePageInfo";
            this.lblMoviePageInfo.Size = new System.Drawing.Size(41, 17);
            this.lblMoviePageInfo.TabIndex = 4;
            this.lblMoviePageInfo.Text = "Trang";
            // 
            // btnPrevMovie
            // 
            this.btnPrevMovie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrevMovie.BackColor = System.Drawing.Color.White;
            this.btnPrevMovie.BackgroundColor = System.Drawing.Color.White;
            this.btnPrevMovie.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPrevMovie.BorderRadius = 8;
            this.btnPrevMovie.BorderSize = 0;
            this.btnPrevMovie.FlatAppearance.BorderSize = 0;
            this.btnPrevMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevMovie.ForeColor = System.Drawing.Color.White;
            this.btnPrevMovie.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevMovie.Image")));
            this.btnPrevMovie.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrevMovie.Location = new System.Drawing.Point(419, 12);
            this.btnPrevMovie.Name = "btnPrevMovie";
            this.btnPrevMovie.Size = new System.Drawing.Size(28, 17);
            this.btnPrevMovie.TabIndex = 2;
            this.btnPrevMovie.TextColor = System.Drawing.Color.White;
            this.btnPrevMovie.UseVisualStyleBackColor = false;
            this.btnPrevMovie.Click += new System.EventHandler(this.btnPrevMovie_Click_1);
            // 
            // btnNextMovie
            // 
            this.btnNextMovie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNextMovie.BackColor = System.Drawing.Color.White;
            this.btnNextMovie.BackgroundColor = System.Drawing.Color.White;
            this.btnNextMovie.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNextMovie.BorderRadius = 8;
            this.btnNextMovie.BorderSize = 0;
            this.btnNextMovie.FlatAppearance.BorderSize = 0;
            this.btnNextMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextMovie.ForeColor = System.Drawing.Color.White;
            this.btnNextMovie.Image = ((System.Drawing.Image)(resources.GetObject("btnNextMovie.Image")));
            this.btnNextMovie.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNextMovie.Location = new System.Drawing.Point(516, 12);
            this.btnNextMovie.Name = "btnNextMovie";
            this.btnNextMovie.Size = new System.Drawing.Size(28, 17);
            this.btnNextMovie.TabIndex = 3;
            this.btnNextMovie.TextColor = System.Drawing.Color.White;
            this.btnNextMovie.UseVisualStyleBackColor = false;
            this.btnNextMovie.Click += new System.EventHandler(this.btnNextMovie_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblProductPageInfo);
            this.panel1.Controls.Add(this.btnPrevProduct);
            this.panel1.Controls.Add(this.btnNextProduct);
            this.panel1.Location = new System.Drawing.Point(0, 502);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 39);
            this.panel1.TabIndex = 10;
            // 
            // lblProductPageInfo
            // 
            this.lblProductPageInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProductPageInfo.AutoSize = true;
            this.lblProductPageInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblProductPageInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProductPageInfo.Location = new System.Drawing.Point(71, 12);
            this.lblProductPageInfo.Name = "lblProductPageInfo";
            this.lblProductPageInfo.Size = new System.Drawing.Size(41, 17);
            this.lblProductPageInfo.TabIndex = 4;
            this.lblProductPageInfo.Text = "Trang";
            // 
            // btnPrevProduct
            // 
            this.btnPrevProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrevProduct.BackColor = System.Drawing.Color.White;
            this.btnPrevProduct.BackgroundColor = System.Drawing.Color.White;
            this.btnPrevProduct.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPrevProduct.BorderRadius = 8;
            this.btnPrevProduct.BorderSize = 0;
            this.btnPrevProduct.FlatAppearance.BorderSize = 0;
            this.btnPrevProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevProduct.ForeColor = System.Drawing.Color.White;
            this.btnPrevProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevProduct.Image")));
            this.btnPrevProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrevProduct.Location = new System.Drawing.Point(38, 12);
            this.btnPrevProduct.Name = "btnPrevProduct";
            this.btnPrevProduct.Size = new System.Drawing.Size(28, 17);
            this.btnPrevProduct.TabIndex = 2;
            this.btnPrevProduct.TextColor = System.Drawing.Color.White;
            this.btnPrevProduct.UseVisualStyleBackColor = false;
            this.btnPrevProduct.Click += new System.EventHandler(this.btnPrevProduct_Click_1);
            // 
            // btnNextProduct
            // 
            this.btnNextProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNextProduct.BackColor = System.Drawing.Color.White;
            this.btnNextProduct.BackgroundColor = System.Drawing.Color.White;
            this.btnNextProduct.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNextProduct.BorderRadius = 8;
            this.btnNextProduct.BorderSize = 0;
            this.btnNextProduct.FlatAppearance.BorderSize = 0;
            this.btnNextProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextProduct.ForeColor = System.Drawing.Color.White;
            this.btnNextProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnNextProduct.Image")));
            this.btnNextProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNextProduct.Location = new System.Drawing.Point(135, 12);
            this.btnNextProduct.Name = "btnNextProduct";
            this.btnNextProduct.Size = new System.Drawing.Size(28, 17);
            this.btnNextProduct.TabIndex = 3;
            this.btnNextProduct.TextColor = System.Drawing.Color.White;
            this.btnNextProduct.UseVisualStyleBackColor = false;
            this.btnNextProduct.Click += new System.EventHandler(this.btnNextProduct_Click_1);
            // 
            // frmRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 568);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "frmRevenue";
            this.Text = "QUẢN LÝ DOANH THU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRevenue_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMovie)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvRProduct;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbxDate;
        private System.Windows.Forms.DataGridView dgvRMovie;
        private System.Windows.Forms.ComboBox cbxMovie;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMovie;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileExcelToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMoviePageInfo;
        private Controls.ButtonDS btnPrevMovie;
        private Controls.ButtonDS btnNextMovie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProductPageInfo;
        private Controls.ButtonDS btnPrevProduct;
        private Controls.ButtonDS btnNextProduct;
    }
}