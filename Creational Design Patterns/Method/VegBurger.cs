namespace FactoryMethod
{
    internal class VegBurger : IBurger
    {
        public void prepare()
        {
            Console.WriteLine("Preparing Veg Burger...");
        }
    }
}