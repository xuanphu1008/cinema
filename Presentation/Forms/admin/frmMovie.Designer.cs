namespace Presentation.Forms.admin
{
    partial class frmMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovie));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnSearchh = new Presentation.Controls.ButtonDS();
            this.btnAddd = new Presentation.Controls.ButtonDS();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPagination = new System.Windows.Forms.Label();
            this.btnPrevious = new Presentation.Controls.ButtonDS();
            this.btnNext = new Presentation.Controls.ButtonDS();
            this.dgvManagerFilm = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel12.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagerFilm)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnSearchh);
            this.panel12.Controls.Add(this.btnAddd);
            this.panel12.Controls.Add(this.txtSearch);
            resources.ApplyResources(this.panel12, "panel12");
            this.panel12.Name = "panel12";
            // 
            // btnSearchh
            // 
            resources.ApplyResources(this.btnSearchh, "btnSearchh");
            this.btnSearchh.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSearchh.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSearchh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearchh.BorderRadius = 5;
            this.btnSearchh.BorderSize = 0;
            this.btnSearchh.FlatAppearance.BorderSize = 0;
            this.btnSearchh.ForeColor = System.Drawing.Color.White;
            this.btnSearchh.Name = "btnSearchh";
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
            resources.ApplyResources(this.btnAddd, "btnAddd");
            this.btnAddd.ForeColor = System.Drawing.Color.White;
            this.btnAddd.Name = "btnAddd";
            this.btnAddd.TextColor = System.Drawing.Color.White;
            this.btnAddd.UseVisualStyleBackColor = false;
            this.btnAddd.Click += new System.EventHandler(this.btnAddd_Click);
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvManagerFilm);
            this.panel1.Controls.Add(this.menuStrip1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPagination);
            this.panel2.Controls.Add(this.btnPrevious);
            this.panel2.Controls.Add(this.btnNext);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lblPagination
            // 
            resources.ApplyResources(this.lblPagination, "lblPagination");
            this.lblPagination.Name = "lblPagination";
            this.lblPagination.Click += new System.EventHandler(this.lblPagination_Click);
            // 
            // btnPrevious
            // 
            resources.ApplyResources(this.btnPrevious, "btnPrevious");
            this.btnPrevious.BackColor = System.Drawing.Color.White;
            this.btnPrevious.BackgroundColor = System.Drawing.Color.White;
            this.btnPrevious.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPrevious.BorderRadius = 8;
            this.btnPrevious.BorderSize = 0;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.TextColor = System.Drawing.Color.White;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.BackgroundColor = System.Drawing.Color.White;
            this.btnNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNext.BorderRadius = 8;
            this.btnNext.BorderSize = 0;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Name = "btnNext";
            this.btnNext.TextColor = System.Drawing.Color.White;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dgvManagerFilm
            // 
            this.dgvManagerFilm.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManagerFilm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManagerFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvManagerFilm.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dgvManagerFilm, "dgvManagerFilm");
            this.dgvManagerFilm.EnableHeadersVisualStyles = false;
            this.dgvManagerFilm.Name = "dgvManagerFilm";
            this.dgvManagerFilm.RowTemplate.Height = 28;
            this.dgvManagerFilm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManagerFilm_CellContentClick);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileExcelToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // FileExcelToolStripMenuItem
            // 
            this.FileExcelToolStripMenuItem.Name = "FileExcelToolStripMenuItem";
            resources.ApplyResources(this.FileExcelToolStripMenuItem, "FileExcelToolStripMenuItem");
            this.FileExcelToolStripMenuItem.Click += new System.EventHandler(this.FileExcelToolStripMenuItem_Click);
            // 
            // frmMovie
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel12);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMovie";
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagerFilm)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvManagerFilm;
        private Controls.ButtonDS btnAddd;
        private Controls.ButtonDS btnSearchh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPagination;
        private Controls.ButtonDS btnPrevious;
        private Controls.ButtonDS btnNext;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileExcelToolStripMenuItem;
    }
}