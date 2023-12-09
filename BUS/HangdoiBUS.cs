using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using DAO;
using System;
using DevComponents.Editors.DateTimeAdv;
using System.Data;
using DTO;
using System.Collections.Generic;
using Bunifu.UI.WinForms;
using Sunny.UI;
using Guna.UI2.WinForms;

namespace BUS
{
    public class HangdoiBUS
    {
        private static HangdoiBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private HangdoiBUS() { }

        public static HangdoiBUS Instance
        {
            get
            {
                if (instance == null) instance = new HangdoiBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(
            BindingNavigator bindingNavigator,
             Guna2DataGridView dataGridView1
            
            // Add parameters corresponding to your HangDTO properties
        )
        {
            DataTable dataTable = HangDoiDAO.Instance.LayDanhSachHang();
            bindingSource.DataSource = dataTable;
            bindingNavigator.BindingSource = bindingSource;
            dataGridView1.DataSource = bindingSource;
        }

        public void HienThi2(
         BindingNavigator bindingNavigator,
          Guna2DataGridView dataGridView1,
          UILabel lbrMaso,
          UITextBox maNguoidung,
          UITextBox tenNguoidung
          

     )
        {
            DataTable dataTable = HangDoiDAO.Instance.LayDanhSachHangcoma();
            bindingSource.DataSource = dataTable;
            bindingNavigator.BindingSource = bindingSource;
            dataGridView1.DataSource = bindingSource;
            lbrMaso.DataBindings.Clear();
            lbrMaso.DataBindings.Add("Text", bindingSource, "So");
            maNguoidung.DataBindings.Clear();
            maNguoidung.DataBindings.Add("Text", bindingSource, "MaNguoidung");
            tenNguoidung.DataBindings.Add("Text", bindingSource, "Tennguoidung");
        }


        public void ThemNguoiDoiKhongTen(HangdoiDTO hangdoi)
        {
            HangDoiDAO.Instance.ThemHangNguoidoiKhongten(hangdoi);
        }
        public void ThemNguoidoi(HangdoiDTO hang)
        {
            HangDoiDAO.Instance.ThemNguoidoi(hang);
        }

        public void TimTheoMaHang(
            BindingNavigator bindingNavigator,
            DataGridViewX dataGridViewX,
            string maHang
        )
        {
            bindingSource.DataSource = HangDoiDAO.Instance.TimTheoMaHang(maHang);
        }

        public void HienThiComboBox(
            BindingNavigator bindingNavigator,
            DataGridViewX dataGridViewX,
            string namHoc,
            string lop,
            ComboBoxEx comboBox
        )
        {
            // Implement code to bind data to the ComboBox
        }
        public void deletehang( int so)
        {
            HangDoiDAO.Instance.xoahang(so);
        }

        // Add other methods based on your requirements

    }
}
