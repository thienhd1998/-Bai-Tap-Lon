using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class UserAccess : DatabaseAccess
    {
        public  string getID(string magv, string pass)
        {
            string id="";
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id from NguoiDung where MaGV = '"+magv+"' and UserPass = '"+pass+"'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
              int ID = reader.GetInt32(0);
                id = ID.ToString();              
            }
            
            reader.Close();
            return id;        
        }
    }
}
