using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyCuaHangTienLoi
{
    public class DBConnection
    {
        SqlConnection conn = new SqlConnection(@"Data Source=EBISU-SAN\DAOQUYCUONG;Initial Catalog=QuanLyCuaHangTienLoi2;Integrated Security=True");
        public SqlConnection getConnection
        {
            get
            {
                return conn;
            }
        }
        public void openConnection()
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }


    }
}
