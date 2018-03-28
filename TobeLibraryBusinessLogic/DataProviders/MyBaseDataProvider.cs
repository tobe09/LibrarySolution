using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TobeLibraryDataAccess;

namespace TobeLibraryBusinessLogic.DataProviders
{
    public class MyBaseDataProvider
    {
        protected LibraryContext _libContext;

        protected MyBaseDataProvider()
        {
            _libContext = new LibraryContext();
        }

        protected MyBaseDataProvider(LibraryContext libContext)
        {
            _libContext = libContext;
        }

        public void Dispose()
        {
            _libContext.Dispose();
        }
    }
}
