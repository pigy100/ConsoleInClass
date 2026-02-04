using System;

namespace SOLID
{
    public class BaseOrder
    {
        public virtual void PaymentProcess()
        {
            Console.WriteLine("null");
        }
    }
    public class CreditPayment : BaseOrder 
    {
        public override void PaymentProcess() 
        {
            Console.WriteLine("Credit");
        }
    }
    public class CashPayment : BaseOrder 
    {
        public override void PaymentProcess() 
        {
            Console.WriteLine("Cash");
        }
    }
    public class PhonePayment : BaseOrder 
    {
        public override void PaymentProcess()
        {
            Console.WriteLine("Phone");
        }
    }
    public class CryptoPayment : BaseOrder
    {
        public override void PaymentProcess()
        {
            Console.WriteLine("Crypto");
        }
    }
    public class Order : BaseOrder 
    {
        private BaseOrder _processor;
        public Order (BaseOrder processor)
        {
            _processor = processor;
        }
        public void PayOrder()
        {
            _processor.PaymentProcess();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //SRP
            //OCP
            Order order = new Order (new CashPayment());
            order.PayOrder();
            //
        }
    }
}
