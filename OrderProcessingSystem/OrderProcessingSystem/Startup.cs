using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OrderProcessingSystem.Startup))]
namespace OrderProcessingSystem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
