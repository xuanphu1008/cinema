namespace Presentation.Forms.admin.edit
{
    partial class frmEditMovie
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
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ptEditMovie = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEditTenPhim = new System.Windows.Forms.TextBox();
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEditTheLoai = new System.Windows.Forms.TextBox();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtEditMoTa = new System.Windows.Forms.TextBox();
            this.txtEditDaoDien = new System.Windows.Forms.TextBox();
            this.lblDaoDien = new System.Windows.Forms.Label();
            this.blbThoiLuong = new System.Windows.Forms.Label();
            this.blbQuocGia = new System.Windows.Forms.Label();
            this.txtEditThoiLuong = new System.Windows.Forms.TextBox();
            this.txtEditQuocGia = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtEditTrangThai = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblDoTuoi = new System.Windows.Forms.Label();
            this.txtEditDoTuoi = new System.Windows.Forms.TextBox();
            this.lblAnhBia = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ptEditMovie)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.BackgroundImage = global::Presentation.Properties.Resources.folder;
            this.btnOpenFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenFolder.Location = new System.Drawing.Point(358, 363);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(39, 37);
            this.btnOpenFolder.TabIndex = 108;
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(409, 524);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 107;
            this.btnClose.Text = "Hủy";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // ptEditMovie
            // 
            this.ptEditMovie.Location = new System.Drawing.Point(412, 335);
            this.ptEditMovie.Name = "ptEditMovie";
            this.ptEditMovie.Size = new System.Drawing.Size(118, 158);
            this.ptEditMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptEditMovie.TabIndex = 106;
            this.ptEditMovie.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(308, 524);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.TabIndex = 105;
            this.btnEdit.Text = "Lưu";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoTa.Location = new System.Drawing.Point(49, 338);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(66, 25);
            this.lblMoTa.TabIndex = 103;
            this.lblMoTa.Text = "Mô Tả";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(169, 6);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(219, 32);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "THÔNG TIN PHIM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(114)))));
            this.panel2.Controls.Add(this.lblHeader);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 45);
            this.panel2.TabIndex = 109;
            // 
            // txtEditTenPhim
            // 
            this.txtEditTenPhim.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditTenPhim.Location = new System.Drawing.Point(193, 8);
            this.txtEditTenPhim.Multiline = true;
            this.txtEditTenPhim.Name = "txtEditTenPhim";
            this.txtEditTenPhim.Size = new System.Drawing.Size(296, 28);
            this.txtEditTenPhim.TabIndex = 96;
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = true;
            this.lblTenPhim.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhim.Location = new System.Drawing.Point(79, 11);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(90, 25);
            this.lblTenPhim.TabIndex = 93;
            this.lblTenPhim.Text = "Tên Phim";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtEditTenPhim);
            this.panel3.Controls.Add(this.lblTenPhim);
            this.panel3.Location = new System.Drawing.Point(4, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(557, 45);
            this.panel3.TabIndex = 110;
            // 
            // txtEditTheLoai
            // 
            this.txtEditTheLoai.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditTheLoai.Location = new System.Drawing.Point(193, 8);
            this.txtEditTheLoai.Multiline = true;
            this.txtEditTheLoai.Name = "txtEditTheLoai";
            this.txtEditTheLoai.Size = new System.Drawing.Size(296, 28);
            this.txtEditTheLoai.TabIndex = 97;
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheLoai.Location = new System.Drawing.Point(86, 11);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(83, 25);
            this.lblTheLoai.TabIndex = 94;
            this.lblTheLoai.Text = "Thể Loại";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtEditTheLoai);
            this.panel4.Controls.Add(this.lblTheLoai);
            this.panel4.Location = new System.Drawing.Point(4, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(557, 45);
            this.panel4.TabIndex = 111;
            // 
            // txtEditMoTa
            // 
            this.txtEditMoTa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditMoTa.Location = new System.Drawing.Point(54, 366);
            this.txtEditMoTa.Multiline = true;
            this.txtEditMoTa.Name = "txtEditMoTa";
            this.txtEditMoTa.Size = new System.Drawing.Size(215, 127);
            this.txtEditMoTa.TabIndex = 104;
            // 
            // txtEditDaoDien
            // 
            this.txtEditDaoDien.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditDaoDien.Location = new System.Drawing.Point(193, 8);
            this.txtEditDaoDien.Multiline = true;
            this.txtEditDaoDien.Name = "txtEditDaoDien";
            this.txtEditDaoDien.Size = new System.Drawing.Size(296, 28);
            this.txtEditDaoDien.TabIndex = 98;
            // 
            // lblDaoDien
            // 
            this.lblDaoDien.AutoSize = true;
            this.lblDaoDien.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaoDien.Location = new System.Drawing.Point(77, 11);
            this.lblDaoDien.Name = "lblDaoDien";
            this.lblDaoDien.Size = new System.Drawing.Size(92, 25);
            this.lblDaoDien.TabIndex = 95;
            this.lblDaoDien.Text = "Đạo Diễn";
            // 
            // blbThoiLuong
            // 
            this.blbThoiLuong.AutoSize = true;
            this.blbThoiLuong.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbThoiLuong.Location = new System.Drawing.Point(289, 11);
            this.blbThoiLuong.Name = "blbThoiLuong";
            this.blbThoiLuong.Size = new System.Drawing.Size(110, 25);
            this.blbThoiLuong.TabIndex = 101;
            this.blbThoiLuong.Text = "Thời Lượng";
            // 
            // blbQuocGia
            // 
            this.blbQuocGia.AutoSize = true;
            this.blbQuocGia.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbQuocGia.Location = new System.Drawing.Point(45, 11);
            this.blbQuocGia.Name = "blbQuocGia";
            this.blbQuocGia.Size = new System.Drawing.Size(90, 25);
            this.blbQuocGia.TabIndex = 99;
            this.blbQuocGia.Text = "Quốc Gia";
            // 
            // txtEditThoiLuong
            // 
            this.txtEditThoiLuong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditThoiLuong.Location = new System.Drawing.Point(405, 8);
            this.txtEditThoiLuong.Multiline = true;
            this.txtEditThoiLuong.Name = "txtEditThoiLuong";
            this.txtEditThoiLuong.Size = new System.Drawing.Size(121, 28);
            this.txtEditThoiLuong.TabIndex = 102;
            // 
            // txtEditQuocGia
            // 
            this.txtEditQuocGia.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditQuocGia.Location = new System.Drawing.Point(156, 8);
            this.txtEditQuocGia.Multiline = true;
            this.txtEditQuocGia.Name = "txtEditQuocGia";
            this.txtEditQuocGia.Size = new System.Drawing.Size(95, 28);
            this.txtEditQuocGia.TabIndex = 100;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.blbThoiLuong);
            this.panel6.Controls.Add(this.blbQuocGia);
            this.panel6.Controls.Add(this.txtEditThoiLuong);
            this.panel6.Controls.Add(this.txtEditQuocGia);
            this.panel6.Location = new System.Drawing.Point(4, 217);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(557, 45);
            this.panel6.TabIndex = 113;
            // 
            // txtEditTrangThai
            // 
            this.txtEditTrangThai.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditTrangThai.Location = new System.Drawing.Point(405, 8);
            this.txtEditTrangThai.Multiline = true;
            this.txtEditTrangThai.Name = "txtEditTrangThai";
            this.txtEditTrangThai.Size = new System.Drawing.Size(121, 28);
            this.txtEditTrangThai.TabIndex = 106;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(299, 11);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(100, 25);
            this.lblTrangThai.TabIndex = 105;
            this.lblTrangThai.Text = "Trạng Thái";
            // 
            // lblDoTuoi
            // 
            this.lblDoTuoi.AutoSize = true;
            this.lblDoTuoi.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoTuoi.Location = new System.Drawing.Point(57, 11);
            this.lblDoTuoi.Name = "lblDoTuoi";
            this.lblDoTuoi.Size = new System.Drawing.Size(78, 25);
            this.lblDoTuoi.TabIndex = 103;
            this.lblDoTuoi.Text = "Độ Tuổi";
            // 
            // txtEditDoTuoi
            // 
            this.txtEditDoTuoi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditDoTuoi.Location = new System.Drawing.Point(156, 8);
            this.txtEditDoTuoi.Multiline = true;
            this.txtEditDoTuoi.Name = "txtEditDoTuoi";
            this.txtEditDoTuoi.Size = new System.Drawing.Size(95, 28);
            this.txtEditDoTuoi.TabIndex = 104;
            // 
            // lblAnhBia
            // 
            this.lblAnhBia.AutoSize = true;
            this.lblAnhBia.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnhBia.Location = new System.Drawing.Point(319, 335);
            this.lblAnhBia.Name = "lblAnhBia";
            this.lblAnhBia.Size = new System.Drawing.Size(78, 25);
            this.lblAnhBia.TabIndex = 115;
            this.lblAnhBia.Text = "Ảnh bìa";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtEditTrangThai);
            this.panel7.Controls.Add(this.lblTrangThai);
            this.panel7.Controls.Add(this.lblDoTuoi);
            this.panel7.Controls.Add(this.txtEditDoTuoi);
            this.panel7.Location = new System.Drawing.Point(4, 272);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(557, 45);
            this.panel7.TabIndex = 114;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAnhBia);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnOpenFolder);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.ptEditMovie);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.txtEditMoTa);
            this.panel1.Controls.Add(this.lblMoTa);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 578);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtEditDaoDien);
            this.panel5.Controls.Add(this.lblDaoDien);
            this.panel5.Location = new System.Drawing.Point(4, 162);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(557, 45);
            this.panel5.TabIndex = 112;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // frmEditMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 602);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEditMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form sửa phim";
            this.Load += new System.EventHandler(this.frmEditMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptEditMovie)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox ptEditMovie;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEditTenPhim;
        private System.Windows.Forms.Label lblTenPhim;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEditTheLoai;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtEditMoTa;
        private System.Windows.Forms.TextBox txtEditDaoDien;
        private System.Windows.Forms.Label lblDaoDien;
        private System.Windows.Forms.Label blbThoiLuong;
        private System.Windows.Forms.Label blbQuocGia;
        private System.Windows.Forms.TextBox txtEditThoiLuong;
        private System.Windows.Forms.TextBox txtEditQuocGia;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtEditTrangThai;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblDoTuoi;
        private System.Windows.Forms.TextBox txtEditDoTuoi;
        private System.Windows.Forms.Label lblAnhBia;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}