using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PaymentsDemo.Services.Payments.Interfaces;
using PaymentsDemo.Services.Payments.Models;

namespace PaymentsDemo.Pages
{
  public class IndexModel : PageModel
  {
    [BindProperty]
    public Payment Payment { get; set; }

    [BindProperty]
    public PaymentResponse PaymentResponse { get; set; }

    public IPayment PaymentService { get; }
    public IndexModel(IPayment service)
    {
      PaymentService = service;
    }
    public void OnGet()
    {
      Payment = new Payment()
      {
        FirstName = "John",
        LastName = "Cokos",
        BillingAddress = "123 Main St",
        BillingState = "WA",
        BillingCity = "Lynnwood",
        BillingZip = "98036",
        Amount = 10.35m,
        CardNumber = "4111111111111111",
        Expiration = "1022",
        Cvv = "555",
      };
    }

    public void OnPost()
    {
      PaymentResponse = PaymentService.ProcessPayment(Payment);
    }

  }
}
