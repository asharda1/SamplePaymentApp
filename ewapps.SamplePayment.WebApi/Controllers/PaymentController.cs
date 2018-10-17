using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ewApps.SamplePayment.DTO;
using ewApps.SampleProject.DataService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ewapps.SamplePayment.WebApi.Controllers
{
  [Produces("application/json")]
  [Route("api/payment")]
  public class PaymentController : Controller
  {
    PaymentDataService _paymentDS;
    public PaymentController(PaymentDataService dataService)
    {
      _paymentDS = dataService;
    }
    [HttpGet("{id}")]
    [Route("api/payment")]
    public async Task<IActionResult> Get(string id)
    {
      PaymentDTO paymentDto = await _paymentDS.Get(id);
      return Ok(paymentDto);
    }
  }
}