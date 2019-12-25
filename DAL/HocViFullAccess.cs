using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class HocViFullAccess : DatabaseAccess
    {
        public List<HocViFull> DisplayHVFull(string magv, string nam)
        {
            List<HocViFull> HVFull = new List<HocViFull>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "HocViFull";
            command.Connection = conn;

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
                string tenhv = reader.GetString(0);
                string timeNhan = reader.GetDateTime(1).ToString("dd/MM/yyyy");
                
                HocViFull HVF = new HocViFull();
                HVF.TenHV = tenhv;
                HVF.NamNhan = timeNhan;
                

                HVFull.Add(HVF);
            }
            reader.Close();
            return HVFull;
        }
    }
}
