using System;
using System.Collections.Generic;
using System.Text;

namespace ewApps.SamplePayment.Entity
{
  public class Payment
  {
    public string Id { get; set; }
    public string InvoiceId{ get; set; }
    public double Amount { get; set; }
    public DateTime PaymentDate { get; set; }
  }
}
