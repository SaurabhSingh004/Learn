namespace Solid
{
public class DebitCard : IBankCard{

    public void doTransaction(long amount){
        Console.WriteLine("payment using Debit card");
    }
}
}