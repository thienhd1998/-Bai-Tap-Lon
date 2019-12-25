using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class Namebll
    {
        NameAccess NA = new NameAccess();
        public List<Name> DisplayName(String magv)
        {
            return NA.DisplayName(magv);
        }
    }
}
