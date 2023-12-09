using DevComponents.DotNetBar.Controls;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BUS
{
    public class UtienBUS
    {
        private static UtienBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private UtienBUS() { }

        public static UtienBUS Instance
        {
            get
            {
                if (instance == null) instance = new UtienBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(DataGridViewX dataGridViewX, BindingNavigator bindingNavigator)
        {
            bindingSource.DataSource = UtienDAO.Instance.LayDanhSachUtien();
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;
        }

        public void HienThiComboBoxUtien(UIComboBox comboBox)
        {
            comboBox.DataSource = UtienDAO.Instance.LayDanhSachUtien();
            comboBox.DisplayMember = "TenUtien";
            comboBox.ValueMember = "MaUTien";
        }
        public string LayMaUtien(string tenUtien)
        {
            return UtienDAO.Instance.laymaUtien(tenUtien);
        }
        public void HienThiDgvCmbCol(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = UtienDAO.Instance.LayDanhSachUtien();
            cmbColumn.DisplayMember = "TenUtien";
            cmbColumn.ValueMember = "MaUTien";
            cmbColumn.DataPropertyName = "MaUTien";
            cmbColumn.HeaderText = "Ưu tiên";
        }

        public void CapNhatUtien(DataTable dataTable)
        {
            UtienDAO.Instance.CapNhatUtien(dataTable);
        }
    }
}