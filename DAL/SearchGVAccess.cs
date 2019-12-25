using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;


namespace DAL
{
    public class SearchGVAccess : DatabaseAccess
    {
        public List<SearchGV> DisplaySearchGV(string tengv)
        {
            List<SearchGV> searchGV = new List<SearchGV>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "SearchGV";
            command.Connection = conn;

            SqlParameter parMa1 = new SqlParameter("@tengv", System.Data.SqlDbType.NVarChar);
            parMa1.Value = tengv;
            command.Parameters.Add(parMa1);

            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                string id = reader.GetString(0);
                string tenGV = reader.GetString(1);

                SearchGV SGV = new SearchGV();
                SGV.ID = id;
                SGV.TenGv = tenGV;
                searchGV.Add(SGV);
            }
            reader.Close();
            return searchGV;
        }
    }
}
