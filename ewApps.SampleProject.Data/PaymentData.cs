using ewApps.SamplePayment.Entity;
using System;
using System.Threading.Tasks;

namespace ewApps.SamplePayment.Data
{
    public class PaymentData
    {
    private readonly ApiContext _context;
    public PaymentData(ApiContext context)
    {
      _context = context;
    }

    public async Task<Payment> Get(string paymentId)
    {
      var payment = await _context.Payments.FindAsync(paymentId);
      return payment;
    }

  }
}
