using BUS;
using DAO;
using DevComponents.UI.ContentManager;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace hangdoi2
{
    public partial class FrmLayso : Form
    {
        FrmDangnhap frmDangnhap = new FrmDangnhap();

        public FrmLayso()
        {
            InitializeComponent();
          
        }

        private void FrmLayso_Load(object sender, EventArgs e)
        {
            SoHieu();
            DichVuBUS.Instance.HienThiComboBoxDichVu(cobDicvu);
            
        }
        //public bool checkDN()
        //{ 
        //    if (frmDangnhap.checkform())
        //    {
        //        txtMakhach.Text = TaiKhoanBUS.Instance.TaiKhoan.MaNguoiDung;
        //        txtMakhach.ReadOnly = true;

        //        return true;
        //    }
        //    return false;
        //}
        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
           
            frmDangnhap.ShowDialog();
            
        }

        private void BtnLaySo_Click(object sender, EventArgs e)
        {
            
            FrmQLHangdoi qLHangdoi = new FrmQLHangdoi();
           
           // qLHangdoi.FrmQLHangdoi_Load(sender, e);

            HangdoiDTO hang = new HangdoiDTO()
            {
                MaHang = "H01",
                MaNguoiDung = GenerateMaNguoiDung(),
                TenNguoiDung = null,
                ThoiGian = DateTime.Now,
                MaQuay = "Q1",
                MaDichVu = cobDicvu .SelectedValue.ToString(),
                MaUuTien = "UT0",
                So = SoHieu()
            };         
            
            HangdoiBUS.Instance.ThemNguoiDoiKhongTen(hang);
            MessageBox.Show(
            "Lấy số thành công",
            "Cập nhật thành công",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
        private int SoHieu()
        {
           int so = HangDoiDAO.Instance.Laysocuoi();
           int sotiep = so + 2;
           return   sotiep;
        }
    
        private string GenerateMaHang()
        {         
            return "MH001";
        }

        public string chonQuay()
        {
            string quay="";
            return quay; 
        }
        private string GenerateMaNguoiDung()
        {
            //if (checkDN())
            //{
            //    return txtMakhach.Text;
            //}
            //else
            //{
                // Lấy thời gian hiện tại
                DateTime currentTime = DateTime.Now;

                // Lấy giá trị phút và định dạng thành chuỗi 2 chữ số
                string minuteString = currentTime.Minute.ToString("00");
                return "NG" + SoHieu().ToString() + minuteString;
            //}
        }

        
    }
}
