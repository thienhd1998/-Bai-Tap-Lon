using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ThongTinCNKhoabll
    {
        ThongTinCNKhoaAccess TTCNK = new ThongTinCNKhoaAccess();
        public List<ThongTinCNKhoa> DisplayTTCNKhoa(string magv, string nam)
        {
            return TTCNK.DisplayTTCNKhoa(magv,nam);
        }
    }
}
