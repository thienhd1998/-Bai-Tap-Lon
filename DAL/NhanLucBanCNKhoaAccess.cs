using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class NhanLucBanCNKhoaAccess:DatabaseAccess
    {
        public List<NhanLucBanCNKhoa>HienThiNhanLucKhoa(string nam)
        {
            List<NhanLucBanCNKhoa> NhanLucKhoa = new List<NhanLucBanCNKhoa>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "ThongKeCNKhoa";
            command.Connection = conn;

            SqlParameter parMa = new SqlParameter("@nam", System.Data.SqlDbType.VarChar);
            parMa.Value = nam;
            command.Parameters.Add(parMa);

            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read()) 
            {
                string tengv = reader.GetString(0);
                string tencv = reader.GetString(1);
                string tenhh = reader.GetString(2);
                string tenhv = reader.GetString(3);
                string magv = reader.GetString(4);

                NhanLucBanCNKhoa khoa = new NhanLucBanCNKhoa();
                khoa.TenGV = tengv;
                khoa.TenChucVu = tencv;
                khoa.TenHocHam = tenhh;
                khoa.TenHocVi = tenhv;
                khoa.MaGV = magv;

                NhanLucKhoa.Add(khoa);
            }
            reader.Close();
            return NhanLucKhoa;
        }
    }
}
