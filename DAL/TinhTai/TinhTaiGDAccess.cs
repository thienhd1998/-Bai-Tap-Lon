using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL.TinhTai
{
    public class TinhTaiGDAccess : DatabaseAccess
    {
        //Hiển thị thông tin tải giảng dạy
        public List<ThongTinTaiGD> HienThiTaiGD(string magv, string loaihinhDT, string namhoc)
        {
            List<ThongTinTaiGD> TTtaiGD = new List<ThongTinTaiGD>();
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ThongTinTaiGD";
            cmd.Connection = conn;

            SqlParameter parMa1 = new SqlParameter("@magv", System.Data.SqlDbType.VarChar);
            SqlParameter parMa2 = new SqlParameter("@loaihinhDT", System.Data.SqlDbType.VarChar);
            SqlParameter parMa3 = new SqlParameter("@namhoc", SqlDbType.VarChar);
            parMa1.Value = magv;
            parMa2.Value = loaihinhDT;
            parMa3.Value = namhoc;
            cmd.Parameters.Add(parMa1);
            cmd.Parameters.Add(parMa2);
            cmd.Parameters.Add(parMa3);

            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                string tenhp = rd.GetString(0);
                int syso = rd.GetInt32(1);
                string hedaotao = rd.GetString(2);
                string tenlophp = rd.GetString(3);
                int sotc = rd.GetInt32(4);
                int sotiet = rd.GetInt32(5);
                double giochuan = rd.GetDouble(6);
                string ghichu = rd.GetString(7);

                ThongTinTaiGD TTGD = new ThongTinTaiGD();
                TTGD.TenHP = tenhp;
                TTGD.SySo = syso;
                TTGD.HeDaoTao = hedaotao;
                TTGD.TenLopHP = tenlophp;
                TTGD.SoTC = sotc;
                TTGD.SoTiet = sotiet;
                TTGD.GioChuan = giochuan;
                TTGD.GhiChu = ghichu;

                TTtaiGD.Add(TTGD);
            }
            rd.Close();
            CloseConnection();
            return TTtaiGD;
        }

        //Tính tải giảng dạy theo loại hình đào tạo(đại học, cao học...)
        public double TinhTai(string magv, string loaihinhDT, string nam)
        {
            try
            {
                double gc = 0;
                OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TinhtaiGD";
                cmd.Connection = conn;

                SqlParameter p1 = new SqlParameter("@magv", SqlDbType.VarChar);
                SqlParameter p2 = new SqlParameter("@loaihinhDT", SqlDbType.VarChar);
                SqlParameter p3 = new SqlParameter("@namhoc", SqlDbType.NVarChar);
                p1.Value = magv;
                p2.Value = loaihinhDT;
                p3.Value = nam;
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);

                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    gc = rd.GetDouble(0);
                }
                rd.Close();
                CloseConnection();
                return gc;
            }
            catch(Exception)
            {
                return 0;
            }
            
        }

        //Tính tổng tải giảng dạy
        public double TongTaiGD(string magv, string nam)
        {
            try
            {
                string strConn = "Data Source=DESKTOP-5SRTCNL\\SQLEXPRESS ;Database=Quản lý giáo viên đại học;User id=sa; pwd=TheThinh1111 ";
                using (SqlConnection con = new SqlConnection(strConn))
                {
                    double gc = 0;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "TongTaiGD";
                    cmd.Connection = con;

                    SqlParameter p1 = new SqlParameter("@magv", SqlDbType.VarChar);
                    SqlParameter p2 = new SqlParameter("@namhoc", SqlDbType.NVarChar);
                    p1.Value = magv;
                    p2.Value = nam;
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);


                    SqlDataReader rd1 = cmd.ExecuteReader();
                    while (rd1.Read())
                    {
                        gc = rd1.GetDouble(0);
                    }
                    rd1.Close();
                    con.Close();
                    return gc;
                }
            }
            catch(Exception)
            {
                return 0;
            }
                
        }
    }
}
