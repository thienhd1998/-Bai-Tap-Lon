using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class ChucVuHTTAccess : DatabaseAccess
    {
        public List<NhanLucHTTT> HienThiNhanLucHTTT(string nam, string mabm)
        {
            List<NhanLucHTTT> NhanLucHTTT = new List<NhanLucHTTT>();
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
            while (reader.Read())
            {
                string tengv = reader.GetString(0);
                string tencv = reader.GetString(1);
                string tenhh = reader.GetString(2);
                string tenhv = reader.GetString(3);
                string magv = reader.GetString(4);

                NhanLucHTTT HTTT = new NhanLucHTTT();
                HTTT.TenGV = tengv;
                HTTT.TenChucVu = tencv;
                HTTT.TenHocHam = tenhh;
                HTTT.TenHocVi = tenhv;
                HTTT.MaGV = magv;

                NhanLucHTTT.Add(HTTT);
            }
            reader.Close();

            return NhanLucHTTT;
        }
    }
}
