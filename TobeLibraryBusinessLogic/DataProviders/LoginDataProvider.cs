using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TobeLibraryDataAccess;
using LibraryEntities;

namespace TobeLibraryBusinessLogic.DataProviders
{
    class LoginDataProvider
    {
        private LibraryContext _libContext;
        
        internal LoginDataProvider(LibraryContext libContext)
        {
            _libContext = libContext;
        }

        internal Users GetLoginUser(string username, string password)
        {
            var users = from user in _libContext.Users
                        where user.UserName == username && user.Password == password
                        select user;

            return users.FirstOrDefault();
        }
    }
}
