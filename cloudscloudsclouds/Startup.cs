using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cloudscloudsclouds.Startup))]
namespace cloudscloudsclouds
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
