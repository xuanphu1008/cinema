
namespace Presentation.Forms.admin
{
    partial class frmScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvScreenings = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSceeningTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhongChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScreeningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAllRoom = new System.Windows.Forms.Button();
            this.btnRoom5 = new System.Windows.Forms.Button();
            this.btnRoom4 = new System.Windows.Forms.Button();
            this.btnRoom3 = new System.Windows.Forms.Button();
            this.btnRoom2 = new System.Windows.Forms.Button();
            this.btnRoom1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddd = new Presentation.Controls.ButtonDS();
            this.dtpScreeningDate = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreenings)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvScreenings
            // 
            this.dgvScreenings.AllowUserToAddRows = false;
            this.dgvScreenings.AllowUserToDeleteRows = false;
            this.dgvScreenings.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScreenings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScreenings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScreenings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTitle,
            this.colGenre,
            this.colDuration,
            this.colSceeningTime,
            this.colPhongChieu,
            this.colScreeningDate,
            this.colEdit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScreenings.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvScreenings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvScreenings.EnableHeadersVisualStyles = false;
            this.dgvScreenings.Location = new System.Drawing.Point(128, 70);
            this.dgvScreenings.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvScreenings.Name = "dgvScreenings";
            this.dgvScreenings.ReadOnly = true;
            this.dgvScreenings.RowHeadersVisible = false;
            this.dgvScreenings.RowHeadersWidth = 51;
            this.dgvScreenings.RowTemplate.Height = 24;
            this.dgvScreenings.Size = new System.Drawing.Size(711, 425);
            this.dgvScreenings.TabIndex = 0;
            this.dgvScreenings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScreenings_CellContentClick);
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colId.HeaderText = "Mã suất chiếu";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colTitle
            // 
            this.colTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTitle.HeaderText = "Tên Phim";
            this.colTitle.MinimumWidth = 6;
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colGenre
            // 
            this.colGenre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGenre.HeaderText = "Thể loại";
            this.colGenre.MinimumWidth = 6;
            this.colGenre.Name = "colGenre";
            this.colGenre.ReadOnly = true;
            // 
            // colDuration
            // 
            this.colDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDuration.HeaderText = "Thời Lượng";
            this.colDuration.MinimumWidth = 6;
            this.colDuration.Name = "colDuration";
            this.colDuration.ReadOnly = true;
            // 
            // colSceeningTime
            // 
            this.colSceeningTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSceeningTime.HeaderText = "Giờ Chiếu";
            this.colSceeningTime.MinimumWidth = 6;
            this.colSceeningTime.Name = "colSceeningTime";
            this.colSceeningTime.ReadOnly = true;
            // 
            // colPhongChieu
            // 
            this.colPhongChieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPhongChieu.HeaderText = "Phòng Chiếu";
            this.colPhongChieu.MinimumWidth = 6;
            this.colPhongChieu.Name = "colPhongChieu";
            this.colPhongChieu.ReadOnly = true;
            // 
            // colScreeningDate
            // 
            this.colScreeningDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colScreeningDate.HeaderText = "Ngày chiếu";
            this.colScreeningDate.MinimumWidth = 6;
            this.colScreeningDate.Name = "colScreeningDate";
            this.colScreeningDate.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "";
            this.colEdit.Image = global::Presentation.Properties.Resources.edit_image;
            this.colEdit.MinimumWidth = 6;
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Width = 50;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAllRoom);
            this.panel4.Controls.Add(this.btnRoom5);
            this.panel4.Controls.Add(this.btnRoom4);
            this.panel4.Controls.Add(this.btnRoom3);
            this.panel4.Controls.Add(this.btnRoom2);
            this.panel4.Controls.Add(this.btnRoom1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 70);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(128, 425);
            this.panel4.TabIndex = 2;
            // 
            // btnAllRoom
            // 
            this.btnAllRoom.BackColor = System.Drawing.Color.White;
            this.btnAllRoom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAllRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllRoom.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllRoom.Location = new System.Drawing.Point(2, 3);
            this.btnAllRoom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAllRoom.Name = "btnAllRoom";
            this.btnAllRoom.Size = new System.Drawing.Size(124, 35);
            this.btnAllRoom.TabIndex = 5;
            this.btnAllRoom.Text = "Tất cả";
            this.btnAllRoom.UseVisualStyleBackColor = false;
            this.btnAllRoom.Click += new System.EventHandler(this.btnAllRoom_Click);
            // 
            // btnRoom5
            // 
            this.btnRoom5.BackColor = System.Drawing.Color.White;
            this.btnRoom5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRoom5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom5.Location = new System.Drawing.Point(2, 224);
            this.btnRoom5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRoom5.Name = "btnRoom5";
            this.btnRoom5.Size = new System.Drawing.Size(124, 35);
            this.btnRoom5.TabIndex = 4;
            this.btnRoom5.Text = "Phòng 5";
            this.btnRoom5.UseVisualStyleBackColor = false;
            this.btnRoom5.Click += new System.EventHandler(this.btnRoom5_Click);
            // 
            // btnRoom4
            // 
            this.btnRoom4.BackColor = System.Drawing.Color.White;
            this.btnRoom4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRoom4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom4.Location = new System.Drawing.Point(2, 179);
            this.btnRoom4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRoom4.Name = "btnRoom4";
            this.btnRoom4.Size = new System.Drawing.Size(124, 35);
            this.btnRoom4.TabIndex = 3;
            this.btnRoom4.Text = "Phòng 4";
            this.btnRoom4.UseVisualStyleBackColor = false;
            this.btnRoom4.Click += new System.EventHandler(this.btnRoom4_Click);
            // 
            // btnRoom3
            // 
            this.btnRoom3.BackColor = System.Drawing.Color.White;
            this.btnRoom3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRoom3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom3.Location = new System.Drawing.Point(2, 135);
            this.btnRoom3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRoom3.Name = "btnRoom3";
            this.btnRoom3.Size = new System.Drawing.Size(124, 35);
            this.btnRoom3.TabIndex = 2;
            this.btnRoom3.Text = "Phòng 3";
            this.btnRoom3.UseVisualStyleBackColor = false;
            this.btnRoom3.Click += new System.EventHandler(this.btnRoom3_Click);
            // 
            // btnRoom2
            // 
            this.btnRoom2.BackColor = System.Drawing.Color.White;
            this.btnRoom2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRoom2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom2.Location = new System.Drawing.Point(2, 91);
            this.btnRoom2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRoom2.Name = "btnRoom2";
            this.btnRoom2.Size = new System.Drawing.Size(124, 35);
            this.btnRoom2.TabIndex = 1;
            this.btnRoom2.Text = "Phòng 2";
            this.btnRoom2.UseVisualStyleBackColor = false;
            this.btnRoom2.Click += new System.EventHandler(this.btnRoom2_Click);
            // 
            // btnRoom1
            // 
            this.btnRoom1.BackColor = System.Drawing.Color.White;
            this.btnRoom1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRoom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom1.Location = new System.Drawing.Point(2, 47);
            this.btnRoom1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRoom1.Name = "btnRoom1";
            this.btnRoom1.Size = new System.Drawing.Size(124, 35);
            this.btnRoom1.TabIndex = 0;
            this.btnRoom1.Text = "Phòng 1";
            this.btnRoom1.UseVisualStyleBackColor = false;
            this.btnRoom1.Click += new System.EventHandler(this.btnRoom1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddd);
            this.panel3.Controls.Add(this.dtpScreeningDate);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(839, 70);
            this.panel3.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileExcelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(128, 471);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "Xuất file excel";
            // 
            // FileExcelToolStripMenuItem
            // 
            this.FileExcelToolStripMenuItem.Name = "FileExcelToolStripMenuItem";
            this.FileExcelToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.FileExcelToolStripMenuItem.Text = "Xuất file excel";
            this.FileExcelToolStripMenuItem.Click += new System.EventHandler(this.FileExcelToolStripMenuItem_Click);
            // 
            // btnAddd
            // 
            this.btnAddd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnAddd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnAddd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddd.BorderRadius = 5;
            this.btnAddd.BorderSize = 0;
            this.btnAddd.FlatAppearance.BorderSize = 0;
            this.btnAddd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddd.ForeColor = System.Drawing.Color.White;
            this.btnAddd.Location = new System.Drawing.Point(221, 15);
            this.btnAddd.Name = "btnAddd";
            this.btnAddd.Size = new System.Drawing.Size(85, 31);
            this.btnAddd.TabIndex = 4;
            this.btnAddd.Text = "Thêm";
            this.btnAddd.TextColor = System.Drawing.Color.White;
            this.btnAddd.UseVisualStyleBackColor = false;
            this.btnAddd.Click += new System.EventHandler(this.btnAddd_Click);
            // 
            // dtpScreeningDate
            // 
            this.dtpScreeningDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpScreeningDate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpScreeningDate.CustomFormat = "dd / MM / yyyy";
            this.dtpScreeningDate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpScreeningDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpScreeningDate.Location = new System.Drawing.Point(680, 14);
            this.dtpScreeningDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpScreeningDate.Name = "dtpScreeningDate";
            this.dtpScreeningDate.Size = new System.Drawing.Size(151, 32);
            this.dtpScreeningDate.TabIndex = 2;
            this.dtpScreeningDate.Value = new System.DateTime(2024, 10, 10, 0, 0, 0, 0);
            this.dtpScreeningDate.ValueChanged += new System.EventHandler(this.dtpScreeningDate_ValueChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(9, 14);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(207, 31);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 495);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvScreenings);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmScreen";
            this.Text = "QUẢN LÝ SUẤT CHIẾU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreenings)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvScreenings;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRoom5;
        private System.Windows.Forms.Button btnRoom4;
        private System.Windows.Forms.Button btnRoom3;
        private System.Windows.Forms.Button btnRoom2;
        private System.Windows.Forms.Button btnRoom1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpScreeningDate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAllRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSceeningTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhongChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScreeningDate;
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private Controls.ButtonDS btnAddd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileExcelToolStripMenuItem;
    }
}
