using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sales_1.Backend.Startup))]
namespace Sales_1.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
