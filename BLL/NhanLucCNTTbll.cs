using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class NhanLucCNTTbll
    {
        ChucVuCNTTAccess CVCNTT = new ChucVuCNTTAccess();
        public List<NhanLucCNTT> HienThiNhanLucCNTT(string nam, string mabm)
        {
            return CVCNTT.HienThiNhanLucCNTT(nam, mabm);
        }
    }
}
