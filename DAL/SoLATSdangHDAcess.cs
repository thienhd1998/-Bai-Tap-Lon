using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class SoLATSdangHDAccess : DatabaseAccess
    {
        public List<SoLATSdanghd> SoLATSdangHD(string magv, string nam)
        {
            List<SoLATSdanghd> SOLATS1 = new List<SoLATSdanghd>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "SoLATSdangHD";
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
                int Count = reader.GetInt32(0);

                SoLATSdanghd SLLATS = new SoLATSdanghd();
                SLLATS.SoLATSdangHD = Count;
                SOLATS1.Add(SLLATS);
            }
            reader.Close();


            return SOLATS1;
        }

    }
}
