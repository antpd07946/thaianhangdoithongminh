
using Sunny.UI;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class DichVuBUS
    {
        private static DichVuBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private DichVuBUS() { }

        public static DichVuBUS Instance
        {
            get
            {
                if (instance == null) instance = new DichVuBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(DataGridView dataGridViewX, BindingNavigator bindingNavigator)
        {
            bindingSource.DataSource = DichVuDAO.Instance.LayDanhSachDichVu();
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;
        }

        public void HienThiComboBoxDichVu(UIComboBox comboBox)
        {
            comboBox.DataSource = DichVuDAO.Instance.LayDanhSachDichVu();
            comboBox.DisplayMember = "TenDv";
            comboBox.ValueMember = "MaDv";
        }

        public void HienThiDgvCmbCol(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = DichVuDAO.Instance.LayDanhSachDichVu();
            cmbColumn.DisplayMember = "TenDv";
            cmbColumn.ValueMember = "MaDv";
            cmbColumn.DataPropertyName = "MaDv";
            cmbColumn.HeaderText = "Dịch vụ";
        }

        public void CapNhatDichVu(DataTable dataTable)
        {
            DichVuDAO.Instance.CapNhatDichVu(dataTable);
        }
    }
}
