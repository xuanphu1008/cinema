namespace Presentation
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnScreening = new System.Windows.Forms.Button();
            this.btnFilm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(114)))));
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(253, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(858, 64);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(308, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(254, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ PHIM";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnRevenue);
            this.panelMenu.Controls.Add(this.btnCustomer);
            this.panelMenu.Controls.Add(this.btnEmployee);
            this.panelMenu.Controls.Add(this.btnProduct);
            this.panelMenu.Controls.Add(this.btnScreening);
            this.panelMenu.Controls.Add(this.btnFilm);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(253, 597);
            this.panelMenu.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 544);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(253, 53);
            this.btnLogout.TabIndex = 24;
            this.btnLogout.Text = "    Đăng xuất";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.btnRevenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRevenue.FlatAppearance.BorderSize = 0;
            this.btnRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenue.ForeColor = System.Drawing.Color.White;
            this.btnRevenue.Image = ((System.Drawing.Image)(resources.GetObject("btnRevenue.Image")));
            this.btnRevenue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevenue.Location = new System.Drawing.Point(0, 289);
            this.btnRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRevenue.Size = new System.Drawing.Size(253, 45);
            this.btnRevenue.TabIndex = 18;
            this.btnRevenue.Text = "  Thống kê doanh số";
            this.btnRevenue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRevenue.UseVisualStyleBackColor = false;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(0, 244);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(253, 45);
            this.btnCustomer.TabIndex = 19;
            this.btnCustomer.Text = "  Quản lý khách hàng";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(0, 199);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(253, 45);
            this.btnEmployee.TabIndex = 20;
            this.btnEmployee.Text = "  Quản lý nhân viên";
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 154);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnProduct.Size = new System.Drawing.Size(253, 45);
            this.btnProduct.TabIndex = 21;
            this.btnProduct.Text = "  Quản lý sản phẩm";
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnScreening
            // 
            this.btnScreening.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.btnScreening.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScreening.FlatAppearance.BorderSize = 0;
            this.btnScreening.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScreening.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreening.ForeColor = System.Drawing.Color.White;
            this.btnScreening.Image = ((System.Drawing.Image)(resources.GetObject("btnScreening.Image")));
            this.btnScreening.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScreening.Location = new System.Drawing.Point(0, 109);
            this.btnScreening.Margin = new System.Windows.Forms.Padding(2);
            this.btnScreening.Name = "btnScreening";
            this.btnScreening.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnScreening.Size = new System.Drawing.Size(253, 45);
            this.btnScreening.TabIndex = 22;
            this.btnScreening.Text = "  Quản lý suất chiếu";
            this.btnScreening.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScreening.UseVisualStyleBackColor = false;
            this.btnScreening.Click += new System.EventHandler(this.btnScreening_Click);
            // 
            // btnFilm
            // 
            this.btnFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.btnFilm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilm.FlatAppearance.BorderSize = 0;
            this.btnFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilm.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilm.ForeColor = System.Drawing.Color.White;
            this.btnFilm.Image = ((System.Drawing.Image)(resources.GetObject("btnFilm.Image")));
            this.btnFilm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilm.Location = new System.Drawing.Point(0, 64);
            this.btnFilm.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnFilm.Size = new System.Drawing.Size(253, 45);
            this.btnFilm.TabIndex = 17;
            this.btnFilm.Text = "  Quản lý phim";
            this.btnFilm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilm.UseVisualStyleBackColor = false;
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.lblMainMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 64);
            this.panel1.TabIndex = 8;
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.ForeColor = System.Drawing.Color.White;
            this.lblMainMenu.Location = new System.Drawing.Point(83, 12);
            this.lblMainMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(77, 32);
            this.lblMainMenu.TabIndex = 0;
            this.lblMainMenu.Text = "Menu";
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(253, 64);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(858, 533);
            this.pnlDesktop.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 597);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý Rạp chiếu phim - 4SCinema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.pnlTitle.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnScreening;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.Button btnLogout;
    }
}

