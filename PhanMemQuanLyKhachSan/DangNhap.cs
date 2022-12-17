﻿using PhanMemQuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace PhanMemQuanLyKhachSan
{
    public partial class frmDangNhap : Form
    {
        public object Messagebox { get; private set; }

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void txtTendangnhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "Tên đăng nhập")
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor = Color.Black;
            }
        }

        private void txtTendangnhap_Leave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                txtTenDangNhap.Text = "Tên đăng nhập";
                txtTenDangNhap.ForeColor = Color.Silver;
            }
        }

        private void txtMatkhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.UseSystemPasswordChar = true;
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
            }
        }

        private void txtMatkhau_Leave(object sender, EventArgs e)
        {

            if (txtMatKhau.Text == "")
            {
                txtMatKhau.UseSystemPasswordChar = false;
                txtMatKhau.Text = "Mật khẩu";
                txtMatKhau.ForeColor = Color.Silver;
            }
        }

        private void btnHienmatkhau_MouseDown(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = false;
        }

        private void btnHienmatkhau_MouseUp(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
        }


        private void BtnDangNhap_Click(object sender, EventArgs e)
        {




            string connection = @"Server=DESKTOP-BRSAPG5\SQLEXPRESS; Database=PMQLKS;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from MatKhau where username='" + txtTenDangNhap.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            MatKhau obj = new MatKhau();// gọi đến class mật khẩu
            List<MatKhau> list = obj.GetAll();

            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            var check = list.Where(item => item.username.Equals(tenDangNhap)).ToList();

            if (check.Count > 0)
            {
                if (check[0].password.Equals(matKhau) && (dr.Read()))
                {
                    frmManHinhChinh mhc = new frmManHinhChinh();
                    MessageBox.Show("Xin chào"+" "+"'"+dr.GetValue(0).ToString()+"'");
                    mhc.Show();
                    this.Hide();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Mật khẩu sai!");
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại tài khoan!");
            }
        }
        private void ClearData()
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy frmDangKy = new frmDangKy();
            this.Hide();
            frmDangKy.Show();
        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            frmForgot frmForgot = new frmForgot();
            this.Hide();
            frmForgot.Show();
            
        }


        private void btnHienMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void lblChuaCoTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void pnlMatKhau_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void picTenDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void pnlTenDangNhap_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void lblDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoát ứng dụng?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}