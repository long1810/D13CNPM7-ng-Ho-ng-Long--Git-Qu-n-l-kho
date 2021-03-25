using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CT_GT1.Controller
{
    public class SqlDataProvider
    {

        private string con_str = @"Data Source=DESKTOP-FMO1CDM\SQLEXPRESS;Initial Catalog=kho2ss;Integrated Security=True";
        SqlConnection conn = null;
        public SqlDataProvider()
        {
            conn = new SqlConnection(con_str);
        }
        public void executeNonQuery(string tv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(tv, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public string executeScalar(string tv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(tv, conn);
            string data = cmd.ExecuteScalar().ToString();
            
            conn.Close();
            return data;
            
        }
        public DataSet getdata(string select,string table_name)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(select,conn);
            
            da.Fill(ds, table_name);
            
            return ds;
        }
        public DataTable laydata(string tv)
        {
            
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(tv, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;

        }
    }
}
