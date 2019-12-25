using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL.GuiBC
{
    public class GuiBCAccess : DatabaseAccess
    {
        public void SubmitBC(string magv, string hoten, string capbac, string donvi, string chucvu, string hocham, string hocvi)
        {
            OpenConnection();
            string sql = "insert into ThongTinBC values ('"+magv+"',N'"+hoten+"',N'"+capbac+"',N'"+donvi+"',N'"+chucvu+"',N'"+hocham+"',N'"+hocvi+"')";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        //public void SubmitTTTai(string magv, string DMDT, string TongTaiDT, )
    }
}
