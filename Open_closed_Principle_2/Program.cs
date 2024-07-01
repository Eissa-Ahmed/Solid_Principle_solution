using Open_Closed_Principle_2;

namespace Open_closed_Principle_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCardPaymentProcessor creditCardPaymentProcessor = new CreditCardPaymentProcessor();
            DebitCardPaymentProcessor debitCardPaymentProcessor = new DebitCardPaymentProcessor();
            SkrillPaymentProcessor skrillPaymentProcessor = new SkrillPaymentProcessor();
            PaymentProcessor paymentProcessor = new PaymentProcessor(skrillPaymentProcessor);
            paymentProcessor.ProcessPayment();
        }
    }
}
