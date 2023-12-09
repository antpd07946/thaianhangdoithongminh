using BUS;
using DTO;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace hangdoi2
{
    public partial class FrmDanhgia : Form
    {
       
        public FrmDanhgia()
        {
            InitializeComponent();
            load();

        }
        public void load()
        {
            DataTable danhgia = DanhGiaBUS.Instance.Danhsachdanhgia();
            var sortedRows = danhgia.AsEnumerable()
                          .OrderBy(row => row.Field<DateTime>("ThoiGian"));

       
            foreach (DataRow row in danhgia.Rows)
            {
                CtrDanhGia ctrDanhGia = new CtrDanhGia();
                ctrDanhGia.Hoten.Text= row["HoTen"].ToString();
                ctrDanhGia.Time.Text = row["ThoiGian"].ToString();
                ctrDanhGia.Comment.Text = row["NhanXet"].ToString();
                ctrDanhGia.Sao.Value = Convert.ToInt32(row["sao"]);
                ctrDanhGia.Height = 80;
                commentPanel.Controls.Add(ctrDanhGia);
                ctrDanhGia.Dock = DockStyle.Top;
            }
        }

        
        private void DanhGia_sao_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs e)
        {
       
        }

        private void Btnthem_Click(object sender, EventArgs e)
        {
            DanhGiaDTO danhgia = new DanhGiaDTO()
            {
                MaNguoiDung = TaiKhoanBUS.Instance.TaiKhoan.MaNguoiDung,
                ThoiGian = DateTime.Now,
                Sao = DanhGia_sao.Value,
                NhanXet = txtNhanXet.Text
            };
            DanhGiaBUS.Instance.ThemDanhGia(danhgia);

        }
    }
}
