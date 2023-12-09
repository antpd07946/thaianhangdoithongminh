using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangdoi2
{
    public partial class FrmQLTaiKhoan : Form
    {
        public string MaTk;
        public FrmQLTaiKhoan()
        {
            InitializeComponent();

           
        }
        private void FrmQLTaiKhoan_Load(object sender, EventArgs e)
        {
            DanTocBUS.Instance.HienThiComboBoxDanToc(txtDanToc);
            MaTk = TaiKhoanBUS.Instance.TaiKhoan.MaNguoiDung;
            ThongTinNguoiDungBUS.Instance.timnguoidung(MaTk);
            DataTable thongtin = ThongTinNguoiDungBUS.Instance.laythongtin();
            txtHoten.Text = thongtin.Rows[0]["Hoten"].ToString();
            txtDiaChi.Text = thongtin.Rows[0]["DiaChi"].ToString();
            txtNgaysinh.Value = Convert.ToDateTime(thongtin.Rows[0]["NgaySinh"]);
            txtSDT.Text = thongtin.Rows[0]["SDT"].ToString();
            CheckNu.Checked = Convert.ToBoolean(thongtin.Rows[0]["GioiTinh"]);
            txtUtien.Text = thongtin.Rows[0]["MaUtien"].ToString();
            txtDanToc.Text = thongtin.Rows[0]["MaDanToc"].ToString();
        }
        #region hàm check
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtHoten.Text)) { lbrHotenErrol.Text = "Không được để trống"; return false; };
            if (txtNgaysinh.Value == null) { }
            if (string.IsNullOrEmpty(txtDiaChi.Text)) { lbrDiachiErrol.Text = "Không được để trống"; return false; };
            if (txtDanToc.SelectedValue == null) { MessageBox.Show("chọn dân tộc", "Errol"); return false; }
            if (string.IsNullOrEmpty(txtSDT.Text)) { lbrSdtErrol.Text = "Không được để trống"; return false; }
            if (string.IsNullOrEmpty(txtEmail.Text)) { lbrEmailErrol.Text = "Không được để trống"; return false; }
            if (!IsValidEmail(txtEmail.Text))
            {
                lbrEmailErrol.Text = "Email không đúng định dạng";
                return false;
            }
            if (!IsValidPhoneNumber(txtSDT.Text))
            {
                lbrSdtErrol.Text = "Số điện thoại không đúng định dạng";
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
        #endregion

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string Utien = UtienBUS.Instance.LayMaUtien(txtUtien.Text);
            bool gioiTinh = false;
            if (CheckNu.Checked) gioiTinh = true;
            if (ValidateInput())
            {
                DataTable thongTin = new DataTable();
                DataRow newRow = thongTin.NewRow();
                newRow["MaNguoiDung"] = MaTk;
                newRow["HoTen"] = txtHoten.Text;
                newRow["GioiTinh"] = gioiTinh;
                newRow["NgaySinh"] = txtNgaysinh.Value; 
                newRow["DiaChi"] = txtDiaChi.Text;
                newRow["MaDanToc"] = txtDanToc.ValueMember.ToString(); 
                newRow["MaUtien"] = Utien;
                newRow["SDT"] = int.Parse(txtSDT.Text);
                newRow["Email"] = txtEmail.Text;
                thongTin.Rows.Add(newRow);
                ThongTinNguoiDungBUS.Instance.CapNhatNguoiDung(thongTin);
            }
        }
    }
}
