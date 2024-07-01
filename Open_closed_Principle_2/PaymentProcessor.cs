namespace Open_Closed_Principle_2
{
    public class PaymentProcessor
    {
        /*public void ProcessPayment(string paymentType)
        {
            if (paymentType == "CreditCard")
            {
                Console.WriteLine("Processing credit card payment");
            }
            else if (paymentType == "DebitCard")
            {
                Console.WriteLine("Processing debit card payment");
            }
            else
            {
                throw new Exception("Invalid payment type");
            }
        }*/
        private readonly IPaymentMethod _paymentMethod;
        public PaymentProcessor(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }
        public void ProcessPayment()
        {
            _paymentMethod.ProcessPayment();
        }
    }
}

