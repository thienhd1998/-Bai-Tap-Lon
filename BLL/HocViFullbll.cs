using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class HocViFullbll
    {
        HocViFullAccess HVFA = new HocViFullAccess();
        public List<HocViFull> DisplayHVFull(string magv, string nam)
        {
            return HVFA.DisplayHVFull(magv, nam);
        }
    }
}
