namespace FactoryMethod
{
    internal class BeefBurger : IBurger
    {
        public void prepare()
        {
            Console.WriteLine("Preparing Beef Burger...");
        }
    }
}