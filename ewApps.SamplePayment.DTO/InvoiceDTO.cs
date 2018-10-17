using System;
using System.Collections.Generic;

namespace ewApps.SamplePayment.DTO
{
  public class InvoiceDTO
  {
    public string Id { get; set; }

    public string InvoiceNumber { get; set; }

    public double Amount { get; set; }

    public List<PaymentDTO> Payments { get; set; }

    public double RemainingAmount
    {
      get
      {
        double paidAmount = 0;
        foreach (PaymentDTO payment in Payments) {
          paidAmount += payment.Amount;
        }
        return Amount - paidAmount;
      }
    }
  }
}
