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
    public class LoginService
    {
        private LoginDataProvider _loginDp;

        public LoginService()
        {
            _loginDp = new LoginDataProvider(new LibraryContext());
        }

        public LoginService(LibraryContext libContext)
        {
            _loginDp = new LoginDataProvider(libContext);
        }

        public Users LoginUser(string username,string password)
        {
            Users user = _loginDp.GetLoginUser(username, password);

            return user;
        }
    }
}
