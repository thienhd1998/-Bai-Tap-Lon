using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class GetTenGVBLL
    {
        GetTenGVAccess GT = new GetTenGVAccess();
        public string GetTenGV(string magv)
        {
            return GT.GetTenGV(magv);
        }
    }
}
