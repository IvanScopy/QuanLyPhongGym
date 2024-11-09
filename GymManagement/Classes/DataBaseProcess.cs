using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement.Classes
{
    internal class DataBaseProcess
    {
        string strConnect = "Data Source=TRANXUANDAT\\SQLEXPRESS;Initial Catalog=QLPhongGym;" +
                            "User ID=sa;Password=mebeo1402;Integrated Security=false";
        private SqlConnection OpenConnect()
        {
            SqlConnection sqlConnect = new SqlConnection(strConnect);
            try
            {
                sqlConnect.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }
            return sqlConnect;
        }


        // Phương thức đóng kết nối
        private void CloseConnect(SqlConnection sqlConnect)
        {
            if (sqlConnect.State == ConnectionState.Open)
            {
                sqlConnect.Close();
                sqlConnect.Dispose();
            }
        }
        // Phương thức thực thi câu lệnh Select trả về một DataTable
        public DataTable DataReader(string sqlSelect)
        {
            DataTable tblData = new DataTable();
            using (SqlConnection sqlConnect = OpenConnect())
            {
                SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelect, sqlConnect);
                sqlData.Fill(tblData);
            }
            return tblData;
        }

        // Phương thức thực hiện câu lệnh dạng insert, update, delete
        public void DataChange(string sql)
        {
            using (SqlConnection sqlConnect = OpenConnect())
            {
                SqlCommand sqlcomma = new SqlCommand(sql, sqlConnect);
                sqlcomma.ExecuteNonQuery();
            }
        }

        public DataTable DataReader(string sqlSelect, Dictionary<string, object> parameters = null)
        {
            DataTable tblData = new DataTable();
            using (SqlConnection sqlConnect = OpenConnect())
            {
                using (SqlCommand command = new SqlCommand(sqlSelect, sqlConnect))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    SqlDataAdapter sqlData = new SqlDataAdapter(command);
                    sqlData.Fill(tblData);
                }
            }
            return tblData;
        }

        public object ExecuteScalar(string sql, Dictionary<string, object> parameters = null)
        {
            using (SqlConnection sqlConnect = OpenConnect())
            {
                using (SqlCommand command = new SqlCommand(sql, sqlConnect))
                {
                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                        {
                            command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }

                    return command.ExecuteScalar(); // Thực hiện truy vấn và lấy giá trị đầu tiên
                }
            }
        }

        public void DataChange(string sql, Dictionary<string, object> parameters)
        {
            using (SqlConnection sqlConnect = OpenConnect())
            {
                SqlCommand sqlcomma = new SqlCommand(sql, sqlConnect);

                // Thêm các tham số vào SqlCommand từ từ điển
                foreach (var param in parameters)
                {
                    sqlcomma.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                }

                sqlcomma.ExecuteNonQuery();
            }
        }
    }

}
