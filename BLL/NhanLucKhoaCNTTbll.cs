using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class NhanLucKhoaCNTTbll
    {
        NhanLucKhoaCNTTAccess NLKCNTTA = new NhanLucKhoaCNTTAccess();
        public List<NhanLucKhoa> DisplayNhanLucKhoa(string makhoa,string nam)
        {
            return NLKCNTTA.DisplayNhanLucKhoa(makhoa,nam);
        }
    }
}
