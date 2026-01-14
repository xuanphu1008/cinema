namespace Presentation.Forms.admin
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearchh = new Presentation.Controls.ButtonDS();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPagination = new System.Windows.Forms.Label();
            this.btnPrevious = new Presentation.Controls.ButtonDS();
            this.btnNext = new Presentation.Controls.ButtonDS();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSearchh);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(839, 64);
            this.panel3.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileExcelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 407);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "Xuất file excel";
            // 
            // FileExcelToolStripMenuItem
            // 
            this.FileExcelToolStripMenuItem.Name = "FileExcelToolStripMenuItem";
            this.FileExcelToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.FileExcelToolStripMenuItem.Text = "Xuất file excel";
            this.FileExcelToolStripMenuItem.Click += new System.EventHandler(this.FileExcelToolStripMenuItem_Click);
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
            this.btnSearchh.Location = new System.Drawing.Point(475, 17);
            this.btnSearchh.Name = "btnSearchh";
            this.btnSearchh.Size = new System.Drawing.Size(109, 31);
            this.btnSearchh.TabIndex = 2;
            this.btnSearchh.Text = "Tìm kiếm";
            this.btnSearchh.TextColor = System.Drawing.Color.White;
            this.btnSearchh.UseVisualStyleBackColor = false;
            this.btnSearchh.Click += new System.EventHandler(this.btnSearchh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(600, 17);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(226, 31);
            this.txtSearch.TabIndex = 0;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCustomers.EnableHeadersVisualStyles = false;
            this.dgvCustomers.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 62;
            this.dgvCustomers.RowTemplate.Height = 28;
            this.dgvCustomers.Size = new System.Drawing.Size(839, 348);
            this.dgvCustomers.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvCustomers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 431);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPagination);
            this.panel2.Controls.Add(this.btnPrevious);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 45);
            this.panel2.TabIndex = 5;
            // 
            // lblPagination
            // 
            this.lblPagination.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPagination.AutoSize = true;
            this.lblPagination.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPagination.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPagination.Location = new System.Drawing.Point(393, 15);
            this.lblPagination.Name = "lblPagination";
            this.lblPagination.Size = new System.Drawing.Size(41, 17);
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
            this.btnPrevious.Location = new System.Drawing.Point(366, 16);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(28, 17);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.TextColor = System.Drawing.Color.White;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
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
            this.btnNext.Location = new System.Drawing.Point(448, 16);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(28, 17);
            this.btnNext.TabIndex = 3;
            this.btnNext.TextColor = System.Drawing.Color.White;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmCustomer";
            this.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Panel panel1;
        private Controls.ButtonDS btnSearchh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPagination;
        private Controls.ButtonDS btnPrevious;
        private Controls.ButtonDS btnNext;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileExcelToolStripMenuItem;
    }
}