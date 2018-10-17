using AutoMapper;
using ewApps.SamplePayment.Data;
using ewApps.SamplePayment.DTO;
using ewApps.SamplePayment.Entity;
using System;
using System.Threading.Tasks;

namespace ewApps.SampleProject.DataService
{
    public class PaymentDataService
    {
    PaymentData _paymentData;
    IMapper _mapper;
    public PaymentDataService(PaymentData paymentData,IMapper mapper) {
      _paymentData = paymentData;
      _mapper = mapper;
    }

    public async Task<PaymentDTO> Get(string paymentId)
    {
      PaymentDTO paymentDTO = null;
      Payment payment = await _paymentData.Get(paymentId);
      if (payment != null)
        paymentDTO = _mapper.Map<Payment,PaymentDTO>(payment);
      return paymentDTO;
    }  


  }
}
