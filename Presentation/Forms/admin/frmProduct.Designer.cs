namespace Presentation.Forms.admin
{
    partial class frmProduct
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearchh = new Presentation.Controls.ButtonDS();
            this.btnAddd = new Presentation.Controls.ButtonDS();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.menuStrip1);
            this.panel4.Controls.Add(this.dgvProduct);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 84);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1119, 525);
            this.panel4.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileExcelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 501);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1119, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "Xuất file excel";
            // 
            // FileExcelToolStripMenuItem
            // 
            this.FileExcelToolStripMenuItem.Name = "FileExcelToolStripMenuItem";
            this.FileExcelToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.FileExcelToolStripMenuItem.Text = "Xuất file excel";
            this.FileExcelToolStripMenuItem.Click += new System.EventHandler(this.FileExcelToolStripMenuItem_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 62;
            this.dgvProduct.RowTemplate.Height = 28;
            this.dgvProduct.Size = new System.Drawing.Size(1119, 525);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSearchh);
            this.panel3.Controls.Add(this.btnAddd);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1119, 84);
            this.panel3.TabIndex = 12;
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
            this.btnSearchh.Location = new System.Drawing.Point(644, 27);
            this.btnSearchh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchh.Name = "btnSearchh";
            this.btnSearchh.Size = new System.Drawing.Size(145, 38);
            this.btnSearchh.TabIndex = 4;
            this.btnSearchh.Text = "Tìm kiếm";
            this.btnSearchh.TextColor = System.Drawing.Color.White;
            this.btnSearchh.UseVisualStyleBackColor = false;
            this.btnSearchh.Click += new System.EventHandler(this.btnSearchh_Click);
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
            this.btnAddd.Location = new System.Drawing.Point(16, 27);
            this.btnAddd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddd.Name = "btnAddd";
            this.btnAddd.Size = new System.Drawing.Size(113, 38);
            this.btnAddd.TabIndex = 3;
            this.btnAddd.Text = "Thêm";
            this.btnAddd.TextColor = System.Drawing.Color.White;
            this.btnAddd.UseVisualStyleBackColor = false;
            this.btnAddd.Click += new System.EventHandler(this.btnAddd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(796, 26);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(307, 37);
            this.txtSearch.TabIndex = 0;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 609);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ SẢN PHẨM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearch;
        private Controls.ButtonDS btnAddd;
        private Controls.ButtonDS btnSearchh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileExcelToolStripMenuItem;
    }
}