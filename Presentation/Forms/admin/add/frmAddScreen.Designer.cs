namespace Presentation.Forms.admin.add
{
    partial class frmAddScreen
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
            this.dtpScreeningTime = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddSceen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblGioChieu = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpSceeningDate = new System.Windows.Forms.DateTimePicker();
            this.lblNgayChieu = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbMovieName = new System.Windows.Forms.ComboBox();
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpScreeningTime
            // 
            this.dtpScreeningTime.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpScreeningTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpScreeningTime.Location = new System.Drawing.Point(269, 14);
            this.dtpScreeningTime.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtpScreeningTime.Name = "dtpScreeningTime";
            this.dtpScreeningTime.Size = new System.Drawing.Size(217, 45);
            this.dtpScreeningTime.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbRoom);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnAddSceen);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Location = new System.Drawing.Point(14, 14);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(735, 625);
            this.panel3.TabIndex = 89;
            // 
            // cbRoom
            // 
            this.cbRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Location = new System.Drawing.Point(274, 169);
            this.cbRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(360, 40);
            this.cbRoom.TabIndex = 105;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 40);
            this.label2.TabIndex = 104;
            this.label2.Text = "Phòng chiếu";
            // 
            // btnAddSceen
            // 
            this.btnAddSceen.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddSceen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSceen.ForeColor = System.Drawing.Color.White;
            this.btnAddSceen.Location = new System.Drawing.Point(413, 476);
            this.btnAddSceen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSceen.Name = "btnAddSceen";
            this.btnAddSceen.Size = new System.Drawing.Size(129, 54);
            this.btnAddSceen.TabIndex = 84;
            this.btnAddSceen.Text = "Thêm";
            this.btnAddSceen.UseVisualStyleBackColor = false;
            this.btnAddSceen.Click += new System.EventHandler(this.btnAddSceen_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(561, 476);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 54);
            this.btnClose.TabIndex = 87;
            this.btnClose.Text = "Hủy";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblGioChieu);
            this.panel5.Controls.Add(this.dtpScreeningTime);
            this.panel5.Location = new System.Drawing.Point(6, 315);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(729, 69);
            this.panel5.TabIndex = 103;
            // 
            // lblGioChieu
            // 
            this.lblGioChieu.AutoSize = true;
            this.lblGioChieu.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioChieu.Location = new System.Drawing.Point(91, 19);
            this.lblGioChieu.Name = "lblGioChieu";
            this.lblGioChieu.Size = new System.Drawing.Size(146, 40);
            this.lblGioChieu.TabIndex = 79;
            this.lblGioChieu.Text = "Giờ Chiếu";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtpSceeningDate);
            this.panel4.Controls.Add(this.lblNgayChieu);
            this.panel4.Location = new System.Drawing.Point(6, 229);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(729, 69);
            this.panel4.TabIndex = 102;
            // 
            // dtpSceeningDate
            // 
            this.dtpSceeningDate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSceeningDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSceeningDate.Location = new System.Drawing.Point(269, 12);
            this.dtpSceeningDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpSceeningDate.Name = "dtpSceeningDate";
            this.dtpSceeningDate.Size = new System.Drawing.Size(217, 45);
            this.dtpSceeningDate.TabIndex = 85;
            // 
            // lblNgayChieu
            // 
            this.lblNgayChieu.AutoSize = true;
            this.lblNgayChieu.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayChieu.Location = new System.Drawing.Point(69, 18);
            this.lblNgayChieu.Name = "lblNgayChieu";
            this.lblNgayChieu.Size = new System.Drawing.Size(169, 40);
            this.lblNgayChieu.TabIndex = 78;
            this.lblNgayChieu.Text = "Ngày Chiếu";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbMovieName);
            this.panel7.Controls.Add(this.lblTenPhim);
            this.panel7.Location = new System.Drawing.Point(4, 80);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(729, 69);
            this.panel7.TabIndex = 101;
            // 
            // cbMovieName
            // 
            this.cbMovieName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMovieName.FormattingEnabled = true;
            this.cbMovieName.Location = new System.Drawing.Point(269, 14);
            this.cbMovieName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMovieName.Name = "cbMovieName";
            this.cbMovieName.Size = new System.Drawing.Size(360, 40);
            this.cbMovieName.TabIndex = 78;
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = true;
            this.lblTenPhim.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhim.Location = new System.Drawing.Point(100, 14);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(138, 40);
            this.lblTenPhim.TabIndex = 77;
            this.lblTenPhim.Text = "Tên Phim";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(114)))));
            this.panel9.Controls.Add(this.label1);
            this.panel9.Location = new System.Drawing.Point(3, 2);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(729, 69);
            this.panel9.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM SUẤT CHIẾU";
            // 
            // frmAddScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 651);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmAddScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form thêm suất chiếu";
            this.Load += new System.EventHandler(this.frmAddScreen_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpScreeningTime;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddSceen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dtpSceeningDate;
        private System.Windows.Forms.Label lblGioChieu;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblTenPhim;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMovieName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblNgayChieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRoom;
    }
}