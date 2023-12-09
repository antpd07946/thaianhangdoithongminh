using BUS;
using DAO;
using DTO;
using Guna.UI2.WinForms.Suite;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xamarin.Essentials;
using Xamarin.Forms.PlatformConfiguration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace hangdoi2
{
    public partial class FrmDangKy : Form
    {
        public FrmDangKy()
        {
            InitializeComponent();
            CobDanToc();
            GenerateMaNguoiDung();
            
        }

        private void FrmDangKy_Load(object sender, EventArgs e)
        {

        }


        private string GenerateMaNguoiDung()
        {
            int so = HangDoiDAO.Instance.Laysocuoi();
            return "NG" + so.ToString();
        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
             DataTable thongtin = ThongTinNguoiDungBUS.Instance.laythongtin();
            
            
            LoaiTaiKhoanDTO loaiNguoiDung = new LoaiTaiKhoanDTO
            {
                MaLoai = "LTK3",
                TenLoai = "Người Dùng"
            };
            bool gioiTinh = false;
            if (checkNu.Checked) gioiTinh = true;
            if (ValidateInput())
            {
                TaiKhoanDTO taiKhoan = new TaiKhoanDTO()
                {
                    MaNguoiDung = GenerateMaNguoiDung(),
                    LoaiNguoiDung = loaiNguoiDung,
                    TenNguoiDung = txtHoten.Text,
                    TenDangNhap = txtUserName.Text,
                    MatKhau = txtMatKhau.Text,
                    Email = txtEmail.Text,
                };
                
                ThongTinNguoiDungDTO nguoidung = new ThongTinNguoiDungDTO()
                {
                    MaNguoiDung = GenerateMaNguoiDung(),
                    HoTen = txtHoten.Text,
                    GioiTinh = gioiTinh,
                    NgaySinh = txtNgaysinh.Value,
                    DiaChi = txtDiachi.Text,
                    MaDanToc = txtDantoc.SelectedValue.ToString(),
                    MaTonGiao = "TG1",
                    MaUtien = "UT0",
                    SDT = int.Parse(txtSDT.Text),
                    Email = txtEmail.Text,
                    
                };
                TaiKhoanBUS.Instance.Themtaikhoan(taiKhoan);
                ThongTinNguoiDungBUS.Instance.ThemNguoiDung(nguoidung);

                MessageBox.Show(txtDantoc.SelectedValue.ToString());
            }
        }


        private bool ValidateInput()
        {   if (string.IsNullOrEmpty(txtUserName.Text)) { LbrUserNameErrol.Text = "Không được để trống";  return false; ; }
            if (string.IsNullOrEmpty(txtMatKhau.Text)) { lbrMKErrol.Text = "Không được để trống"; return false; ; }
            if (string.IsNullOrEmpty(txtHoten.Text)) { lbrHotenErrol.Text = "Không được để trống"; return false; };
            if (txtNgaysinh.Value == null) { }
            if (string.IsNullOrEmpty(txtDiachi.Text)) { lbrDiachiErrol.Text = "Không được để trống"; return false; };
            if ( txtDantoc.SelectedValue == null) { MessageBox.Show("chọn dân tộc", "Errol"); return false; }
            if (string.IsNullOrEmpty(txtSDT.Text)){ lbrSdtErrol.Text = "Không được để trống"; return false; }
            if (string.IsNullOrEmpty(txtEmail.Text)) { lbrEmailErrol.Text = "Không được để trống"; return false; }           
            if (!IsValidEmail(txtEmail.Text))
            {
                lbrEmailErrol.Text = "Email không đúng định dạng";
                return false;
            }

          
            if (!IsValidPhoneNumber(txtSDT.Text))
            {
                lbrSdtErrol.Text="Số điện thoại không đúng định dạng";
                return false;
            }

            return true;
        }

  
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            try
            {
                return int.TryParse(phoneNumber, out int result) && phoneNumber.Length == 10;
            }
            catch
            {
                return false;
            }
        }
        public void CobDanToc()
        {
            DanTocBUS.Instance.HienThiComboBoxDanToc(txtDantoc);
        }

        private void txtDantoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {
            lbrHotenErrol.Text = "";
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            lbrSdtErrol.Text = "";
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lbrEmailErrol.Text = "";
        }

        private void txtDiachi_TextChanged(object sender, EventArgs e)
        {
            lbrDiachiErrol.Text = "";
        }

        private void checkNu_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
