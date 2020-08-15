using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using CookyWebsite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CookyWebsite
{
  public class Startup
  {

    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration) => Configuration = configuration;

    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddDbContext<ApplicationDbContext>(options =>
      options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));

      services.AddMvc();
      services.AddTransient<IReceipeRepository, EFReceipeRepository>();
      // services.AddTransient<IReceipeRepository, TestRepository>();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseStatusCodePages();
      app.UseStaticFiles();
      app.UseMvc(routes =>
      {
        routes.MapRoute(
          name: "receipePage",
          template: "Receipes/Page{page}",
          defaults: new { controller = "Home", action = "Discover"});

        routes.MapRoute(
          name: "default",
          template: "{controller=Home}/{action=Index}/{id?}");
      });

      SeedData.EnsurePopulated(app);
    }
  }
}
