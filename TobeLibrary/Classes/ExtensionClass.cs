using System.Web.Mvc;
using TobeLibraryBusinessLogic.Services;

namespace TobeLibrary.Controllers
{
    public static class ExtensionClass
    {
        public static bool IsValidObject(this Controller ctrl, object model)
        {
            VerificationService verifySvc = new VerificationService();
            return verifySvc.IsValidObject(model);
        }
    }
}