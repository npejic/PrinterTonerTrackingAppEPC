using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrinterTonerAppEPC.Startup))]
namespace PrinterTonerAppEPC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
