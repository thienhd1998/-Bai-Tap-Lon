using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class NameAccess : DatabaseAccess
    {
        public List<Name> DisplayName(String magv)
        {
            List<Name> name = new List<Name>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "DisplayName";
            command.Connection = conn;

            SqlParameter parMa = new SqlParameter("@magv", System.Data.SqlDbType.VarChar);
            parMa.Value = magv;
            command.Parameters.Add(parMa);

            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                string tengv = reader.GetString(0);

                Name Name = new Name();
                Name.TenGV = tengv;

                name.Add(Name);
            }
            reader.Close();
            return name;
        }
    }
}
