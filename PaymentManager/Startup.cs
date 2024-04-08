using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PaymentsDemo.Services.Payments;
using PaymentsDemo.Services.Payments.Interfaces;

namespace PaymentsDemo
{
  public class Startup
  {

    IConfiguration Configuration { get; set; }

    public Startup(IConfiguration config)
    {
      Configuration = config;
    }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddRazorPages();
      services.AddTransient<IPayment, AuthNetPaymentService>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseStaticFiles();
      app.UseRouting();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapRazorPages();
      });
    }
  }
}
