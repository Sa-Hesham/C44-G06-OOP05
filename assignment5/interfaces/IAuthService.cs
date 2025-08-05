using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5.interfaces
{
    internal interface IAuthService
    {

        public bool AuthenticateUser(string username, string password);
        public bool authorizeUser(string username, string Role);
    }
}
