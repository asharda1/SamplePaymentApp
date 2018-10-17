using AutoMapper;
using ewApps.SamplePayment.DTO;
using ewApps.SamplePayment.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ewapps.SamplePayment.WebApi
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      // Add as many of these lines as you need to map your objects
      CreateMap<Invoice, InvoiceDTO>();
      CreateMap<InvoiceDTO, Invoice>();
      CreateMap<Payment, PaymentDTO>();
      CreateMap<PaymentDTO, Payment>();

    }
  }
}

