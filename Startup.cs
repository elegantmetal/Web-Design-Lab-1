using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_Design_Lab_1.Startup))]
namespace Web_Design_Lab_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
