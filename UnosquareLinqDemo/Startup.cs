using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnosquareLinqDemo.Startup))]
namespace UnosquareLinqDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
