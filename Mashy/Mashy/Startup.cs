using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mashy.Startup))]
namespace Mashy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
