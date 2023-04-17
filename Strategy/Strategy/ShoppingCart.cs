public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine("Paid {0} using Credit card", amount);
    }
}

public class PayPalPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using Paypal");
    }
}

public class QiwiPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using Qiwi");
    }
}

class ShoppingCart
{
    public IPaymentStrategy PaymentStrategy { get; set; }

    public ShoppingCart(IPaymentStrategy paymentStrategy)
    {
        PaymentStrategy = paymentStrategy;
    }

    public void Pay(double amount)
    {
        PaymentStrategy.Pay(amount);
    }
}