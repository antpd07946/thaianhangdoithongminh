using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace hangdoi2
{

    public partial class FrmDangnhap : Form
    {
       
        public string MaTK;
        public string TenTK;
        public FrmDangnhap()
        {
            InitializeComponent();

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmDangnhap_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            while (true)
            {
                string username = txtusername.Text;
                string password = txtPassword.Text;

                if (string.IsNullOrWhiteSpace(username))
                {
                    LblUserError.Text = "";
                    lbrerr.Text = "Bạn chưa nhập tên!";
                    continue;
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    LblUserError.Text = "";
                    lbrerr.Text = "Bạn chưa nhập mật khẩu !";
                    continue;
                }

                if (TaiKhoanBUS.Instance.DangNhap(username, password))
                {
                    string maLoai = TaiKhoanBUS.Instance.TaiKhoan.LoaiNguoiDung.MaLoai;
                    if (maLoai == "LTK1")
                    {
                        FrmMain frmMain = new FrmMain(); frmMain.Show();

                    }
                    else if (maLoai == "LTK2") { FrmNhanVien frmNhanVien = new FrmNhanVien(); frmNhanVien.Show(); }
                    else if (maLoai == "LTK3")
                    {
                        FrmMainNguoiDung frmNguoiDung = new FrmMainNguoiDung(); frmNguoiDung.Show();
                       string MaTK = TaiKhoanBUS.Instance.TaiKhoan.MaNguoiDung;
                        checkform();
                    }
                        DialogResult = DialogResult.OK;

                    TenTK = TaiKhoanBUS.Instance.TaiKhoan.TenNguoiDung;
                    MaTK = TaiKhoanBUS.Instance.TaiKhoan.MaNguoiDung;
                    new MaNguoiDungDTO(MaTK);
                    LblUserError.Text = "";
                    lbrerr.Text = "";
                    
                    return;

                }
                else
                {
                    LblUserError.Text = "Thông tin không chính xác !";
                    lbrerr.Text = "Thông tin không chính xác !";
                    continue;
                }
            }
        }
        public bool checkform()
        {
            return true;
        }
        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lbrerr_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel3_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel4_Click(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            FrmLayso layso = new FrmLayso();
            layso.Show();
        }
    }
}
