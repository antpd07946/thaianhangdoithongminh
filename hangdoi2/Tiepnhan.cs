using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace hangdoi2
{
   
    public partial class Tiepnhan : Form
    {
        public FrmQLHangdoi frmQLHangdoi;
        public FrmNhanVien frmNhanVien;
        public Tiepnhan()
        {
            InitializeComponent();
            TopMost = true;
            
            this.frmQLHangdoi = frmQLHangdoi;
            this.frmNhanVien = frmNhanVien;
           
           //txtTiepNhan.Text =frmQLHangdoi.MaNguoidung;
        }

        
        private void txtTiepNhan_Click(object sender, EventArgs e)
        {

        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNhan_Click(object sender, EventArgs e)
        {
            frmNhanVien.BtnThongTinND_Click(sender, e);
        }

        private void BtnLoa_Click(object sender, EventArgs e)
        {
            String result = Task.Run(async () =>
            {
                String payload = "Test";
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("api-key", "13RVsN4Bi1bn42GoLmVXTjn4i7z0Llh4");
                client.DefaultRequestHeaders.Add("speed", "20");
                client.DefaultRequestHeaders.Add("voice", "banmai");
                var response = await client.PostAsync("https://api.fpt.ai/hmi/tts/v5", new StringContent(payload));
                return await response.Content.ReadAsStringAsync();
            }).GetAwaiter().GetResult();

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
    }
    
    

