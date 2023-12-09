using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class HangDoiDAO
    {
        private static HangDoiDAO instance;

        private HangDoiDAO() { }

        public static HangDoiDAO Instance
        {
            get
            {
                if (instance == null) instance = new HangDoiDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayDanhSachHang()
        {
            string query = "EXEC hienthihangdoi ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LayDanhSachHangcoma()
        {
            string query = "EXEC HienThiHangDoiThemMa ";
            return DataProvider.Instance.ExecuteQuery(query);
        }


        public void ThemNguoidoi(HangdoiDTO hang)
        {
            string query = "INSERT INTO Hang(MaHang, Manguoidung, Tennguoidung, Thoigian, MaQuay, MaDv, MaUTien, So) VALUES(@MaHang, @Manguoidung, @Tennguoidung, @Thoigian, @MaQuay, @MaDv, @MaUTien, @So)";
            object[] parameters = new object[]
            {
                hang.MaHang,
                hang.MaNguoiDung,
                hang.TenNguoiDung,
                hang.ThoiGian,
                hang.MaQuay,
                hang.MaDichVu,
                hang.MaUuTien,
                hang.So
            };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public void ThemHangNguoidoiKhongten(HangdoiDTO hang)
        {
            string query = "EXEC ThemnguoidoiKhongten @MaHang, @Manguoidung, @Tennguoidung, @Thoigian, @MaQuay, @MaDv, @MaUTien, @So";
            object[] parameters = new object[]
            {
            hang.MaHang,
            hang.MaNguoiDung,
            (object)hang.TenNguoiDung ?? DBNull.Value, // Use DBNull.Value if TenNguoiDung is null
            hang.ThoiGian,
            hang.MaQuay,
            hang.MaDichVu,
            hang.MaUuTien,
            hang.So
            };
            DataProvider.Instance.ExecuteQuery(query,parameters);
        }


        public DataTable TimTheoMaHang(string maHang)
        {
            string query = $"SELECT * FROM HANG WHERE MaHang LIKE '%{maHang}%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int Laysocuoi()
        {
            string query = "SELECT TOP 1 So FROM Hang ORDER BY So DESC";
            DataTable resultTable = DataProvider.Instance.ExecuteQuery(query);

            if (resultTable != null && resultTable.Rows.Count > 0)
            {
                int so = Convert.ToInt32(resultTable.Rows[0]["So"]);
                return so;
            }
            else
            {
                // Handle the case when the query didn't return any results
                return 0;
            }

        }
        public void xoahang(int so)
        {
            string query = $"Delete from Hang Where So like '{so}'";
            DataProvider.Instance.ExecuteQuery(query);
        }

    }
}

