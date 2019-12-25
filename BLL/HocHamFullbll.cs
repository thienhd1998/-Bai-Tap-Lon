using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class HocHamFullbll
    {
        HocHamFullAccess HHFA = new HocHamFullAccess();
        public List<HocHamFull> DisplayHHFull(string magv, string nam)
        {
            return HHFA.DisplayHHFull(magv, nam);
        }
    }
}
