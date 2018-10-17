using System;
using System.Collections.Generic;
using System.Text;
using ewApps.SamplePayment.Entity;
using Microsoft.EntityFrameworkCore;

namespace ewApps.SamplePayment.Data
{
    public class ApiContext : DbContext
    {
      public ApiContext(DbContextOptions<ApiContext> options)
          : base(options)
      {
      }

      public DbSet<Invoice> Invoices { get; set; }

      public DbSet<Payment> Payments { get; set; }
    }
  }

