using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExperienceITAlumni.Startup))]
namespace ExperienceITAlumni
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
        
    }
}
