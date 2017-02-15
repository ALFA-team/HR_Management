using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HR_Management.Startup))]
namespace HR_Management
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
