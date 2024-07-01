public class DebitCardPaymentProcessor : IPaymentMethod
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing debit card payment");
    }
}

