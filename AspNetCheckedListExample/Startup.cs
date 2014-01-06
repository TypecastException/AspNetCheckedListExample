using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetCheckedListExample.Startup))]
namespace AspNetCheckedListExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
