using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
     public class DetailLATSAccess : DatabaseAccess
    {
        public List<DetailLATS> detailLATS(string magv, string nam)
        {
            List<DetailLATS> DeLATS = new List<DetailLATS>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "ChiTietHDLATS";
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
                string tendt = reader.GetString(0);
                string vaitro = reader.GetString(1);
                string tenhv = reader.GetString(2);
                string nienkhoa = reader.GetString(3);

                DetailLATS DLATS = new DetailLATS();
                DLATS.TenDT = tendt;
                DLATS.VaiTro = vaitro;
                DLATS.TenHV = tenhv;
                DLATS.NienKhoa = nienkhoa;

                DeLATS.Add(DLATS);
            }
            reader.Close();
            return DeLATS;
        }

    }
}
