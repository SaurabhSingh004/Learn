namespace Strategy
{
    public class PaymentByPayPal : PaymentStrategy {

    private String email;
    private String password;

    public void collectPaymentDetails() {
        // Pop-up to collect PayPal mail and password...
        email = "PayPal Mail";
        password = "PayPal Password";
        Console.WriteLine("Collecting PayPal Account Details...");
    }

    public bool validatePaymentDetails() {
        // Validate account...
        Console.WriteLine("Validating PayPal Info: {0} | {1}", email, password);
        return true;
    }

    public void pay(int amount) {
        Console.WriteLine("Paying " + amount + " using PayPal");
    }

}
}