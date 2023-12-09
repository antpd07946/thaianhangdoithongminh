using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangdoi2
{
    public partial class FrmMainNguoiDung : Form
    {
        public FrmMainNguoiDung()
        {
            InitializeComponent();
            

        }
        private Form Pageform;
        
        private void OpenPage(Form form)
        {
            if(Pageform != null)
            {
                Pageform.Close();
            }
            Pageform = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock= DockStyle.Fill;
            Panel_body.Controls.Add(form);
            Panel_body.Tag = form;
            form.BringToFront();
            form.Show();
        }
     

        private void bunifuButton12_Click(object sender, EventArgs e)
        {
            chuyenn.Top = ((Control)sender).Top;
        }

 
        private void FrmNguoiDung_Load(object sender, EventArgs e)
        {

        }

        private void BtnDanhgia_Click(object sender, EventArgs e)
        {
            chuyenn.Top = ((Control)sender).Top;
            OpenPage(new FrmDanhgia());
         
              
        }

        private void BtnTaiKhoan_Click(object sender, EventArgs e)
        {
            chuyenn.Top = ((Control)sender).Top;
            OpenPage(new FrmQLTaiKhoan());
        }

        private void BtnDanhgia_Click_1(object sender, EventArgs e)
        {

            chuyenn.Top = ((Control)sender).Top;
            OpenPage(new FrmDanhgia());
        }

        private void BtnLayso_Click(object sender, EventArgs e)
        {
            FrmDangnhap dangnhap;
            chuyenn.Top = ((Control)sender).Top;
            FrmLayso frmLayso = new FrmLayso();
            frmLayso.TopMost = true;
            frmLayso.ShowDialog();
        }

        private void btnThongbao_Click(object sender, EventArgs e)
        {

        }
    }
}
