using System.Reflection;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Darkk3nDevs.Stationary.Server
{
   public class Startup
   {
      public Startup(IConfiguration configuration)
      {
         Configuration = configuration;
      }

      public IConfiguration Configuration { get; }

      // This method gets called by the runtime. Use this method to add services to the container.
      public void ConfigureServices(IServiceCollection services)
      {
         services.AddControllers();

         services.AddMediatR(typeof(Startup).GetTypeInfo().Assembly);

         services.AddSwaggerGen(c =>
         {

            c.SwaggerDoc("v1", new OpenApiInfo
            {
               Version = "v1",
               Title = "Stationary API",
               Description = "Stationary ASP.NET Core Web API",
               Contact = new OpenApiContact
               {
                  Name = "Darkk3nDevs.Stationary.API",
                  Email = "gerardo.aguilar01@outlook.com"
               }
            });

         });
      }

      // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
      public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
      {
         if (env.IsDevelopment())
         {
            app.UseDeveloperExceptionPage();
         }

         app.UseHttpsRedirection();

         app.UseRouting();

         app.UseAuthorization();

         app.UseEndpoints(endpoints =>
         {
            endpoints.MapControllers();
         });

         app.UseSwagger();

         app.UseSwaggerUI(c =>
         {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            c.InjectStylesheet("/swagger/custom.css");
         });
      }
   }
}
