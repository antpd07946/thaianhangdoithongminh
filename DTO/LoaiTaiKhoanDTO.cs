namespace DTO
{
    public class LoaiTaiKhoanDTO
    {
        private string maLoai;
        private string tenLoai;

        public LoaiTaiKhoanDTO() { }
        public string MaLoai { get => maLoai; set => maLoai = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
    }
}
