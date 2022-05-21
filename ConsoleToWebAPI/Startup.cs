using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsoleToWebAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

        }
        public void Configure(IApplicationBuilder app,IWebHostEnvironment env)
        {
            //app.Run(async content =>
            //    {
            //        await content.Response.WriteAsync("party to banti ha");
            //    });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                //endpoints.MapGet("/", async content =>
                //{
                //    await content.Response.WriteAsync("party to banti ha");
                //});
            });

        }
    }
}
