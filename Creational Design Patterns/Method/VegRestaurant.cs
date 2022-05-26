namespace FactoryMethod
{
    public class VegRestaurant : Restaurant{
        public override IBurger createBurger()
        {
            Console.WriteLine("Creating new Veg Burger...");
            return new VegBurger();
        }

    }
}