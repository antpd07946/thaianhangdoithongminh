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
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        private Form Pageform;
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
            Panel_body.Controls.Add(form);
            Panel_body.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {

        }


        private void bunifuButton12_Click(object sender, EventArgs e)
        {

        }


        private void DataGridView1_CellContentClick(object sender,EventArgs e)
        {
            //HangdoiBUS.Instance.HienThi(
            //   bindingNavigator1,
            //   DataGridView1

            //   );
        }

  
        private void BtnQLNguoiDung_Click_1(object sender, EventArgs e)
        {

            chuyenn.Top = ((Control)sender).Top;
            OpenPage(new FrmQLNguoidung());
        }

         

        public void BtnThongTinND_Click(object sender, EventArgs e)
        {
            chuyenn.Top = ((Control)sender).Top;
            OpenPage(new FrmThongtinNguoidung());
        }

        public void BtnQLHangDoi_Click(object sender, EventArgs e)
        {
            chuyenn.Top = ((Control)sender).Top;
            OpenPage(new FrmQLHangdoi());

        }
    }
}
