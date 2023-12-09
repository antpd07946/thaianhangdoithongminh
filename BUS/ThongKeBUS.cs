
using System.Data;
using DAO;
using DTO;
using System.Windows.Forms;
using System.Security.RightsManagement;

namespace BUS
{
    public class ThongKeBUS
    {
        private static ThongKeBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private ThongKeBUS() { }

        public static ThongKeBUS Instance
        {
            get
            {
                if (instance == null) instance = new ThongKeBUS();
                return instance;
            }
        }

        public void HienThiDanhSachThongKe(DataGridView dataGridView)
        {
            DataTable dataTable = ThongKeDAO.Instance.LayDanhSachThongKe();
            bindingSource.DataSource = dataTable;

            // Bind the data to your DataGridView
            dataGridView.DataSource = bindingSource;
        }

        public DataTable DanhSachThongKe()
        {
            return ThongKeDAO.Instance.LayDanhSachThongKe();
        }
       
        public DataTable laythongkeTheoNgay(ThongKeDTO thongKe) 
        {
            return ThongKeDAO.Instance.danhsachtheoNgay(thongKe);
        }

        // Add other methods as needed
    }
}
