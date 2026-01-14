namespace Presentation.Forms.admin.edit
{
    partial class frmEditEmployee
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
            this.btnClose = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.dateNgaySinh = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtpCaLam = new System.Windows.Forms.DateTimePicker();
            this.blbCaLam = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.blbSoDienThoai = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.lblLuong = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(429, 458);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(66, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Hủy";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(114)))));
            this.panel9.Controls.Add(this.lblHeader);
            this.panel9.Location = new System.Drawing.Point(2, 2);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(506, 45);
            this.panel9.TabIndex = 97;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(109, 6);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(291, 32);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(303, 458);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 30);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Lưu";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(194, 8);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNV.Multiline = true;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(268, 28);
            this.txtTenNV.TabIndex = 0;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.Location = new System.Drawing.Point(35, 11);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(136, 25);
            this.lblTenNV.TabIndex = 76;
            this.lblTenNV.Text = "Tên Nhân Viên";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTenNV);
            this.panel3.Controls.Add(this.lblTenNV);
            this.panel3.Location = new System.Drawing.Point(2, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 45);
            this.panel3.TabIndex = 101;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiTinh.Location = new System.Drawing.Point(194, 8);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.txtGioiTinh.Multiline = true;
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(268, 28);
            this.txtGioiTinh.TabIndex = 0;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(83, 11);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(89, 25);
            this.lblGioiTinh.TabIndex = 77;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.AutoSize = true;
            this.dateNgaySinh.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgaySinh.Location = new System.Drawing.Point(73, 11);
            this.dateNgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(100, 25);
            this.dateNgaySinh.TabIndex = 78;
            this.dateNgaySinh.Text = "Ngày Sinh";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtGioiTinh);
            this.panel4.Controls.Add(this.lblGioiTinh);
            this.panel4.Location = new System.Drawing.Point(2, 109);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(506, 45);
            this.panel4.TabIndex = 102;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(194, 7);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(188, 29);
            this.dtpNgaySinh.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dateNgaySinh);
            this.panel5.Controls.Add(this.dtpNgaySinh);
            this.panel5.Location = new System.Drawing.Point(2, 165);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(506, 45);
            this.panel5.TabIndex = 103;
            // 
            // dtpCaLam
            // 
            this.dtpCaLam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCaLam.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCaLam.Location = new System.Drawing.Point(194, 7);
            this.dtpCaLam.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCaLam.Name = "dtpCaLam";
            this.dtpCaLam.Size = new System.Drawing.Size(188, 29);
            this.dtpCaLam.TabIndex = 0;
            // 
            // blbCaLam
            // 
            this.blbCaLam.AutoSize = true;
            this.blbCaLam.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbCaLam.Location = new System.Drawing.Point(99, 11);
            this.blbCaLam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blbCaLam.Name = "blbCaLam";
            this.blbCaLam.Size = new System.Drawing.Size(75, 25);
            this.blbCaLam.TabIndex = 81;
            this.blbCaLam.Text = "Ca Làm";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtpCaLam);
            this.panel6.Controls.Add(this.blbCaLam);
            this.panel6.Location = new System.Drawing.Point(2, 221);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(506, 45);
            this.panel6.TabIndex = 104;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(194, 8);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoDienThoai.Multiline = true;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(268, 28);
            this.txtSoDienThoai.TabIndex = 0;
            // 
            // blbSoDienThoai
            // 
            this.blbSoDienThoai.AutoSize = true;
            this.blbSoDienThoai.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbSoDienThoai.Location = new System.Drawing.Point(41, 11);
            this.blbSoDienThoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blbSoDienThoai.Name = "blbSoDienThoai";
            this.blbSoDienThoai.Size = new System.Drawing.Size(130, 25);
            this.blbSoDienThoai.TabIndex = 82;
            this.blbSoDienThoai.Text = "Số Điện Thoại";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtSoDienThoai);
            this.panel7.Controls.Add(this.blbSoDienThoai);
            this.panel7.Location = new System.Drawing.Point(2, 277);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(506, 45);
            this.panel7.TabIndex = 105;
            // 
            // txtLuong
            // 
            this.txtLuong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.Location = new System.Drawing.Point(194, 8);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtLuong.Multiline = true;
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(268, 28);
            this.txtLuong.TabIndex = 0;
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuong.Location = new System.Drawing.Point(107, 10);
            this.lblLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(67, 25);
            this.lblLuong.TabIndex = 86;
            this.lblLuong.Text = "Lương";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtLuong);
            this.panel8.Controls.Add(this.lblLuong);
            this.panel8.Location = new System.Drawing.Point(2, 333);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(506, 45);
            this.panel8.TabIndex = 106;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 502);
            this.panel1.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txtRole);
            this.panel10.Controls.Add(this.lblRole);
            this.panel10.Location = new System.Drawing.Point(2, 384);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(506, 45);
            this.panel10.TabIndex = 108;
            // 
            // txtRole
            // 
            this.txtRole.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(194, 8);
            this.txtRole.Margin = new System.Windows.Forms.Padding(2);
            this.txtRole.Multiline = true;
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(268, 28);
            this.txtRole.TabIndex = 0;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(91, 10);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(82, 25);
            this.lblRole.TabIndex = 86;
            this.lblRole.Text = "Chức vụ";
            // 
            // frmEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 517);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmEditEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form sửa ";
            this.Load += new System.EventHandler(this.frmEditEmployee_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label dateNgaySinh;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dtpCaLam;
        private System.Windows.Forms.Label blbCaLam;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label blbSoDienThoai;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label lblRole;
    }
}