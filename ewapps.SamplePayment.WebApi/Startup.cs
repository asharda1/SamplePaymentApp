using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ewapps.SamplePayment.WebApi.Utils;
using ewApps.SamplePayment.Data;
using ewApps.SamplePayment.Entity;
using ewApps.SampleProject.DataService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ewapps.SamplePayment.WebApi
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
      // Auto Mapper Configurations
      var mappingConfig = new MapperConfiguration(mc =>
      {
        mc.AddProfile(new MappingProfile());
      });
      IMapper mapper = mappingConfig.CreateMapper();
      services.AddSingleton(mapper);

      services.AddTransient<PaymentData>();
      services.AddTransient<InvoiceData>();
      services.AddTransient<PaymentDataService>(); 
      services.AddTransient<InvoiceDataService>();

      services.AddDbContext<ApiContext>(opt => opt.UseInMemoryDatabase());
      services.AddMvcCore()
                .AddAuthorization()
                .AddJsonFormatters();

      services.AddAuthentication("Bearer")
               .AddIdentityServerAuthentication(options =>
               {
                 options.Authority = "https://localhost:44334";
                 options.RequireHttpsMetadata = false;//to avoid https protocol
                 options.ApiName = "api1";
               });
      
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      app.UseAuthentication();
      app.UseMvc();
      
    }

    
  }
}
