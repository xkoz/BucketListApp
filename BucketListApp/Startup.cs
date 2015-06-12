using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BucketListApp.Startup))]
namespace BucketListApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
