namespace Presentation.Forms
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
            this.menuListControl1 = new Presentation.Controls.MenuListControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.dtpScreeningDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAllRoom = new System.Windows.Forms.Button();
            this.btnRoom5 = new System.Windows.Forms.Button();
            this.btnRoom4 = new System.Windows.Forms.Button();
            this.btnRoom3 = new System.Windows.Forms.Button();
            this.btnRoom2 = new System.Windows.Forms.Button();
            this.btnRoom1 = new System.Windows.Forms.Button();
            this.colEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colPhongChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSceeningTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvScreenings = new System.Windows.Forms.DataGridView();
            this.colScreeningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreenings)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuListControl1
            // 
            this.menuListControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.menuListControl1.Location = new System.Drawing.Point(13, 15);
            this.menuListControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuListControl1.Name = "menuListControl1";
            this.menuListControl1.Size = new System.Drawing.Size(372, 914);
            this.menuListControl1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(114)))));
            this.panel2.Controls.Add(this.lblHeader);
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 66);
            this.panel2.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(529, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(284, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "QUẢN LÝ SUẤT CHIẾU";
            // 
            // dtpScreeningDate
            // 
            this.dtpScreeningDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpScreeningDate.CustomFormat = "dd / MM / yyyy";
            this.dtpScreeningDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpScreeningDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpScreeningDate.Location = new System.Drawing.Point(873, 22);
            this.dtpScreeningDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpScreeningDate.Name = "dtpScreeningDate";
            this.dtpScreeningDate.Size = new System.Drawing.Size(180, 31);
            this.dtpScreeningDate.TabIndex = 2;
            this.dtpScreeningDate.Value = new System.DateTime(2024, 10, 10, 0, 0, 0, 0);
            this.dtpScreeningDate.ValueChanged += new System.EventHandler(this.dtpScreeningDate_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(442, 22);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(143, 22);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(276, 31);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtpScreeningDate);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Location = new System.Drawing.Point(3, 78);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1254, 108);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAllRoom);
            this.panel4.Controls.Add(this.btnRoom5);
            this.panel4.Controls.Add(this.btnRoom4);
            this.panel4.Controls.Add(this.btnRoom3);
            this.panel4.Controls.Add(this.btnRoom2);
            this.panel4.Controls.Add(this.btnRoom1);
            this.panel4.Location = new System.Drawing.Point(3, 192);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(136, 368);
            this.panel4.TabIndex = 2;
            // 
            // btnAllRoom
            // 
            this.btnAllRoom.BackColor = System.Drawing.Color.White;
            this.btnAllRoom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAllRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllRoom.Location = new System.Drawing.Point(3, 4);
            this.btnAllRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAllRoom.Name = "btnAllRoom";
            this.btnAllRoom.Size = new System.Drawing.Size(129, 42);
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
            this.btnRoom5.Location = new System.Drawing.Point(3, 312);
            this.btnRoom5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRoom5.Name = "btnRoom5";
            this.btnRoom5.Size = new System.Drawing.Size(129, 42);
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
            this.btnRoom4.Location = new System.Drawing.Point(3, 250);
            this.btnRoom4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRoom4.Name = "btnRoom4";
            this.btnRoom4.Size = new System.Drawing.Size(129, 42);
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
            this.btnRoom3.Location = new System.Drawing.Point(3, 188);
            this.btnRoom3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRoom3.Name = "btnRoom3";
            this.btnRoom3.Size = new System.Drawing.Size(129, 42);
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
            this.btnRoom2.Location = new System.Drawing.Point(3, 125);
            this.btnRoom2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRoom2.Name = "btnRoom2";
            this.btnRoom2.Size = new System.Drawing.Size(129, 42);
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
            this.btnRoom1.Location = new System.Drawing.Point(3, 70);
            this.btnRoom1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRoom1.Name = "btnRoom1";
            this.btnRoom1.Size = new System.Drawing.Size(129, 42);
            this.btnRoom1.TabIndex = 0;
            this.btnRoom1.Text = "Phòng 1";
            this.btnRoom1.UseVisualStyleBackColor = false;
            this.btnRoom1.Click += new System.EventHandler(this.btnRoom1_Click);
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
            // colPhongChieu
            // 
            this.colPhongChieu.HeaderText = "Phòng Chiếu";
            this.colPhongChieu.MinimumWidth = 6;
            this.colPhongChieu.Name = "colPhongChieu";
            this.colPhongChieu.ReadOnly = true;
            this.colPhongChieu.Width = 125;
            // 
            // colSceeningTime
            // 
            this.colSceeningTime.HeaderText = "Giờ Chiếu";
            this.colSceeningTime.MinimumWidth = 6;
            this.colSceeningTime.Name = "colSceeningTime";
            this.colSceeningTime.ReadOnly = true;
            this.colSceeningTime.Width = 125;
            // 
            // colDuration
            // 
            this.colDuration.HeaderText = "Thời Lượng";
            this.colDuration.MinimumWidth = 6;
            this.colDuration.Name = "colDuration";
            this.colDuration.ReadOnly = true;
            this.colDuration.Width = 125;
            // 
            // colGenre
            // 
            this.colGenre.HeaderText = "Thể loại";
            this.colGenre.MinimumWidth = 6;
            this.colGenre.Name = "colGenre";
            this.colGenre.ReadOnly = true;
            this.colGenre.Width = 150;
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Tên Phim";
            this.colTitle.MinimumWidth = 6;
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.Width = 250;
            // 
            // colId
            // 
            this.colId.HeaderText = "Mã suất chiếu";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 125;
            // 
            // dgvScreenings
            // 
            this.dgvScreenings.AllowUserToAddRows = false;
            this.dgvScreenings.AllowUserToDeleteRows = false;
            this.dgvScreenings.BackgroundColor = System.Drawing.Color.White;
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
            this.dgvScreenings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvScreenings.Location = new System.Drawing.Point(0, 0);
            this.dgvScreenings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvScreenings.Name = "dgvScreenings";
            this.dgvScreenings.ReadOnly = true;
            this.dgvScreenings.RowHeadersVisible = false;
            this.dgvScreenings.RowHeadersWidth = 51;
            this.dgvScreenings.RowTemplate.Height = 24;
            this.dgvScreenings.Size = new System.Drawing.Size(1112, 716);
            this.dgvScreenings.TabIndex = 0;
            this.dgvScreenings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScreenings_CellContentClick);
            // 
            // colScreeningDate
            // 
            this.colScreeningDate.HeaderText = "Ngày chiếu";
            this.colScreeningDate.MinimumWidth = 6;
            this.colScreeningDate.Name = "colScreeningDate";
            this.colScreeningDate.ReadOnly = true;
            this.colScreeningDate.Width = 125;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvScreenings);
            this.panel5.Location = new System.Drawing.Point(146, 192);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1112, 716);
            this.panel5.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(392, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 912);
            this.panel1.TabIndex = 7;
            // 
            // frmScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 945);
            this.Controls.Add(this.menuListControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmScreen";
            this.Text = "frmScreen";
            this.Load += new System.EventHandler(this.frmScreen_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreenings)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MenuListControl menuListControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DateTimePicker dtpScreeningDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAllRoom;
        private System.Windows.Forms.Button btnRoom5;
        private System.Windows.Forms.Button btnRoom4;
        private System.Windows.Forms.Button btnRoom3;
        private System.Windows.Forms.Button btnRoom2;
        private System.Windows.Forms.Button btnRoom1;
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhongChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSceeningTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridView dgvScreenings;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScreeningDate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
    }
}