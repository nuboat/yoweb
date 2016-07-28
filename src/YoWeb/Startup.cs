using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using YoWeb.Facade;
using YoWeb.Module.Hello;

namespace YoWeb
{
    class Startup
    {
        public void ConfigureServices(IServiceCollection services) 
        {
            services.AddMvc();

            services.AddLogging();

            services.AddSingleton<IHelloWorld, HelloWorld>();
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvcWithDefaultRoute();
        }
    }
}
