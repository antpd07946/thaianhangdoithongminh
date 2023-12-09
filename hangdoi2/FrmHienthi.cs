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
    public partial class FrmHienthi : Form
    {
        public FrmHienthi()
        {
            InitializeComponent();

            lbrTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            lbrDate.Text= DateTime.Now.ToShortDateString();
            hienthidatagridview();
        }

        private void lbrTime_Click(object sender, EventArgs e)
        {
            // Lấy thời gian hiện tại
           
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbrTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void lbrDate_Click(object sender, EventArgs e)
        {

        }

        private void hienthidatagridview()
        {
            HangdoiBUS.Instance.HienThi(
               bindingNavigator1,
               DvgHienthi
               );
        }
    }
}
