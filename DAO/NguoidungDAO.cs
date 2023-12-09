using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using System.Data;

namespace DAO
{
    public class ThongTinNguoiDungDAO
    {
        private static ThongTinNguoiDungDAO instance;

        private ThongTinNguoiDungDAO() { }

        public static ThongTinNguoiDungDAO Instance
        {
            get
            {
                if (instance == null) instance = new ThongTinNguoiDungDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayDanhSachNguoiDung()
        {
            string query = "SELECT * FROM ThongTinNguoiDung";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable TimNguoiDungTheoMa(string maNguoiDung)
        {
            string query = $"SELECT * FROM ThongTinNguoiDung WHERE Manguoidung LIKE '%{maNguoiDung}%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable TimNguoiDung(string maNguoiDung)
        {
            string query = $"EXEC  TimThongTinNguoiDung  @SearchKeyword like '{maNguoiDung}%'  ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable TimNguoiDungTheoTen(string tenNguoiDung)
        {
            string query = $"SELECT * FROM ThongTinNguoiDung WHERE HoTen LIKE '%{tenNguoiDung}%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
       
        public void ThemNguoiDung(ThongTinNguoiDungDTO nguoiDung)
        {
            string query = "EXEC ThemNguoiDung @Manguoidung, @HoTen, @GioiTinh, @NgaySinh, @DiaChi, @MaDanToc, @MaTonGiao, @MaUtien, @SDT, @Email";
            object[] parameters = new object[] {
                nguoiDung.MaNguoiDung,
                nguoiDung.HoTen,
                nguoiDung.GioiTinh,
                nguoiDung.NgaySinh,
                nguoiDung.DiaChi,
                nguoiDung.MaDanToc,
                nguoiDung.MaTonGiao,
                nguoiDung.MaUtien,
                nguoiDung.SDT,
                nguoiDung.Email
            };
            
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }

        public void CapNhatNguoiDung(DataTable dataTable)
        {
            DataProvider.Instance.UpdateTable(dataTable, "ThongTinNguoiDung");
        }
        public void deleteNguoidung(string manguoidung)
        {
            string query = $"EXEC XoaThongTinNguoiDung @manguoidung like '{manguoidung}'";
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}

