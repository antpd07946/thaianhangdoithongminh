using DAO;
using DevComponents.DotNetBar.Controls;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;
        private TaiKhoanDTO taiKhoan;
        private BindingSource bindingSource = new BindingSource();

        private TaiKhoanBUS() { }
        public TaiKhoanDTO TaiKhoan { get => taiKhoan; set => taiKhoan = value; }

        public static TaiKhoanBUS Instance
        {
            get
            {
                if (instance == null) instance = new TaiKhoanBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(DataGridViewX dataGridViewX, BindingNavigator bindingNavigator)
        {
            bindingSource.DataSource = TaiKhoanDAO.Instance.LayDanhSachTaiKhoan();
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;
        }

        public bool DangNhap(string username, string password)
        {
            DataTable dataTable = TaiKhoanDAO.Instance.DangNhap(username, password);
            if (dataTable.Rows.Count == 0) return false;

            LoaiTaiKhoanDTO loaiTaiKhoan = new LoaiTaiKhoanDTO();
            loaiTaiKhoan.MaLoai = dataTable.Rows[0]["MaLoai"].ToString();

            TaiKhoan = new TaiKhoanDTO(
                dataTable.Rows[0]["MaNguoiDung"].ToString(),
                loaiTaiKhoan,
                dataTable.Rows[0]["TenNguoiDung"].ToString(),
                dataTable.Rows[0]["TenDangNhap"].ToString(),
                dataTable.Rows[0]["MatKhau"].ToString(),
                dataTable.Rows[0]["Email"].ToString()
            );
            return true;
        }

        public void DoiMatKhau(string username, string newPassword)
        {
            TaiKhoanDAO.Instance.DoiMatKhau(username, newPassword);
            TaiKhoan.MatKhau = newPassword;
        }
        public void QuenMatKhau(string email, string newPassword)
        {
            TaiKhoanDAO.Instance.QuenMatKhau(email, newPassword);
            if (TaiKhoan != null)
            {
                TaiKhoan.MatKhau = newPassword;
            }

        }

        public void Themtaikhoan(TaiKhoanDTO taiKhoan)
        {
            TaiKhoanDAO.Instance.ThemTaiKhoan(taiKhoan);
        }
        public void CapNhatTaiKhoan(DataTable dataTable)
        {
            TaiKhoanDAO.Instance.CapNhatTaiKhoan(dataTable);
        }

     
        public string layEmail(string email)
        {
            return TaiKhoanDAO.Instance.Layemail(email);
        }
     
    }
}
