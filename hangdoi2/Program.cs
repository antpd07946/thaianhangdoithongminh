using BUS;
using DTO;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace hangdoi2
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Thread thread1 = new Thread(() =>
            //{
            //    Application.EnableVisualStyles();
            //    Application.SetCompatibleTextRenderingDefault(false);
            //    Application.Run(new FrmLayso());
                
            //   // Application.Run(new FrmDangnhap());
            //});

            //thread1.SetApartmentState(ApartmentState.STA); // Required for WinForms
            //thread1.Start();
            Application.Run(new FrmDangnhap());

            //    // Create and start the second thread for Form2
            //    Thread thread2 = new Thread(() =>
            //    {
            //        Application.EnableVisualStyles();
            //        Application.SetCompatibleTextRenderingDefault(false);
            //        Application.Run(new FrmDangnhap());
            //    });
            //    thread2.SetApartmentState(ApartmentState.STA); // Required for WinForms
            //    thread2.Start();




            //}
        }
    }
}
