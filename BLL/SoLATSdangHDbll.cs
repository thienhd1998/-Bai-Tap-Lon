using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class SoLATSdangHDbll
    {
        SoLATSdangHDAccess LATS = new SoLATSdangHDAccess();
        public List<SoLATSdanghd> SoLATSDANGHD(string magv, string nam)
        {
            return LATS.SoLATSdangHD(magv, nam);
        }
    }
}
