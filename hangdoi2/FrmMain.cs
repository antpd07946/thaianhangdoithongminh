using BUS;
using DAO;

using DevComponents.DotNetBar.Controls;
using hangdoi2.Properties;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Xamarin.Forms;

namespace hangdoi2
{
    public partial class FrmMain : Form
    {
        private Form Pageform;
        FrmDangnhap frmDangnhap;
        public FrmMain()
        {
            InitializeComponent();

          

        }
        public void Dangnhap()
        {
            FrmDangnhap frmLogin = new FrmDangnhap();
            frmLogin.ShowDialog();

            if (frmLogin.ShowDialog() != DialogResult.OK)
            { bunifuGradientPanel3.Visible = false;

            };
        }
        #region Buttom menu
        private void BtnHangDoi_Click(object sender, EventArgs e)
        {
            OpenPage(new FrmQLHangdoi());
            DataGridView_QLhangdoi_click(this, EventArgs.Empty);
            chuyenn.Top = ((Control)sender).Top;

        }

        private void OpenPage(Form form)
        {
            if (Pageform != null)
            {
                Pageform.Close();
            }
            Pageform = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            MainPages.Controls.Add(form);
            MainPages.Tag = form;
            form.BringToFront();
            form.Show();
        }
        //buttom 1
        private void FrmMain_Load(object sender, EventArgs e)
        {
            BtnHangDoi_Click(sender, e);
        }



        private void BtnQLNguoiDung_Click(object sender, EventArgs e)
        {
            OpenPage(new FrmQLNguoidung()); 
            chuyenn.Top = ((Control)sender).Top;

        }

        //buttom 2
        private void BtnQLThongbao_Click(object sender, EventArgs e)
        {
            chuyenn.Top = ((Control)sender).Top;
        }

        //Buttom 3
        private void BtnQLBaoCao_Click(object sender, EventArgs e)
        {
            OpenPage( new FrmThongKe());
            chuyenn.Top = ((Control)sender).Top;
        }

        //buttom 4
        private void BtnQLThoiGian_Click(object sender, EventArgs e)
        {
            chuyenn.Top = ((Control)sender).Top;
        }

        #endregion


        #region Page Hàng Đợi

        private void DataGridView_QLhangdoi_click(object sender, EventArgs e)
        {
            //HangdoiBUS.Instance.HienThi(
            //    bindingNavigator1,
            //    DataGridView_QLhangdoi
            //    );
        }



        #endregion
       



         private void bunifuVScrollBar3_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {

        }

        private void PopulateBarChart()
        {
            // Assuming you have a method in ThongKeBUS to get the data
            DataTable dataTable = ThongKeDAO.Instance.LayDanhSachThongKe();



            // Add data points to the series
            foreach (DataRow row in dataTable.Rows)
            {
                // Assuming your columns are named MaHang, Thoigian, MaDv
                string maHang = row["MaHang"].ToString();
                DateTime thoigian = Convert.ToDateTime(row["Thoigian"]);
                string maDv = row["MaDv"].ToString();

            }


        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

    }
}
