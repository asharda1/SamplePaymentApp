using ewApps.SamplePayment.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ewApps.SamplePayment.Data
{
    public class InvoiceData
    {
    private readonly ApiContext _context;
    public InvoiceData(ApiContext context)
    {
      _context = context;
    }

    public async Task<Invoice> Get(string invoiceId)
    {
      var invoice = await _context.Invoices.FindAsync(invoiceId);
      return invoice;
    }

  }
}
