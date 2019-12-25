using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class SachCKAccess : DatabaseAccess
    {
        public List<SachCK> DisplaySachCK(string magv, string nam)
        {
            List<SachCK> sachCK = new List<SachCK>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "SachChuyenKhao";
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
                string tensach = reader.GetString(0);
                string vaitro = reader.GetString(1);
                string noixb = reader.GetString(2);
                string namxb = reader.GetDateTime(3).ToString("dd/MM/yyyy");

                SachCK SCK = new SachCK();
                SCK.TenSach = tensach;
                SCK.VaiTro = vaitro;
                SCK.NoiXB = noixb;
                SCK.NamXB = namxb;

                sachCK.Add(SCK);
            }
            return sachCK;

        }
    }
}
