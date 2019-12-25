using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class NhanLucKhoaCNTTAccess : DatabaseAccess
    {
        public List<NhanLucKhoa> DisplayNhanLucKhoa(string makhoa,string nam)
        {
            List<NhanLucKhoa> nhanlucKhoa = new List<NhanLucKhoa>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "NhanLucKhoa";
            command.Connection = conn;

            SqlParameter parMa1 = new SqlParameter("@nam", System.Data.SqlDbType.VarChar);
            SqlParameter parMa2 = new SqlParameter("@makhoa", System.Data.SqlDbType.VarChar);
            parMa1.Value = nam;
            parMa2.Value = makhoa;
            command.Parameters.Add(parMa1);
            command.Parameters.Add(parMa2);

            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                string tenkhoa = reader.GetString(0);
                int sogs = reader.GetInt32(1);
                int sopgs = reader.GetInt32(2);
                int sotskh = reader.GetInt32(3);
                int sots = reader.GetInt32(4);
                int soths = reader.GetInt32(5);
                int sogvcc = reader.GetInt32(6);
                int sogv = reader.GetInt32(7);
                int sogvc = reader.GetInt32(8);
                int sotrg = reader.GetInt32(9);
                int tong = reader.GetInt32(10);

                NhanLucKhoa NLKCNTT = new NhanLucKhoa();
                NLKCNTT.TenKhoa = tenkhoa;
                NLKCNTT.SoGS = sogs;
                NLKCNTT.SoPGS = sopgs;
                NLKCNTT.SoTSKH = sotskh;
                NLKCNTT.SoTS = sots;
                NLKCNTT.SoThS = soths;
                NLKCNTT.SoGVCC = sogvcc;
                NLKCNTT.SoGV = sogv;
                NLKCNTT.SoGVC = sogvc;
                NLKCNTT.SoTrG = sotrg;
                NLKCNTT.Tong = tong;

                nhanlucKhoa.Add(NLKCNTT);
            }
            reader.Close();
            return nhanlucKhoa;
        }
    }
}
