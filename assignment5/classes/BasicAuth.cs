using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignment5.interfaces;

namespace assignment5.classes
{
    internal class BasicAuth : IAuthService
    {
        public bool AuthenticateUser(string username, string password)
        {
            if((username == Data.username1 && password == Data.passowrd1)  ||
               (username==Data.username2 && password == Data.passowrd2))
            {
                return true;
            }
            return false;

        }

        public bool authorizeUser(string username, string Role)
        {
            if((username == Data.username1 && Role == Data.Role1) || (username == Data.username2 && Role == Data.Role2))
            {
                return true;
            }
            return false;
        }
    }
}
