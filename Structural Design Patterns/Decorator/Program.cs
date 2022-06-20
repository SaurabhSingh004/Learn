namespace DecoratorDemo
{
    abstract class IBuildHouse
    {
        public abstract void MakeHouse();
    }

    class ConcreteComponent : IBuildHouse
    {
        public override void MakeHouse()
        {
            System.Console.WriteLine("Concrete Builder .. House Build Complete ");
        }
    }

    abstract class AbstractDecorator : IBuildHouse
    {
        protected IBuildHouse cc;
        public void setComponent(IBuildHouse com)
        {
            cc=com;
        }
        public override void MakeHouse()
        {
            if(cc!=null)
            {
                cc.MakeHouse();
            }
        }
    }
    class ConcreteDecoratorEx1: AbstractDecorator
    {
        public override void MakeHouse()
            {
                base.MakeHouse();
                Console.WriteLine("***Using a decorator***");
                
                //Decorating now.
                AddFloor();
            }
            private void AddFloor()
            {
                Console.WriteLine("I am making an additional floor on top ");
            }
    }
    class ConcreteDecoratorEx2: AbstractDecorator
    {
        public override void MakeHouse()
            {
                base.MakeHouse();
                Console.WriteLine("***Using a decorator***");
                //Decorating now.
                PaintHouse();
            }
            private void PaintHouse()
            {
                Console.WriteLine("I am painting the house");
            }
    }
    public class MainApp
    {
        public static void Main(string[] arg)
        {
            Console.WriteLine("***Decorator pattern Demo***\n");
            ConcreteComponent cc = new ConcreteComponent();
           
            ConcreteDecoratorEx1 ex1=new ConcreteDecoratorEx1();
            ex1.setComponent(cc);
            ex1.MakeHouse();

            // ConcreteDecoratorEx2 ex2=new ConcreteDecoratorEx2();
            // ex2.setComponent(cc);
            // ex2.MakeHouse();
            
        }
    }
}