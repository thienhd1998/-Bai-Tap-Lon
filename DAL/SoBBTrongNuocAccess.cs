using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class SoBBTrongNuocAccess : DatabaseAccess
    {
        public List<SoBaiBao> DisplaySoBB(string magv, string nam)
        {
            List<SoBaiBao> SoBB = new List<SoBaiBao>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "SoBBTrongNuoc";
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
                int sobb = reader.GetInt32(0);

                SoBaiBao sobB = new SoBaiBao();
                sobB.SoBB = sobb;
                SoBB.Add(sobB);
            }
            reader.Close();
            return SoBB;
        }
    }
}
