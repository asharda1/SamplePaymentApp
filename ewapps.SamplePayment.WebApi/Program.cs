using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ewapps.SamplePayment.WebApi.Utils;
using ewApps.SamplePayment.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ewapps.SamplePayment.WebApi
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = BuildWebHost(args);
      using (var scope = host.Services.CreateScope())
      {
        var services = scope.ServiceProvider;
        var context = services.GetRequiredService<ApiContext>();
        try
        {
          SeedData.AddTestData(services);
        }
        catch (Exception ex)
        {
          var logger = services.GetRequiredService<ILogger<Program>>();
          logger.LogError(ex, "An error occurred seeding the DB.");
        }
        host.Run();
      }
  }

  public static IWebHost BuildWebHost(string[] args) =>
      WebHost.CreateDefaultBuilder(args)
          .UseStartup<Startup>()
          .Build();
}
}
