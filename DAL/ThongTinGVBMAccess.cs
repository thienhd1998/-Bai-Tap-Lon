using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class ThongTinGVBMAccess : DatabaseAccess
    {
        public List<ThongTinGVBM> DisplayTTGVBM(string magv, string nam)
        {
            List<ThongTinGVBM> TTGVBM = new List<ThongTinGVBM>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "ThongTinGVBM";
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
                string tengv = reader.GetString(0);
                string tenbm = reader.GetString(1);
                string tencv = reader.GetString(2);
                string GT = reader.GetString(3);
                string quequan = reader.GetString(4);
                string email = reader.GetString(5);
                DateTime ngaysinh = reader.GetDateTime(6);
                string dienthoai = reader.GetString(7);

                ThongTinGVBM GVBM = new ThongTinGVBM();
                GVBM.TenGV = tengv;
                GVBM.TenBM = tenbm;
                GVBM.TenChucVu = tencv;
                GVBM.GT = GT;
                GVBM.QueQuan = quequan;
                GVBM.Email = email;
                GVBM.NgaySinh = ngaysinh.ToString("dd-MM-yyyy");
                GVBM.DienThoai = dienthoai;

                TTGVBM.Add(GVBM);

            }
            reader.Close();
            return TTGVBM;
        }
    
    }
}
