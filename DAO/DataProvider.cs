using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        private string connectionString = "Data Source=LAPTOP;Initial Catalog=Hangdoi;Integrated Security=True;";

        private DataProvider() { } 

        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return instance;
            }
            private set => instance = value;
        }

      

        private SqlCommand GetSqlCommand(SqlConnection connection, string query, object[] parameters)
        {
            SqlCommand command = new SqlCommand(query, connection);

            if (parameters != null && parameters.Length > 0)
            {
                var paramMatches = Regex.Matches(query, @"@\w+");

                if (paramMatches.Count == parameters.Length)
                {
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        command.Parameters.AddWithValue(paramMatches[i].Value, parameters[i]);
                    }
                }
                else
                {
                    throw new ArgumentException("Số lượng tham số không khớp với câu truy vấn.");
                }
            }

            return command;
        }


        public void UpdateTable(DataTable dataTable, string table)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT * FROM {table}";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    adapter.Update(dataTable);
                    connection.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable ExecuteQuery(string query, object[] parameters = null)
        { 

            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //if (connection.State != ConnectionState.Open)
                    //{
                    //    connection.Open();
                    //}
                    //else
                    //{
                    //    // The connection is already open. You can handle this case here.
                    //    MessageBox.Show("Connection is already open.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    // You might want to decide what to do in this case - throw an exception, log the information, etc.
                    //}
                    connection.Open();
                    SqlCommand command = GetSqlCommand(connection, query, parameters);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    connection.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int data = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = GetSqlCommand(connection, query, parameters);
                    data = command.ExecuteNonQuery();
                    connection.Close();

                    if (data > 0)
                    {
                        MessageBox.Show("Command executed successfully. Rows affected: " + data);
                    }
                    else
                    {
                        MessageBox.Show("Lệnh đã thực thi nhưng không có hàng được thêm vào.");
                    }
                }
            
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameters = null)
        {
            object data = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = GetSqlCommand(connection, query, parameters);
                    data = command.ExecuteScalar();
                    connection.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return data;
        }
    }
}
