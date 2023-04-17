var shoppingCart = new ShoppingCart(new PayPalPayment());
shoppingCart.Pay(100);

shoppingCart.PaymentStrategy = new CreditCardPayment();
shoppingCart.Pay(200);


