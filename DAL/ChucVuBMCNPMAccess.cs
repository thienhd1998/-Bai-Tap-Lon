using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class ChucVuBMCNPMAccess:DatabaseAccess
    {
        public List<NhanLucBMCNPM> HienThiNhanLucCNPM(string nam, string mabm)
        {
            List<NhanLucBMCNPM> NhanLucCBPM = new List<NhanLucBMCNPM>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "NhanLucBM";
            command.Connection = conn;

            SqlParameter parMa1 = new SqlParameter("@nam", System.Data.SqlDbType.VarChar);
            SqlParameter parMa2 = new SqlParameter("@mabm", System.Data.SqlDbType.VarChar);
            parMa1.Value = nam;
            parMa2.Value = mabm;
            command.Parameters.Add(parMa1);
            command.Parameters.Add(parMa2);

            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                string tengv = reader.GetString(0);
                string tencv = reader.GetString(1);
                string tenhh = reader.GetString(2);
                string tenhv = reader.GetString(3);
                string magv = reader.GetString(4);

                NhanLucBMCNPM CNPM = new NhanLucBMCNPM();
                CNPM.TenGV = tengv;
                CNPM.TenChucVu = tencv;
                CNPM.TenHocHam = tenhh;
                CNPM.TenHocVi = tenhv;
                CNPM.MaGV = magv;

                NhanLucCBPM.Add(CNPM);
            }
            reader.Close();

            return NhanLucCBPM;
        }
    }
}
