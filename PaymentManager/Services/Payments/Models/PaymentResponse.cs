namespace PaymentsDemo.Services.Payments.Models
{
  public class PaymentResponse
  {
    public bool Success { get; init; }
    public string TransactionId { get; set; }
    public string Code { get; set; }
    public string Message { get; set; }
    public string Description { get; set; }

  }
}
