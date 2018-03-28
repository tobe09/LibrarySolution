using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TobeLibraryBusinessLogic.DataProviders;
using TobeLibraryDataAccess;
using LibraryEntities;

namespace TobeLibraryBusinessLogic.Services
{
    public class HomeService
    {
        private HomeDataProvider _homeDp;

        public HomeService()
        {
            _homeDp = new HomeDataProvider(new LibraryContext());
        }

        public HomeService(LibraryContext libContext)
        {
            _homeDp = new HomeDataProvider(libContext);
        }

        public Administrators GetAdminForEdit(int id)
        {
            Administrators admin = _homeDp.GetAdminForEdit(id);
            return admin;
        }

        public void Dispose()
        {
            _homeDp.Dispose();
        }
    }
}
