using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class SoLATSdaHDAccess : DatabaseAccess
    {
        public List<SoLATSdahd> SoLATSDAHD(string magv, string nam)
        {
            List<SoLATSdahd> SOLATS = new List<SoLATSdahd>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "SoLATSdahd";
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
                int Count = reader.GetInt32(0);

                SoLATSdahd SLLATS = new SoLATSdahd();
                SLLATS.SoLATSdaHD = Count;
                SOLATS.Add(SLLATS);
            }
            reader.Close();


            return SOLATS;
        }

    }
}
