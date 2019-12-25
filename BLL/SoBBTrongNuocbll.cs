using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class SoBBTrongNuocbll
    {
        SoBBTrongNuocAccess SBBin = new SoBBTrongNuocAccess();
        public List<SoBaiBao> DisplaySoBB(string magv, string nam)
        {
            return SBBin.DisplaySoBB(magv, nam);
        }
    }
}
