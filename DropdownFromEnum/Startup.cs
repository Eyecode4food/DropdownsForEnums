using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DropdownFromEnum.Startup))]
namespace DropdownFromEnum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
