using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TLKhacbll
    {
        TLKhacAccess TLKA = new TLKhacAccess();
        public List<TLKhac> DisplayTLKhac(string magv, string nam)
        {
            return TLKA.DisplayTLKhac(magv, nam);
        }
    }
}
