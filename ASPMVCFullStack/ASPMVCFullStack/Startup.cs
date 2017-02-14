using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPMVCFullStack.Startup))]
namespace ASPMVCFullStack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
