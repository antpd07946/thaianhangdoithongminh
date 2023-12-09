using System;
using System.Data;

namespace DAO
{
    public class LoaiTaiKhoanDAO
    {
        private static LoaiTaiKhoanDAO instance;

        private LoaiTaiKhoanDAO() { }

        public static LoaiTaiKhoanDAO Instance
        {
            get
            {
                if (instance == null) instance = new LoaiTaiKhoanDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayDanhSachLoaiNguoiDung()
        {
            string query = "SELECT * FROM LOAINGUOIDUNG";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void CapNhatLoaiNguoiDung(DataTable dataTable)
        {
            DataProvider.Instance.UpdateTable(dataTable, "LOAINGUOIDUNG");
        }
    }
}
