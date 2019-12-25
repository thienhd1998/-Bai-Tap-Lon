using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class SachGTAccess : DatabaseAccess
    {
        public List<SachGT> DisplaySachGT(string magv, string nam)
        {
            List<SachGT> sachGT = new List<SachGT>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "SachGiaoTrinh";
            command.Connection = conn;

            SqlParameter parMa1 = new SqlParameter("@magv", System.Data.SqlDbType.VarChar);
            SqlParameter parMa2 = new SqlParameter("@nam", System.Data.SqlDbType.VarChar);
            parMa1.Value = magv;
            parMa2.Value = nam;
            command.Parameters.Add(parMa1);
            command.Parameters.Add(parMa2);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string tensach = reader.GetString(0);
                string vaitro = reader.GetString(1);
                string noixb = reader.GetString(2);
                string namxb = reader.GetDateTime(3).ToString("dd/MM/yyyy");

                SachGT SGT = new SachGT();
                SGT.TenSach = tensach;
                SGT.VaiTro = vaitro;
                SGT.NoiXB = noixb;
                SGT.NamXB = namxb;

                sachGT.Add(SGT);
            }
            return sachGT;

        }
    }
}
