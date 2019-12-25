using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class NhanLucCNPMbll
    {
        ChucVuBMCNPMAccess CVCNPM = new ChucVuBMCNPMAccess();
        public List<NhanLucBMCNPM> HienThiNhanLucCNPM(string nam, string mabm)
        {
            return CVCNPM.HienThiNhanLucCNPM(nam, mabm);
        }
    }
}
