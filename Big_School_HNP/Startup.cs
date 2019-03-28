using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Big_School_HNP.Startup))]
namespace Big_School_HNP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
