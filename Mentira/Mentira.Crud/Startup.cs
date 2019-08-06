using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mentira.Crud.Startup))]
namespace Mentira.Crud
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
