using DAO;
using System.Data;
using System.Windows.Forms;

public class UtienDAO
{
    private static UtienDAO instance;

    private UtienDAO() { }

    public static UtienDAO Instance
    {
        get
        {
            if (instance == null) instance = new UtienDAO();
            return instance;
        }
        private set => instance = value;
    }

    public DataTable LayDanhSachUtien()
    {
        string query = "SELECT * FROM UTIEN";
        return DataProvider.Instance.ExecuteQuery(query);
    }
    public string laymaUtien(string tenUtien)
    {
        string query = $"SELECT MAUTIEN from Utien where TenUtien like '%{tenUtien}%' ";
        return query;
    }
    public void CapNhatUtien(DataTable dataTable)
    {
        DataProvider.Instance.UpdateTable(dataTable, "UTIEN");
    }
}

