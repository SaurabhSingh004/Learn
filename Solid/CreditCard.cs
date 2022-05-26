namespace Solid
{
public class CreditCard : IBankCard{

    public void doTransaction(long amount){
        Console.WriteLine("payment using Credit card");
    }
}
}