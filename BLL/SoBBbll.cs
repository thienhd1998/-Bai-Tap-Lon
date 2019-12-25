using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class SoBBbll
    {
        SoBBQuocTeAccess soBBQTA = new SoBBQuocTeAccess();
        public List<SoBaiBao> DisplaySoBB(string magv, string nam)
        {
            return soBBQTA.DisplaySoBB(magv, nam);
        }
    }
}
