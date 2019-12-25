using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class GiangDayDetailAccess : DatabaseAccess
    {
        public List<GiangDayDetail> DisplayMonHoc(string magv, string nam)
        {
            List<GiangDayDetail> GiangDayDetail = new List<GiangDayDetail>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "GiangDayChiTiet";
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
                string namhoc = reader.GetString(0);
                string tenhp = reader.GetString(1);
                string doituonghoc = reader.GetString(2);

                GiangDayDetail GDdetail = new GiangDayDetail();
                GDdetail.NamHoc = namhoc;
                GDdetail.TenHP = tenhp;
                GDdetail.DoiTuong = doituonghoc;

                GiangDayDetail.Add(GDdetail);
            }
            reader.Close();
            return GiangDayDetail;
        }
    }
}
