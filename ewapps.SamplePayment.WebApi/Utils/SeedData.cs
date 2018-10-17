using ewApps.SamplePayment.Data;
using ewApps.SamplePayment.Entity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ewapps.SamplePayment.WebApi.Utils
{
  public static class SeedData
  {
    public static void AddTestData(IServiceProvider serviceProvider)
    {
      var context = serviceProvider.GetRequiredService<ApiContext>();
      context.Database.EnsureCreated();

      var testInvoice = new Invoice
      {
        Id = "ti123",
        InvoiceNumber = "Inv1",
        Amount = 20000
      };

      context.Invoices.Add(testInvoice);

      var testPayment1 = new Payment
      {
        Id = "tp123",
        InvoiceId = "Inv1",
        Amount = 5000,
        PaymentDate = DateTime.UtcNow
      };

      context.Payments.Add(testPayment1);

      context.SaveChanges();
    }
  }
}
