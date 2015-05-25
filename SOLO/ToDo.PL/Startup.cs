using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDo.PL.Startup))]
namespace ToDo.PL
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
