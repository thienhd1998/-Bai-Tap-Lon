using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class HocHamMaxAccess : DatabaseAccess
    {
        public List<HocHamMax> DisplayHH(string nam,string magv)
        {
            List<HocHamMax> HocHam = new List<HocHamMax>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "HocHamMax";
            command.Connection = conn;

            SqlParameter parMa1 = new SqlParameter("@nam", System.Data.SqlDbType.VarChar);
            SqlParameter parMa2 = new SqlParameter("@magv", System.Data.SqlDbType.VarChar);
            parMa1.Value = nam;
            parMa2.Value = magv;
            command.Parameters.Add(parMa1);
            command.Parameters.Add(parMa2);

            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                string tengv = reader.GetString(0);
                string tenhh = reader.GetString(1);

                HocHamMax HHM = new HocHamMax();
                HHM.TenGV = tengv;
                HHM.TenHH = tenhh;

                HocHam.Add(HHM);
            }
            return HocHam;
        }
    }
}
