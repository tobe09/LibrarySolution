using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TobeLibrary.Startup))]
namespace TobeLibrary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
