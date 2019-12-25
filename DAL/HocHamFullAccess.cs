using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class HocHamFullAccess : DatabaseAccess
    {
        public List<HocHamFull> DisplayHHFull(string magv, string nam)
        {
            List<HocHamFull> HHFull = new List<HocHamFull>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "HocHamFull";
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
                string tenhh = reader.GetString(0);
                string timeNhan = reader.GetDateTime(1).ToString("dd/MM/yyyy");
                string noinhan = reader.GetString(2);

                HocHamFull HHF = new HocHamFull();
                HHF.TenHocHam = tenhh;
                HHF.TimeNhan = timeNhan;
                HHF.NoiBoNhiem = noinhan;

                HHFull.Add(HHF);
            }
            reader.Close();
            return HHFull;
        }
    }
}
