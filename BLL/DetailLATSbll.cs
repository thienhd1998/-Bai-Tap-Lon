using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class DetailLATSbll
    {
        DetailLATSAccess DLATSA = new DetailLATSAccess();
        public List<DetailLATS> detailLATS(string magv, string nam)
        {
            return DLATSA.detailLATS(magv, nam);
        }
    }
}
