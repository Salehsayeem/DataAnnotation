using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrudwithDataAnnotation.Startup))]
namespace CrudwithDataAnnotation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
