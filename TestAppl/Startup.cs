using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAppl.Startup))]
namespace TestAppl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            System.Console.WriteLine("Everything's working fine");
        }
    }
}
