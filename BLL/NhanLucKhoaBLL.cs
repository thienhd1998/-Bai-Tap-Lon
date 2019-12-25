using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class NhanLucKhoaBLL
    {
        NhanLucBanCNKhoaAccess NLK = new NhanLucBanCNKhoaAccess();
        public List<NhanLucBanCNKhoa> HienThiNhanLucKhoa(string nam)
        {
            return NLK.HienThiNhanLucKhoa(nam);
        }

        
    }
}
