using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcAndWebApiDemo.Startup))]
namespace MvcAndWebApiDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
