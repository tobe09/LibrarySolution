using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TobeLibraryDataAccess;
using TobeLibraryBusinessLogic.DataProviders;
using LibraryEntities;

namespace TobeLibraryBusinessLogic.Services
{
    public class LoginService : MyBaseService
    {
        private LoginDataProvider _loginDp;

        public LoginService()
        {
            _loginDp = new LoginDataProvider();
        }

        public LoginService(LibraryContext libContext)
        {
            _loginDp = new LoginDataProvider(libContext);
        }


        public Administrators LoginAdmin(string username, string password)
        {
            Administrators admin = _loginDp.GetLoginAdmin(username, password);

            return admin;
        }

        public void Dispose()
        {
            _loginDp.Dispose();
        }
    }
}
