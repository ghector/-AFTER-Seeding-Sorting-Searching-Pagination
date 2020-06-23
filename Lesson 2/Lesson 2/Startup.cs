using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lesson_2.Startup))]
namespace Lesson_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
