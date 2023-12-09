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
using Xamarin.Forms.Xaml;

namespace hangdoi2
{
    public partial class FrmQLHangdoi : Form
    {
        public string MaNguoidung;
        public string TenNguoidung;
        public FrmQLHangdoi()
        {
            InitializeComponent();
           
        }
        public void FrmQLHangdoi_Load(object sender, EventArgs e)
        {
           // GrbHangDoi_Click(this, EventArgs.Empty);
            
        }
        private void uiRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        Tiepnhan tiepnhan = new Tiepnhan();
        private void GrbHangDoi_Click(object sender, EventArgs e)
        {
            HangdoiBUS.Instance.HienThi2(
             bindingNavigator1,
             DvgHienthi,
             lbrMaSo,
             txtManguoidung,
             txtHoten
             );
            LoadCha(sender, e);
        }

        private void LoadCha(object sender, EventArgs e)
        {
     
            //LoadGrv(sender, (DataGridViewCellEventArgs)e);
        }
        public void LoadGrv(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DvgHienthi.Rows.Count)
            {
                string soValue = DvgHienthi.Rows[e.RowIndex].Cells["So"].Value.ToString();
                string maNguoiDungValue = DvgHienthi.Rows[e.RowIndex].Cells["MaNguoidung"].Value.ToString();

                // Kiểm tra giá trị MaUTien và hiển thị thông báo
                if (DvgHienthi.Rows[e.RowIndex].Cells["MaUTien"].Value.ToString() == "UT1")
                {
                    tiepnhan.ShowDialog();
                    tiepnhan.txtTiepNhan.Text = soValue;
                    tiepnhan.txtMaNguoidung.Text = maNguoiDungValue;
                    MessageBox.Show($"Giá trị 'So' được lấy ra: {soValue}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DvgHienthi.RowCount == 0) bindingNavigatorDeleteItem.Enabled = false;
            else if (
                MessageBox.Show(
                    "Bạn có chắc chắn xóa dòng này không ?",
                    "Xóa lớp học",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                ) == DialogResult.OK
            ) GrbHangDoi_Click(this, EventArgs.Empty);
            bindingNavigator1.BindingSource.RemoveCurrent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GrbHangDoi_Click(this, EventArgs.Empty);
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
           
            tiepnhan.ShowDialog();
            HangdoiBUS.Instance.deletehang(int.Parse(lbrMaSo.Text));
        }

    }
}
