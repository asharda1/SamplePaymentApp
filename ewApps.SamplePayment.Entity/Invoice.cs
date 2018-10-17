using System;
using System.Collections.Generic;

namespace ewApps.SamplePayment.Entity
{
    public class Invoice
    {
    public string Id { get; set; }

    public string InvoiceNumber { get; set; }

    public double Amount { get; set; }

    public List<Payment> Payments { get; set; }
  }
}
