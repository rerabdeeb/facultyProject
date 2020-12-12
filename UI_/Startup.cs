using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UI_.Startup))]
namespace UI_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
