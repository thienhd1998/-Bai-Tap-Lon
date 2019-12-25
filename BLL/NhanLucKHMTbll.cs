using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class NhanLucKHMTbll
    {
        ChucVuKHMTAccess CVKHMT = new ChucVuKHMTAccess();
        public List<NhanLucKHMT> HienThiNhanLucKHMT(string nam, string mabm)
        {
            return CVKHMT.HienThiNhanLucKHMT(nam, mabm);
        }
    }
}
