using AutoMapper;
using ewApps.SamplePayment.Data;
using ewApps.SamplePayment.DTO;
using ewApps.SamplePayment.Entity;
using System;
using System.Threading.Tasks;

namespace ewApps.SampleProject.DataService
{
  public class InvoiceDataService
  {
    InvoiceData _invoiceData;
    IMapper _mapper;
    public InvoiceDataService(InvoiceData invoiceData, IMapper mapper)
    {
      _invoiceData = invoiceData;
      _mapper = mapper;
    }

    public async Task<InvoiceDTO> Get(string invoiceId)
    {
      InvoiceDTO invoiceDTO = null;
      Invoice invoice = await _invoiceData.Get(invoiceId);
      if (invoice != null)
        invoiceDTO = _mapper.Map<Invoice, InvoiceDTO>(invoice);
      return invoiceDTO;
    }


  }
}
