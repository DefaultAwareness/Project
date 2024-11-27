using System;

namespace Lastname_Project
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }

        public Payment(int paymentId, decimal amount, string paymentMethod)
        {
            PaymentId = paymentId;
            Amount = amount;
            PaymentMethod = paymentMethod;
        }

        public void ProcessPayment()
        {
            Console.WriteLine($"Processing {PaymentMethod} payment of {Amount:C}.");
        }

        public override string ToString()
        {
            return $"Payment ID: {PaymentId}, Amount: {Amount:C}, Method: {PaymentMethod}";
        }
    }
}
