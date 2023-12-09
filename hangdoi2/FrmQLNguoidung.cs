using BUS;
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
    public partial class FrmQLNguoidung : Form
    {
        public FrmQLNguoidung()
        {
            InitializeComponent();
           
        }

        private void FrmQLNguoidung_Load(object sender, EventArgs e)
        {
            HienThi();
            DanTocBUS.Instance.HienThiComboBoxDanToc(txtDantoc);
            UtienBUS.Instance.HienThiComboBoxUtien(txtUtien);
        }

        public void HienThi()
        {
            ThongTinNguoiDungBUS.Instance.HienThi(
                bindingNavigator1,
                GrbNguoiDung,
                txtMaNguoidung,
                txtHoten,
                Nam,
                checkNu,
                txtNgaySinh,
                txtDiachi,
                txtSDT,
                txtDantoc, 
                txtUtien);
        }

        public void themNguoidung()
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

            if (GrbNguoiDung.RowCount == 0) bindingNavigatorDeleteItem.Enabled = true;
            BindingSource bindingSource = bindingNavigator1.BindingSource;
            DataTable dataTable = (DataTable)bindingSource.DataSource;
            DataRow dataRow = dataTable.NewRow();
            dataRow["MaNguoidung"] = "";
            dataRow["HoTen"] = "";
            dataRow["GioiTinh"] = false;
            dataRow["NgaySinh"] = DateTime.Today;
            dataRow["DiaChi"] = "";
            dataRow["SDT"] = "";
            dataRow["dantoc"] = "";
            dataRow["Utien"] = "";
            dataTable.Rows.Add(dataRow);
            bindingSource.MoveLast();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            bool gioiTinh = false;
            if (checkNu.Checked) gioiTinh = true;
            if (ValidateInput())
            {
                DataTable thongtin = new DataTable();
                DataRow dataRow = thongtin.NewRow();
                dataRow["MaNguoidung"] = txtMaNguoidung.ToString();
                dataRow["HoTen"] = txtHoten.Text.ToString();
                dataRow["GioiTinh"] = gioiTinh;
                dataRow["NgaySinh"] = txtNgaySinh.Value;
                dataRow["DiaChi"] = txtDiachi.Text.ToString();
                dataRow["SDT"] = Convert.ToInt32(txtSDT.Text);
                dataRow["dantoc"] = txtDantoc.SelectedValue.ToString();
                dataRow["Utien"] = txtUtien.SelectedValue.ToString();
                thongtin.Rows.Add(dataRow);
                ThongTinNguoiDungBUS.Instance.CapNhatNguoiDung(thongtin);
            }
            MessageBox.Show("Giá trị của các ô không được rỗng !",
                   "ERROR",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtHoten.Text) ||
                txtNgaySinh.Value == null ||
                string.IsNullOrEmpty(txtDiachi.Text) ||
                txtDantoc.SelectedValue == null ||
                string.IsNullOrEmpty(txtSDT.Text) ||
                string.IsNullOrEmpty(txtEmail.Text))
            
                {
                    MessageBox.Show("Giá trị của các ô không được rỗng !",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
             }
                if (!IsValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("Email không đúng định dạng!",
                        "ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
                if (!IsValidPhoneNumber(txtSDT.Text))
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng !",
                "ERROR",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
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

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (GrbNguoiDung.RowCount == 0) bindingNavigatorDeleteItem.Enabled = false;
            else if (
                MessageBox.Show(
                    "Lưu ý, mọi thông tin của người dùng này sẽ bị xóa?",
                    "Xóa lớp học",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                ) == DialogResult.OK
            ) bindingNavigator1.BindingSource.RemoveCurrent();
            ThongTinNguoiDungBUS.Instance.DeleteNguoidung(txtMaNguoidung.Text);
        }
    
    }
}
