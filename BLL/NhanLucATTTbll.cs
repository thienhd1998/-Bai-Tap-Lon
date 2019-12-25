using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class NhanLucATTTbll
    {
        ChucVuATTTAccess CVATTT = new ChucVuATTTAccess();
        public List<NhanLucATTT> HienThiNhanLucATTT(string nam, string mabm)
        {
            return CVATTT.HienThiNhanLucATTT(nam, mabm);
        }
    }
}
