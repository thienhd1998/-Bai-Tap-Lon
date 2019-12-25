using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class GiangDayDetailbll
    {
        GiangDayDetailAccess GDDetai = new GiangDayDetailAccess();
        public List<GiangDayDetail> DisplayMonHoc(string magv, string nam)
        {
            return GDDetai.DisplayMonHoc(magv, nam);
        }
    }
}
