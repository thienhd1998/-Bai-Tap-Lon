using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class LietKeBBbll
    {
        LietKeBBAccess LKBBA = new LietKeBBAccess();
        public List<LietKeBB> DisplayLietKeBB(string magv, string nam)
        {
            return LKBBA.DisplayLietKeBB(magv, nam);
        }
    }
}
