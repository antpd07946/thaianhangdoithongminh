using BUS;
using DAO;
using DTO;
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

    public partial class FrmThongKe : Form
    {
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;
        public FrmThongKe()
        {
            InitializeComponent();
          

        }
        private void LoadData()
        {
            var refreshData = LoadData2(txtStarDate.MaxDate, txtEndDate.MaxDate);
                 if (refreshData == true)
            {
               
            }

        }
        public bool LoadData2(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                ThongKeDTO thongKe = new ThongKeDTO()
                {
                    StatartDate = startDate,
                    EndDate = endDate
                };
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                DataTable dataTable = ThongKeBUS.Instance.laythongkeTheoNgay(thongKe);

                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
    }
}

