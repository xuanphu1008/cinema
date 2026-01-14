namespace Presentation.Forms.admin
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddd = new Presentation.Controls.ButtonDS();
            this.btnSearchh = new Presentation.Controls.ButtonDS();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPagination = new System.Windows.Forms.Label();
            this.btnPrevious = new Presentation.Controls.ButtonDS();
            this.btnNext = new Presentation.Controls.ButtonDS();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployee.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.EnableHeadersVisualStyles = false;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 82);
            this.dgvEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 62;
            this.dgvEmployee.RowTemplate.Height = 28;
            this.dgvEmployee.Size = new System.Drawing.Size(1119, 527);
            this.dgvEmployee.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddd);
            this.panel3.Controls.Add(this.btnSearchh);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1119, 82);
            this.panel3.TabIndex = 10;
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
            this.btnAddd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddd.Location = new System.Drawing.Point(16, 22);
            this.btnAddd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddd.Name = "btnAddd";
            this.btnAddd.Size = new System.Drawing.Size(113, 38);
            this.btnAddd.TabIndex = 5;
            this.btnAddd.Text = "Thêm";
            this.btnAddd.TextColor = System.Drawing.Color.White;
            this.btnAddd.UseVisualStyleBackColor = false;
            this.btnAddd.Click += new System.EventHandler(this.btnAddd_Click);
            // 
            // btnSearchh
            // 
            this.btnSearchh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchh.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSearchh.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSearchh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearchh.BorderRadius = 5;
            this.btnSearchh.BorderSize = 0;
            this.btnSearchh.FlatAppearance.BorderSize = 0;
            this.btnSearchh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchh.ForeColor = System.Drawing.Color.White;
            this.btnSearchh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchh.Location = new System.Drawing.Point(640, 25);
            this.btnSearchh.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchh.Name = "btnSearchh";
            this.btnSearchh.Size = new System.Drawing.Size(145, 38);
            this.btnSearchh.TabIndex = 5;
            this.btnSearchh.Text = "Tìm kiếm";
            this.btnSearchh.TextColor = System.Drawing.Color.White;
            this.btnSearchh.UseVisualStyleBackColor = false;
            this.btnSearchh.Click += new System.EventHandler(this.btnSearchh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(792, 25);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(316, 37);
            this.txtSearch.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileExcelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 579);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1119, 30);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "Xuất file excel";
            // 
            // FileExcelToolStripMenuItem
            // 
            this.FileExcelToolStripMenuItem.Name = "FileExcelToolStripMenuItem";
            this.FileExcelToolStripMenuItem.Size = new System.Drawing.Size(111, 28);
            this.FileExcelToolStripMenuItem.Text = "Xuất file excel";
            this.FileExcelToolStripMenuItem.Click += new System.EventHandler(this.FileExcelToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblPagination);
            this.panel2.Controls.Add(this.btnPrevious);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Location = new System.Drawing.Point(0, 526);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 55);
            this.panel2.TabIndex = 12;
            // 
            // lblPagination
            // 
            this.lblPagination.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPagination.AutoSize = true;
            this.lblPagination.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPagination.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPagination.Location = new System.Drawing.Point(524, 20);
            this.lblPagination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPagination.Name = "lblPagination";
            this.lblPagination.Size = new System.Drawing.Size(50, 19);
            this.lblPagination.TabIndex = 4;
            this.lblPagination.Text = "Trang";
            this.lblPagination.Click += new System.EventHandler(this.lblPagination_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrevious.BackColor = System.Drawing.Color.White;
            this.btnPrevious.BackgroundColor = System.Drawing.Color.White;
            this.btnPrevious.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPrevious.BorderRadius = 8;
            this.btnPrevious.BorderSize = 0;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrevious.Location = new System.Drawing.Point(488, 20);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(37, 21);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.TextColor = System.Drawing.Color.White;
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.BackgroundColor = System.Drawing.Color.White;
            this.btnNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNext.BorderRadius = 8;
            this.btnNext.BorderSize = 0;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNext.Location = new System.Drawing.Point(597, 20);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(37, 21);
            this.btnNext.TabIndex = 3;
            this.btnNext.TextColor = System.Drawing.Color.White;
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 609);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEmployee";
            this.Text = "QUẢN LÝ NHÂN VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearch;
        private Controls.ButtonDS btnSearchh;
        private Controls.ButtonDS btnAddd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileExcelToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPagination;
        private Controls.ButtonDS btnPrevious;
        private Controls.ButtonDS btnNext;
    }
}