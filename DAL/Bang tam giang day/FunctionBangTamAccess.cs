using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DAL.Bang_tam_giang_day 
{
    public class FunctionBangTamAccess : DatabaseAccess
    {
        //Lấy ra mã lớp hp có trong hệ thống 
        public string getAllMaLopHP(string malophp)
        {
            string id = "";
            OpenConnection();
            string sql = "Select MaLopHP from LopHP where MaLopHP='" + malophp + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                id = reader.GetString(0);
            }
            reader.Close();
            CloseConnection();
            return id;
        }

        //Lấy ra mã lớp học phần theo mã gv nhập vào
        public string getMaLopHP( string malopHP, string magv)
        {
            string id = "";
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select MaLopHP from TableFakeGD where MaLopHP = '"+malopHP+"' and MaGV='"+magv+"'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetString(0);
            }

            reader.Close();
            CloseConnection();
            return id;

        }

        //Hiển thị thông tin 
        public DataTable HienThi(string magv, string LoaiHinhDT)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GiangDayFake";
            cmd.Connection = conn;

            SqlParameter p1 = new SqlParameter("@magv", SqlDbType.VarChar);
            SqlParameter p2 = new SqlParameter("@LoaiHinhDT", SqlDbType.VarChar);
            p1.Value = magv;
            p2.Value = LoaiHinhDT;
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            rd.Close();
            CloseConnection();
            return dt;

        }

        //Thêm thông tin
        public void Insert(string magv, string malophp, string sotiet, string ghichu)
        {
            
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into TableFakeGD values (@maGV, @maLopHP,@soTiet, @ghiChu)";
            cmd.Connection = conn;
            cmd.Parameters.Add("@maGV", SqlDbType.VarChar).Value = magv;
            cmd.Parameters.Add("@maLopHP", SqlDbType.VarChar).Value = malophp;
            cmd.Parameters.Add("@soTiet", SqlDbType.Int).Value = sotiet;
            cmd.Parameters.Add("@ghiChu", SqlDbType.NVarChar).Value = ghichu;
            cmd.ExecuteNonQuery();
            CloseConnection();
                         
        }

        //Xóa thông tin
        public void Delete(string malophp)
        {
            OpenConnection();
            
            string sql = "delete from TableFakeGD where MaLopHP='"+malophp+"'";
            SqlCommand cmd = new SqlCommand(sql,conn);           
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        //Sửa thông tin
        public void Edit(string magv, string malophp, string sotiet, string ghichu)
        {
            OpenConnection();
            string sql = "update TableFakeGD set MaLopHP='" + malophp + "', SoTiet='" + sotiet + "', GhiChu=N'" + ghichu + "' where MaGV ='" + magv + "'and MaLopHP='"+malophp+"';";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
