using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class LietKeBBAccess : DatabaseAccess
    {
        public List<LietKeBB> DisplayLietKeBB(string magv, string nam)
        {
            List<LietKeBB> lietkeBB = new List<LietKeBB>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "LietKeBB";
            command.Connection = conn;

            SqlParameter parMa1 = new SqlParameter("@magv", System.Data.SqlDbType.VarChar);
            SqlParameter parMa2 = new SqlParameter("@nam", System.Data.SqlDbType.VarChar);
            parMa1.Value = magv;
            parMa2.Value = nam;
            command.Parameters.Add(parMa1);
            command.Parameters.Add(parMa2);

            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                string tenbb = reader.GetString(0);
                string vaitro = reader.GetString(1);
                string tentc = reader.GetString(2);
                string ngaydang = reader.GetDateTime(3).ToString("dd/MM/yyyy");

                LietKeBB LKBB = new LietKeBB();
                LKBB.TenBB = tenbb;
                LKBB.VaiTro = vaitro;
                LKBB.TenTC = tentc;
                LKBB.NgayDang = ngaydang;

                lietkeBB.Add(LKBB);
            }
            reader.Close();
            return lietkeBB;
        }
    }
}
