
// ThongKeDAO.cs
using System;
using System.Data;
using System.Data.SqlClient;
using DTO;


namespace DAO
{
    public class ThongKeDAO
    {
        private static ThongKeDAO instance;

        private ThongKeDAO() { }

        public static ThongKeDAO Instance
        {
            get
            {
                if (instance == null) instance = new ThongKeDAO();
                return instance;
            }
        }

        public DataTable LayDanhSachThongKe()
        {

            string query = "SELECT * FROM ThongKe";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable danhsachtheoNgay(ThongKeDTO thongKe)
        {
            string query = "SELECT MaHang, MaNguoidung, Thoigian, MaDv" +
                "            FROM ThongKe WHERE Thoigian BETWEEN @fromDate AND @toDate";
            object[] parameters = new object[] {
           thongKe.StatartDate,
           thongKe.EndDate
        };
           return DataProvider.Instance.ExecuteQuery(query, parameters);
            // Add other methods as needed (e.g., ThemThongKe, CapNhatThongKe, XoaThongKe, etc.)
        }
    }
}
