using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(employeeManager.web.Startup))]
namespace employeeManager.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
