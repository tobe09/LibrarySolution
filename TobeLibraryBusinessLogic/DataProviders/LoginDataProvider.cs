using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TobeLibraryDataAccess;
using LibraryEntities;

namespace TobeLibraryBusinessLogic.DataProviders
{
    class LoginDataProvider : MyBaseDataProvider
    {
        internal LoginDataProvider() : base() { }
        internal LoginDataProvider(LibraryContext libContext) : base(libContext) { }

        internal Administrators GetLoginAdmin(string username, string password)
        {
            var adm = from admin in _libContext.Administrators
                      where admin.UserName == username && admin.Password == password
                      select admin;

            return adm.FirstOrDefault();
        }
    }
}
