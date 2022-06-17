namespace Strategy
{
    public class PaymentByCreditCard : PaymentStrategy {

    private CreditCard card;

    public void collectPaymentDetails() {
        // Pop-up to collect card details...
        card = new CreditCard("cardNumber", "expiryDate", "cvv");
        Console.WriteLine("Collecting Card Details...");
    }

    public bool validatePaymentDetails() {
        // Validate credit card...
        Console.WriteLine("Validating Card Info: " + card);
        return true;
    }

    public void pay(int amount) {
        Console.WriteLine("Paying " + amount + " using Credit Card");
        card.setAmount(card.getAmount() - amount);
    }

}
}