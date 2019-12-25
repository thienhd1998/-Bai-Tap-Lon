using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class SearchGVbll
    {
        SearchGVAccess SGVA = new SearchGVAccess();
        public List<SearchGV> DisplaySearchGV(string tengv)
        {
            return SGVA.DisplaySearchGV(tengv);
        }
    }
}
