using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChildBinding.Startup))]
namespace ChildBinding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
