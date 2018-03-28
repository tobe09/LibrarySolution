using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobeLibraryBusinessLogic.Services
{
    public class VerificationService
    {
        public bool IsValidObject(object serviceObj)
        {
            var svcObj = serviceObj as ErrorSevice;
            bool status = svcObj == null;       

            return status;
        }
    }

    public class ErrorSevice
    {
        public string ServiceName { get; set; }
        public string ErrorMessage { get; set; }
    }
}
