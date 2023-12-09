using DAO;
using System.Data;
using System.Windows.Forms;

public class DichVuDAO
{
    private static DichVuDAO instance;

    private DichVuDAO() { }

    public static DichVuDAO Instance
    {
        get
        {
            if (instance == null) instance = new DichVuDAO();
            return instance;
        }
        private set => instance = value;
    }

    public DataTable LayDanhSachDichVu()
    {
        string query = "SELECT * FROM DICHVU";
        return DataProvider.Instance.ExecuteQuery(query);
    }

    public void CapNhatDichVu(DataTable dataTable)
    {
        DataProvider.Instance.UpdateTable(dataTable, "DICHVU");
    }
}
