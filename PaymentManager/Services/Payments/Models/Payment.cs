namespace PaymentsDemo.Services.Payments.Models
{
  public class Payment
  {
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string BillingAddress { get; init; }
    public string BillingCity { get; init; }
    public string BillingState { get; set; }
    public string BillingZip { get; init; }
    public decimal Amount { get; init; }
    public string CardNumber { get; init; }
    public string Cvv { get; init; }
    public string Expiration { get; init; }

  }
}
