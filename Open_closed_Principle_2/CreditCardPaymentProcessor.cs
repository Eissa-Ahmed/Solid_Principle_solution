public class CreditCardPaymentProcessor : IPaymentMethod
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing credit card payment");
    }
}


