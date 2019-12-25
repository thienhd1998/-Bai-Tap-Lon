using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;


namespace BLL
{
    public class HocViMaxbll
    {
        HocViMaxAccess HV = new HocViMaxAccess();
        public List<HocViMax> DisplayHV(string nam, string magv)
        {
            return HV.DisplayHV(nam, magv);
        }
    }
}
