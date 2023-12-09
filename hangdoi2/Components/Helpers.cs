
using System.Windows.Forms;
namespace hangdoi2
{
    public static class Utilities
    {

        public static string LaySTT(int autoNum)
        {
            if (autoNum < 10) return "000" + autoNum;
            else if (autoNum >= 10 && autoNum < 100) return "00" + autoNum;
            else if (autoNum >= 100 && autoNum < 1000) return "0" + autoNum;
            else if (autoNum >= 1000 && autoNum < 10000) return "" + autoNum;
            return "";
        }
    }

    public static class KiemTraTruocKhiLuu
    {
        public static bool KiemTraDataGridView(DataGridView dataGridView, string[] colNames)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (string col in colNames)
                {
                    if (row.Cells[col].Value != null)
                    {
                        string str = row.Cells[col].Value.ToString();
                        if (string.IsNullOrWhiteSpace(str))
                        {
                            MessageBox.Show(
                                "Giá trị của ô không được rỗng !",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        public static bool KiemTraHeSo(DataGridView dataGridView, string colHeSo)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[colHeSo].Value != null)
                {
                    string str = row.Cells[colHeSo].Value.ToString();
                    if (string.IsNullOrWhiteSpace(str) || str == "0")
                    {
                        MessageBox.Show(
                            "Giá trị của ô không được rỗng và hệ số phải lớn hơn 0 !",
                            "ERROR",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool Kiemtraemail()
        {
            return true;
        }
        public static bool KiemTraSoluong()
        {
            return true;
        }
    }

}
