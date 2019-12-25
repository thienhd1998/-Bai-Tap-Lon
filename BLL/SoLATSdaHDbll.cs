using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class SoLATSdaHDbll
    {
        SoLATSdaHDAccess LATS = new SoLATSdaHDAccess();
        public List<SoLATSdahd> SoLATSDAHD(string magv, string nam)
        {
            return LATS.SoLATSDAHD(magv, nam);
        }
    }
}
