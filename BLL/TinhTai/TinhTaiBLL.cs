using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL.TinhTai;

namespace BLL.TinhTai
{
    public class TinhTaiBLL
    {
        TinhTaiGDAccess TTGD = new TinhTaiGDAccess();
        public List<ThongTinTaiGD> HienThiTaiGD(string magv, string loaihinhDT, string namhoc)
        {
            return TTGD.HienThiTaiGD(magv, loaihinhDT, namhoc);
        }

        public double TinhTai(string magv, string loaihinhDT, string nam)
        {
            return TTGD.TinhTai(magv, loaihinhDT, nam);
        }

        public Double TongTaiGD(string magv, string nam)
        {
            return TTGD.TongTaiGD(magv, nam);
        }
    }

}
