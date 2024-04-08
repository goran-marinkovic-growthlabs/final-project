using PaymentsDemo.Services.Payments.Models;

namespace PaymentsDemo.Services.Payments.Interfaces
{
  public interface IPayment
  {
    PaymentResponse ProcessPayment(Payment payment);
  }
}
