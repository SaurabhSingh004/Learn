namespace FactoryMethod
{
    public class BeefRestaurant : Restaurant{
        public override IBurger createBurger()
        {
            Console.WriteLine("Creating new Beef Burger...");
            return new BeefBurger();
        }

    }
}