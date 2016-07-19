using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lecture.Startup))]
namespace Lecture
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
