using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class SoLVCHbll
    {
        SoLVCHAccess LVCH = new SoLVCHAccess();
        public List<SoLVCH> SoLVCH(string magv, string nam)
        {
            return LVCH.SoLVCH(magv, nam);
        }
    }
}
