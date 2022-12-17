namespace PhanMemQuanLyKhachSan
{
    partial class frmDangNhap
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
            this.pnlTenDangNhap = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnQuenMatKhau = new System.Windows.Forms.Button();
            this.lblChuaCoTaiKhoan = new System.Windows.Forms.Label();
            this.btnDangKyTai = new System.Windows.Forms.Button();
            this.pnlMatKhau = new System.Windows.Forms.Panel();
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.picMatKhau = new System.Windows.Forms.PictureBox();
            this.picTenDangNhap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTenDangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTenDangNhap
            // 
            this.pnlTenDangNhap.BackColor = System.Drawing.Color.DarkRed;
            this.pnlTenDangNhap.ForeColor = System.Drawing.Color.Peru;
            this.pnlTenDangNhap.Location = new System.Drawing.Point(92, 249);
            this.pnlTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTenDangNhap.Name = "pnlTenDangNhap";
            this.pnlTenDangNhap.Size = new System.Drawing.Size(375, 2);
            this.pnlTenDangNhap.TabIndex = 2;
            this.pnlTenDangNhap.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTenDangNhap_Paint);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.SystemColors.Control;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.Maroon;
            this.txtMatKhau.Location = new System.Drawing.Point(92, 281);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(373, 30);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.Text = "Mật khẩu";
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            this.txtMatKhau.Enter += new System.EventHandler(this.txtMatkhau_Enter);
            this.txtMatKhau.Leave += new System.EventHandler(this.txtMatkhau_Leave);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.IndianRed;
            this.btnDangNhap.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(138, 379);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(221, 46);
            this.btnDangNhap.TabIndex = 8;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // btnQuenMatKhau
            // 
            this.btnQuenMatKhau.BackColor = System.Drawing.Color.IndianRed;
            this.btnQuenMatKhau.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuenMatKhau.Location = new System.Drawing.Point(138, 448);
            this.btnQuenMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuenMatKhau.Name = "btnQuenMatKhau";
            this.btnQuenMatKhau.Size = new System.Drawing.Size(221, 46);
            this.btnQuenMatKhau.TabIndex = 9;
            this.btnQuenMatKhau.Text = "Quên mật khẩu";
            this.btnQuenMatKhau.UseVisualStyleBackColor = false;
            this.btnQuenMatKhau.Click += new System.EventHandler(this.btnQuenMatKhau_Click);
            // 
            // lblChuaCoTaiKhoan
            // 
            this.lblChuaCoTaiKhoan.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuaCoTaiKhoan.ForeColor = System.Drawing.SystemColors.Window;
            this.lblChuaCoTaiKhoan.Location = new System.Drawing.Point(138, 520);
            this.lblChuaCoTaiKhoan.Name = "lblChuaCoTaiKhoan";
            this.lblChuaCoTaiKhoan.Size = new System.Drawing.Size(221, 33);
            this.lblChuaCoTaiKhoan.TabIndex = 10;
            this.lblChuaCoTaiKhoan.Text = "Chưa có tài khoản?";
            this.lblChuaCoTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChuaCoTaiKhoan.Click += new System.EventHandler(this.lblChuaCoTaiKhoan_Click);
            // 
            // btnDangKyTai
            // 
            this.btnDangKyTai.BackColor = System.Drawing.Color.IndianRed;
            this.btnDangKyTai.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKyTai.Location = new System.Drawing.Point(129, 569);
            this.btnDangKyTai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangKyTai.Name = "btnDangKyTai";
            this.btnDangKyTai.Size = new System.Drawing.Size(248, 46);
            this.btnDangKyTai.TabIndex = 11;
            this.btnDangKyTai.Text = "Đăng ký tài khoản";
            this.btnDangKyTai.UseVisualStyleBackColor = false;
            this.btnDangKyTai.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // pnlMatKhau
            // 
            this.pnlMatKhau.BackColor = System.Drawing.Color.DarkRed;
            this.pnlMatKhau.ForeColor = System.Drawing.Color.Peru;
            this.pnlMatKhau.Location = new System.Drawing.Point(95, 309);
            this.pnlMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMatKhau.Name = "pnlMatKhau";
            this.pnlMatKhau.Size = new System.Drawing.Size(375, 2);
            this.pnlMatKhau.TabIndex = 12;
            this.pnlMatKhau.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMatKhau_Paint);
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lblDangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDangNhap.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangNhap.ForeColor = System.Drawing.Color.Crimson;
            this.lblDangNhap.Location = new System.Drawing.Point(0, 0);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(487, 185);
            this.lblDangNhap.TabIndex = 0;
            this.lblDangNhap.Text = "HAPPY HOTEL🎶";
            this.lblDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDangNhap.Click += new System.EventHandler(this.lblDangNhap_Click);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.SystemColors.Control;
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.Maroon;
            this.txtTenDangNhap.Location = new System.Drawing.Point(92, 219);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(375, 30);
            this.txtTenDangNhap.TabIndex = 1;
            this.txtTenDangNhap.Text = "Tên đăng nhập";
            this.txtTenDangNhap.TextChanged += new System.EventHandler(this.txtTenDangNhap_TextChanged);
            this.txtTenDangNhap.Enter += new System.EventHandler(this.txtTendangnhap_Enter);
            this.txtTenDangNhap.Leave += new System.EventHandler(this.txtTendangnhap_Leave);
            // 
            // picMatKhau
            // 
            this.picMatKhau.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconPassword;
            this.picMatKhau.Location = new System.Drawing.Point(30, 281);
            this.picMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMatKhau.Name = "picMatKhau";
            this.picMatKhau.Size = new System.Drawing.Size(40, 38);
            this.picMatKhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMatKhau.TabIndex = 6;
            this.picMatKhau.TabStop = false;
            this.picMatKhau.Click += new System.EventHandler(this.picMatKhau_Click);
            // 
            // picTenDangNhap
            // 
            this.picTenDangNhap.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconUser;
            this.picTenDangNhap.Location = new System.Drawing.Point(30, 213);
            this.picTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picTenDangNhap.Name = "picTenDangNhap";
            this.picTenDangNhap.Size = new System.Drawing.Size(40, 36);
            this.picTenDangNhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTenDangNhap.TabIndex = 3;
            this.picTenDangNhap.TabStop = false;
            this.picTenDangNhap.Click += new System.EventHandler(this.picTenDangNhap_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(487, 641);
            this.Controls.Add(this.pnlMatKhau);
            this.Controls.Add(this.btnDangKyTai);
            this.Controls.Add(this.lblChuaCoTaiKhoan);
            this.Controls.Add(this.btnQuenMatKhau);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.picMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.picTenDangNhap);
            this.Controls.Add(this.pnlTenDangNhap);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lblDangNhap);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTenDangNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTenDangNhap;
        private System.Windows.Forms.PictureBox picTenDangNhap;
        private System.Windows.Forms.PictureBox picMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnQuenMatKhau;
        private System.Windows.Forms.Label lblChuaCoTaiKhoan;
        private System.Windows.Forms.Button btnDangKyTai;
        private System.Windows.Forms.Panel pnlMatKhau;
        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
    }
}

