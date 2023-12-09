using BUS;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace hangdoi2
{
    public partial class FrmThongtinNguoidung : Form
    {
        public string MaNguoidung;
        public FrmThongtinNguoidung()
        {
            InitializeComponent();
        }

        private void FrmThongtinNguoidung_Load(object sender, EventArgs e)
        {
            DanTocBUS.Instance.HienThiComboBoxDanToc(txtDantoc);
            UtienBUS.Instance.HienThiComboBoxUtien(txtUtien);
            DataTable thongtin = ThongTinNguoiDungBUS.Instance.TimNguoiDungTheoMa(MaNguoidung);
            txtHoten.Text = thongtin.Rows[0]["Hoten"].ToString();
            txtDiachi.Text = thongtin.Rows[0]["DiaChi"].ToString();
            txtNgaysinh.Value = Convert.ToDateTime(thongtin.Rows[0]["NgaySinh"]);
            txtSDT.Text = thongtin.Rows[0]["SDT"].ToString();
            checkNu.Checked = Convert.ToBoolean(thongtin.Rows[0]["GioiTinh"]);
            txtUtien.Text = thongtin.Rows[0]["MaUtien"].ToString();
            txtDantoc.Text = thongtin.Rows[0]["MaDanToc"].ToString();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            bool gioiTinh = false;
            if (checkNu.Checked) gioiTinh = true;
            if (ValidateInput())
            {
                DataTable thongTin = new DataTable();
                DataRow newRow = thongTin.NewRow();
                newRow["MaNguoiDung"] = txtManguoidung;
                newRow["HoTen"] = txtHoten.Text;
                newRow["GioiTinh"] = gioiTinh;
                newRow["NgaySinh"] = txtNgaysinh.Value;
                newRow["DiaChi"] = txtDiachi.Text;
                newRow["MaDanToc"] = txtDantoc.ValueMember.ToString();
                newRow["MaUtien"] = txtUtien.ValueMember.ToString();
                newRow["SDT"] = int.Parse(txtSDT.Text);
                newRow["Email"] = txtEmail.Text;
                thongTin.Rows.Add(newRow);
                ThongTinNguoiDungBUS.Instance.CapNhatNguoiDung(thongTin);
            }
        }
        #region hàm check
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtHoten.Text)) { lbrHotenErrol.Text = "Không được để trống"; return false; };
            if (txtNgaysinh.Value == null) { }
            if (string.IsNullOrEmpty(txtDiachi.Text)) { lbrDiachiErrol.Text = "Không được để trống"; return false; };
            if (txtDantoc.SelectedValue == null) { MessageBox.Show("chọn dân tộc", "Errol"); return false; }
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
    }
}
