using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class NhanLucHTTTbll
    {
        ChucVuHTTAccess CVHTTT = new ChucVuHTTAccess();
        public List<NhanLucHTTT> HienThiNhanLucHTTT(string nam, string mabm)
        {
            return CVHTTT.HienThiNhanLucHTTT(nam, mabm);
        }
    }
}
