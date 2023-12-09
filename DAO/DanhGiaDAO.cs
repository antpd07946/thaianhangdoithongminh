using System;
using System.Data;
using DTO;
namespace DAO
{
    public class DanhGiaDAO
    {
        private static DanhGiaDAO instance;

        private DanhGiaDAO() { }

        public static DanhGiaDAO Instance
        {
            get
            {
                if (instance == null) instance = new DanhGiaDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable danhsachdanhgia()
        {
            string query = $"EXEC DanhSachDanhGia";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public void ThemDanhGia(DanhGiaDTO danhGia)
        {
            string query = "INSERT INTO DanhGia(MaNguoidung, Thoigian, sao, nhanxet) " +
                           "VALUES(@MaNguoiDung, @ThoiGian, @Sao, @NhanXet)";

            object[] parameters = new object[] {
                danhGia.MaNguoiDung,
                danhGia.ThoiGian,
                danhGia.Sao,
                danhGia.NhanXet
            };

            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }

        // Add other methods for CRUD operations if needed
    }
}
