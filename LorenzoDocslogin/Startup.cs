using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LorenzoDocslogin.Startup))]
namespace LorenzoDocslogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
