using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace DTO
{
    public class HangdoiDTO
    {
        private string maHang;
        private string maNguoiDung;
        private string tenNguoiDung;
        private DateTime thoiGian;
        private string maQuay;
        private string maDichVu;
        private string maUuTien;
        private int so;
        public HangdoiDTO() { }

        public HangdoiDTO(
            string maHang,
            string maNguoiDung,
            string tenNguoiDung,
            DateTime thoiGian,
            string maQuay,
            string maDichVu,
            string maUuTien,
               int so)
        {
            this.maHang = maHang;         
            this.maNguoiDung = maNguoiDung;
            this.tenNguoiDung = tenNguoiDung;
            this.thoiGian = thoiGian;
            this.maQuay = maQuay;
            this.maDichVu = maDichVu;
            this.maUuTien = maUuTien;
            this.so = so;
        }

        public string MaHang { get => maHang; set => maHang = value; }
        public string MaNguoiDung { get => maNguoiDung; set => maNguoiDung = value; }
        public string TenNguoiDung { get => tenNguoiDung; set => tenNguoiDung = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }
        public string MaQuay { get => maQuay; set => maQuay = value; }
        public string MaDichVu { get => maDichVu; set => maDichVu = value; }
        public string MaUuTien { get => maUuTien; set => maUuTien = value; }
        public int So { get => so; set => so = value; }
    }
}
