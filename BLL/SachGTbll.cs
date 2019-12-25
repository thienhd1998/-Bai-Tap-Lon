using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class SachGTbll
    {
        SachGTAccess SGTA = new SachGTAccess();
        public List<SachGT> DisplaySachGT(string magv, string nam)
        {
            return SGTA.DisplaySachGT(magv, nam);
        }
    }
}
