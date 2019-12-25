using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class Userbll
    {
        UserAccess UA = new UserAccess();
        public string getID(string magv, string pass)
        {
            return UA.getID(magv, pass);
        }
    }
}
