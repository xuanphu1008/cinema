namespace Presentation.Forms.admin.edit
{
    partial class frmViewScreen
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
            this.pnlRight = new System.Windows.Forms.Panel();
            this.panelSeat = new System.Windows.Forms.FlowLayoutPanel();
            this.lbSeat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAvailableSeats = new System.Windows.Forms.Label();
            this.lblBookedSeats = new System.Windows.Forms.Label();
            this.lblTotalSeats = new System.Windows.Forms.Label();
            this.lblSeatListTitle = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblScreeningDetails = new System.Windows.Forms.Label();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbRoom = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbMovieName = new System.Windows.Forms.Label();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.panelSeat);
            this.pnlRight.Controls.Add(this.lbSeat);
            this.pnlRight.Controls.Add(this.panel1);
            this.pnlRight.Controls.Add(this.pictureBox1);
            this.pnlRight.Controls.Add(this.lblAvailableSeats);
            this.pnlRight.Controls.Add(this.lblBookedSeats);
            this.pnlRight.Controls.Add(this.lblTotalSeats);
            this.pnlRight.Controls.Add(this.lblSeatListTitle);
            this.pnlRight.Location = new System.Drawing.Point(263, 0);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(637, 616);
            this.pnlRight.TabIndex = 3;
            // 
            // panelSeat
            // 
            this.panelSeat.Location = new System.Drawing.Point(19, 123);
            this.panelSeat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelSeat.Name = "panelSeat";
            this.panelSeat.Size = new System.Drawing.Size(600, 482);
            this.panelSeat.TabIndex = 14;
            // 
            // lbSeat
            // 
            this.lbSeat.AutoSize = true;
            this.lbSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeat.Location = new System.Drawing.Point(136, 20);
            this.lbSeat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSeat.Name = "lbSeat";
            this.lbSeat.Size = new System.Drawing.Size(51, 20);
            this.lbSeat.TabIndex = 13;
            this.lbSeat.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(294, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 25);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(92, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblAvailableSeats
            // 
            this.lblAvailableSeats.AutoSize = true;
            this.lblAvailableSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableSeats.Location = new System.Drawing.Point(197, 49);
            this.lblAvailableSeats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailableSeats.Name = "lblAvailableSeats";
            this.lblAvailableSeats.Size = new System.Drawing.Size(98, 24);
            this.lblAvailableSeats.TabIndex = 8;
            this.lblAvailableSeats.Text = "Còn trống:";
            // 
            // lblBookedSeats
            // 
            this.lblBookedSeats.AutoSize = true;
            this.lblBookedSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookedSeats.Location = new System.Drawing.Point(22, 49);
            this.lblBookedSeats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookedSeats.Name = "lblBookedSeats";
            this.lblBookedSeats.Size = new System.Drawing.Size(69, 24);
            this.lblBookedSeats.TabIndex = 7;
            this.lblBookedSeats.Text = "Đã đặt:";
            // 
            // lblTotalSeats
            // 
            this.lblTotalSeats.AutoSize = true;
            this.lblTotalSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSeats.Location = new System.Drawing.Point(15, 16);
            this.lblTotalSeats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalSeats.Name = "lblTotalSeats";
            this.lblTotalSeats.Size = new System.Drawing.Size(123, 24);
            this.lblTotalSeats.TabIndex = 6;
            this.lblTotalSeats.Text = "Tổng số ghế:";
            // 
            // lblSeatListTitle
            // 
            this.lblSeatListTitle.AutoSize = true;
            this.lblSeatListTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatListTitle.Location = new System.Drawing.Point(15, 98);
            this.lblSeatListTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeatListTitle.Name = "lblSeatListTitle";
            this.lblSeatListTitle.Size = new System.Drawing.Size(151, 24);
            this.lblSeatListTitle.TabIndex = 9;
            this.lblSeatListTitle.Text = "Danh sách ghế";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(22, 272);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(129, 24);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Ca suất chiếu:";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(15, 215);
            this.lblRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(128, 24);
            this.lblRoom.TabIndex = 3;
            this.lblRoom.Text = " Phòng chiếu:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(15, 162);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(116, 24);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = " Ngày chiếu:";
            // 
            // lblScreeningDetails
            // 
            this.lblScreeningDetails.AutoSize = true;
            this.lblScreeningDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreeningDetails.Location = new System.Drawing.Point(15, 98);
            this.lblScreeningDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScreeningDetails.Name = "lblScreeningDetails";
            this.lblScreeningDetails.Size = new System.Drawing.Size(176, 24);
            this.lblScreeningDetails.TabIndex = 1;
            this.lblScreeningDetails.Text = "Chi tiết suất chiếu";
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieTitle.Location = new System.Drawing.Point(15, 16);
            this.lblMovieTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(105, 24);
            this.lblMovieTitle.TabIndex = 0;
            this.lblMovieTitle.Text = "Tên phim:";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.lbTime);
            this.pnlLeft.Controls.Add(this.lbRoom);
            this.pnlLeft.Controls.Add(this.lbDate);
            this.pnlLeft.Controls.Add(this.lbMovieName);
            this.pnlLeft.Controls.Add(this.lblTime);
            this.pnlLeft.Controls.Add(this.lblRoom);
            this.pnlLeft.Controls.Add(this.lblDate);
            this.pnlLeft.Controls.Add(this.lblScreeningDetails);
            this.pnlLeft.Controls.Add(this.lblMovieTitle);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(263, 616);
            this.pnlLeft.TabIndex = 2;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(149, 274);
            this.lbTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(51, 20);
            this.lbTime.TabIndex = 8;
            this.lbTime.Text = "label1";
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoom.Location = new System.Drawing.Point(139, 218);
            this.lbRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(51, 20);
            this.lbRoom.TabIndex = 7;
            this.lbRoom.Text = "label1";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(139, 166);
            this.lbDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(51, 20);
            this.lbDate.TabIndex = 6;
            this.lbDate.Text = "label1";
            // 
            // lbMovieName
            // 
            this.lbMovieName.AutoSize = true;
            this.lbMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMovieName.Location = new System.Drawing.Point(29, 47);
            this.lbMovieName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMovieName.Name = "lbMovieName";
            this.lbMovieName.Size = new System.Drawing.Size(51, 20);
            this.lbMovieName.TabIndex = 0;
            this.lbMovieName.Text = "label1";
            // 
            // frmViewScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 616);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmViewScreen";
            this.Text = "frmViewScreencs";
            this.Load += new System.EventHandler(this.frmViewScreen_Load);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAvailableSeats;
        private System.Windows.Forms.Label lblBookedSeats;
        private System.Windows.Forms.Label lblTotalSeats;
        private System.Windows.Forms.Label lblSeatListTitle;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblScreeningDetails;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lbMovieName;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbSeat;
        private System.Windows.Forms.FlowLayoutPanel panelSeat;
    }
}