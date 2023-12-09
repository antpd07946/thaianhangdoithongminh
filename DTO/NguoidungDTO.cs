using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DTO
{
    public class ThongTinNguoiDungDTO
    {
        private string maNguoiDung;
        private string hoTen;
        private bool gioiTinh;
        private DateTime ngaySinh;
        private string diaChi;
        private string maDanToc;
        private string maTonGiao;
        private string maUtien;
        private int sdt;
        private string email;

        public ThongTinNguoiDungDTO() { }

        public ThongTinNguoiDungDTO(
            string maNguoiDung,
            string hoTen,
            bool gioiTinh,
            DateTime ngaySinh,
            string diaChi,
            string maDanToc,
          
            string maUtien,
            int sdt,
            string email )
        {
            this.maNguoiDung = maNguoiDung;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.maDanToc = maDanToc;
            
            this.maUtien = maUtien;
            this.sdt = sdt;
            this.email = email ;
        }

        public string MaNguoiDung { get => maNguoiDung; set => maNguoiDung = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaDanToc { get => maDanToc; set => maDanToc = value; }
        public string MaTonGiao { get => maTonGiao; set => maTonGiao = value; }
        public string MaUtien { get => maUtien; set => maUtien = value; }
        public int SDT { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
    }
    public class MaNguoiDungDTO
    {
        private string maNguoiDung;
        public MaNguoiDungDTO() { }
        public MaNguoiDungDTO(string maNguoiDung)
        {
            this.maNguoiDung = maNguoiDung;
        }
        public string MaNguoiDung { get => maNguoiDung; set => maNguoiDung = value; }

    }
}
