using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;


namespace BLL
{
    public class HocHamMaxbll
    {
        HocHamMaxAccess HH = new HocHamMaxAccess();
        public List<HocHamMax> DisplayHH(string nam, string magv)
        {
            return HH.DisplayHH(nam, magv);
        }
    }
}
