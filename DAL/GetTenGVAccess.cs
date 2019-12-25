using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class GetTenGVAccess : DatabaseAccess
    {
        public string GetTenGV(string magv)
        {
            string tengv = "";
            OpenConnection();
            string sql = "select GiaoVien.TenGV from GiaoVien where MaGV='" + magv + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = conn;
            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                tengv = rd.GetString(0);
            }
            rd.Close();
            CloseConnection();
            return tengv;
        }
    }
}
