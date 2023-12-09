using System;
using DAO;
using DevComponents.DotNetBar.Controls;
using System.Data;
using DTO;
using System.Windows.Forms;
using Sunny.UI;
using Bunifu.UI.WinForms;
using Guna.UI2.WinForms;

namespace BUS
{
    public class ThongTinNguoiDungBUS
    {
        private static ThongTinNguoiDungBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private ThongTinNguoiDungBUS() { }

        public static ThongTinNguoiDungBUS Instance
        {
            get
            {
                if (instance == null) instance = new ThongTinNguoiDungBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(
            BindingNavigator bindingNavigator2,
             Guna2DataGridView dataGridView2,
             BunifuTextBox txtManguoidung,
            BunifuTextBox txtTennguoidung,
            UIRadioButton checknam,
            UIRadioButton checknu,
            UIDatePicker daysinh,
            BunifuTextBox txtDiaChi,
             BunifuTextBox txtSDT,
             UIComboBox cobdantoc,
             UIComboBox cobUtien
            )
        {
            DataTable dataTable = ThongTinNguoiDungDAO.Instance.LayDanhSachNguoiDung();
            bindingSource.DataSource = dataTable;

            bool gioiTinh = Convert.ToBoolean(dataTable.Rows[0]["GioiTinh"]);
            if (gioiTinh) checknu.Checked = true;
            else checknam.Checked = true;

            txtManguoidung.DataBindings.Clear();
            txtManguoidung.DataBindings.Add("Text", bindingSource, "MaNguoiDung");
            txtTennguoidung.DataBindings.Clear();
            txtTennguoidung.DataBindings.Add("Text", bindingSource, "HoTen");

            daysinh.DataBindings.Clear();
            daysinh.DataBindings.Add("Value", bindingSource, "NgaySinh");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi");


            cobdantoc.DataBindings.Clear();
            cobdantoc.DataBindings.Add("SelectedValue", bindingSource, "MaDanToc");

            cobUtien.DataBindings.Clear();
            cobUtien.DataBindings.Add("SelectedValue", bindingSource, "MaUtien");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", bindingSource, "SDT");

            bindingNavigator2.BindingSource = bindingSource;
            dataGridView2.DataSource = bindingSource;
        }

        public DataTable laythongtin()
        {
            DataTable thongtin = ThongTinNguoiDungDAO.Instance.LayDanhSachNguoiDung();
            return thongtin;
        }
        public void HienThiKdata(
            BunifuTextBox txtManguoidung,
            BunifuTextBox txtTennguoidung,
            UIRadioButton checknam,
            UIRadioButton checknu,
            UIDatePicker daysinh,
            BunifuTextBox txtDiaChi,
             BunifuTextBox txtSDT,
             UIComboBox cobdantoc,
             UIComboBox cobUtien
            )
        {
            DataTable dataTable = ThongTinNguoiDungDAO.Instance.LayDanhSachNguoiDung();
            bindingSource.DataSource = dataTable;

            bool gioiTinh = Convert.ToBoolean(dataTable.Rows[0]["GioiTinh"]);
            if (gioiTinh) checknu.Checked = true;
            else checknam.Checked = true;

            txtManguoidung.DataBindings.Clear();
            txtManguoidung.DataBindings.Add("Text", bindingSource, "MaNguoiDung");

            txtTennguoidung.DataBindings.Clear();
            txtTennguoidung.DataBindings.Add("Text", bindingSource, "HoTen");

            daysinh.DataBindings.Clear();
            daysinh.DataBindings.Add("Value", bindingSource, "NgaySinh");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi");


            cobdantoc.DataBindings.Clear();
            cobdantoc.DataBindings.Add("SelectedValue", bindingSource, "MaDanToc");

            cobUtien.DataBindings.Clear();
            cobUtien.DataBindings.Add("SelectedValue", bindingSource, "MaUtien");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", bindingSource, "SDT");
        }


        public void HienThiComboBox( ComboBoxEx comboBox)
        {
            comboBox.DataSource = ThongTinNguoiDungDAO.Instance.LayDanhSachNguoiDung();
            comboBox.DisplayMember = "HoTen";
            comboBox.ValueMember = "Manguoidung";
        }

        public void ThemNguoiDung(ThongTinNguoiDungDTO nguoiDung)
        {
            ThongTinNguoiDungDAO.Instance.ThemNguoiDung(nguoiDung);
        }

        public void CapNhatNguoiDung(DataTable dataTable)
        {
            ThongTinNguoiDungDAO.Instance.CapNhatNguoiDung(dataTable);
        }

        public DataTable TimNguoiDungTheoMa(string maNguoiDung)
        {
            DataTable thongtin = ThongTinNguoiDungDAO.Instance.TimNguoiDungTheoMa(maNguoiDung);
            return thongtin;
        }

        public void TimNguoiDungTheoTen(string tenNguoiDung)
        {
            bindingSource.DataSource = ThongTinNguoiDungDAO.Instance.TimNguoiDungTheoTen(tenNguoiDung);
        }
        public void timnguoidung(string maNguoiDung)
        {
            // Implement logic to query the database and retrieve user information
            DataTable dataTable = ThongTinNguoiDungDAO.Instance.TimNguoiDung(maNguoiDung);

            if (dataTable.Rows.Count > 0)
            {
                // Populate and return ThongTinNguoiDungDTO
             ThongTinNguoiDungDTO  Thongtin =  new ThongTinNguoiDungDTO(
                    dataTable.Rows[0]["MaNguoiDung"].ToString(),
                    dataTable.Rows[0]["HoTen"].ToString(),
                    Convert.ToBoolean(dataTable.Rows[0]["GioiTinh"]),
                    Convert.ToDateTime(dataTable.Rows[0]["NgaySinh"]),
                    dataTable.Rows[0]["DiaChi"].ToString(),
                    dataTable.Rows[0]["TenDanToc"].ToString(),
                    dataTable.Rows[0]["TenUtien"].ToString(),
                    Convert.ToInt32(dataTable.Rows[0]["SDT"]),
                    dataTable.Rows[0]["Email"].ToString()
                );
               
            }
        }
        public void DeleteNguoidung(string maNguoiDung)
        {
            ThongTinNguoiDungDAO.Instance.deleteNguoidung(maNguoiDung);
        }

    }
}
