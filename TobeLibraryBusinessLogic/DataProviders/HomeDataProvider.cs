using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TobeLibraryDataAccess;
using LibraryEntities;

namespace TobeLibraryBusinessLogic.DataProviders
{
    class HomeDataProvider : MyBaseDataProvider
    {
        internal HomeDataProvider() : base() { }
        internal HomeDataProvider(LibraryContext libContext) : base(libContext) { }

        internal Administrators GetAdminForEdit(int id)
        {
            Administrators admin = _libContext.Administrators.SingleOrDefault(adm => adm.Id == id);
            return admin;
        }
    }
}
