using DTO;
using System;
using System.Data;

namespace DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        private TaiKhoanDAO() { }

        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null) instance = new TaiKhoanDAO();
                return instance;
            }
            private set => instance = value;
        }

        public object LayDanhSachTaiKhoan()
        {
            string query = "SELECT * FROM TAIKHOAN";
            return DataProvider.Instance.ExecuteQuery(query); ;
        }

        public DataTable DangNhap(string username, string password)
        {
            string query = "EXEC DangNhap @tenDangNhap , @matKhau";
            object[] parameters = new object[] { username, password };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public void ThemTaiKhoan(TaiKhoanDTO taiKhoan)
        {
            string query = "INSERT INTO TaiKhoan (MaNguoiDung, MaLoai, TenNguoiDung, TenDangNhap, MatKhau, Email) " +
                       "VALUES (@MaNguoiDung, @MaLoai, @TenNguoiDung, @TenDangNhap, @MatKhau, @Email)";

            object[] parameters = new object[]
            {
            taiKhoan.MaNguoiDung,
            taiKhoan.LoaiNguoiDung.MaLoai,
            taiKhoan.TenNguoiDung,
            taiKhoan.TenDangNhap,
            taiKhoan.MatKhau,
            taiKhoan.Email
            };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);

        }
        public void DoiMatKhau(string username, string newPassword)
        {
            string query = "EXEC DoiMatKhau @tenDangNhap , @matKhau";
            object[] parameters = new object[] { username, newPassword };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public void QuenMatKhau(string username, string newPassword)
        {
            string query = "EXEC Quenmatkhau @Email , @matKhau";
            object[] parameters = new object[] { username, newPassword };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }

        public void CapNhatTaiKhoan(DataTable dataTable)
        {
            DataProvider.Instance.UpdateTable(dataTable, "TAIKHOAN");
        }


        public string Layemail(string email)
        {
            string query = $"SELECT [email] FROM nguoidung WHERE email = '{email}'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0]["email"].ToString();
            }

            return null; // Trả về null nếu không tìm thấy email
        }
    

    }
}
