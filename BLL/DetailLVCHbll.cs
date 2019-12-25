using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class DetailLVCHbll
    {
        DetaiLVCHAccess DLVCHA = new DetaiLVCHAccess();
        public List<DetailLVCH> detailLVCH(string magv, string nam)
        {
            return DLVCHA.detailLVCH(magv, nam);
        }
    }
}
