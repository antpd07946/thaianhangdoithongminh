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
    public partial class CtrTiepNhan : UserControl
    {
        public string MaNguoidung;
        public CtrTiepNhan()
        {
            InitializeComponent();
        }


        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Chắc Chắn muốn thoát ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void BtnNhan_Click(object sender, EventArgs e)
        {
            FrmThongtinNguoidung thongtinNguoidung = new FrmThongtinNguoidung();
        }

        public void txtMaNguoidung_Click(object sender, EventArgs e)
        {

        }
    }
}
