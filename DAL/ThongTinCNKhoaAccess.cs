using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class ThongTinCNKhoaAccess : DatabaseAccess
    {
        public List<ThongTinCNKhoa> DisplayTTCNKhoa(string magv, string nam)
        {
            List<ThongTinCNKhoa> TTCNKhoa = new List<ThongTinCNKhoa>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "ThongTinCNKhoa";
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

                ThongTinCNKhoa CNKhoa = new ThongTinCNKhoa();
                CNKhoa.TenGV = tengv;
                CNKhoa.TenBM = tenbm;
                CNKhoa.TenChucVu = tencv;
                CNKhoa.GT = GT;
                CNKhoa.QueQuan = quequan;
                CNKhoa.Email = email;
                CNKhoa.NgaySinh = ngaysinh.ToString("dd-MM-yyyy");
                CNKhoa.DienThoai = dienthoai;

                TTCNKhoa.Add(CNKhoa);
            }
            reader.Close();
            return TTCNKhoa;
        }
    }
}
