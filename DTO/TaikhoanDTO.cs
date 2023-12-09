namespace DTO
{
    public class TaiKhoanDTO
    {
        private string maNguoiDung;
        private LoaiTaiKhoanDTO loaiNguoiDung;
        private string tenNguoiDung;
        private string tenDangNhap;
        private string matKhau;
        private string email;

      
       public TaiKhoanDTO() {}
        public TaiKhoanDTO(
            string maNguoiDung,
            LoaiTaiKhoanDTO loaiNguoiDung,
            string tenNguoiDung,
            string tenDangNhap,
            string matKhau,
            string email)
        {
            this.maNguoiDung = maNguoiDung;
            this.loaiNguoiDung = loaiNguoiDung;
            this.tenNguoiDung = tenNguoiDung;
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.email = email;
        }

        public string MaNguoiDung { get => maNguoiDung; set => maNguoiDung = value; }
        public LoaiTaiKhoanDTO LoaiNguoiDung { get => loaiNguoiDung; set => loaiNguoiDung = value; }
        public string TenNguoiDung { get => tenNguoiDung; set => tenNguoiDung = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string Email { get => email; set => email = value; }
    }
    
   
}