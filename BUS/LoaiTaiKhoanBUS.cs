using DAO;
using DevComponents.DotNetBar.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class LoaiTaiKhoanBUS
    {
        private static LoaiTaiKhoanBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private LoaiTaiKhoanBUS() { }

        public static LoaiTaiKhoanBUS Instance
        {
            get
            {
                if (instance == null) instance = new LoaiTaiKhoanBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(DataGridViewX dataGridViewX, BindingNavigator bindingNavigator)
        {
            bindingSource.DataSource = LoaiTaiKhoanDAO.Instance.LayDanhSachLoaiNguoiDung();
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;
        }

        public void HienThiDgvCmbCol(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = LoaiTaiKhoanDAO.Instance.LayDanhSachLoaiNguoiDung();
            cmbColumn.DisplayMember = "TenLoai";
            cmbColumn.ValueMember = "MaLoai";
            cmbColumn.DataPropertyName = "MaLoai";
            cmbColumn.HeaderText = "Loại người dùng";
        }

        public void CapNhatLoaiNguoiDung(DataTable dataTable)
        {
            LoaiTaiKhoanDAO.Instance.CapNhatLoaiNguoiDung(dataTable);
        }
    }
}
