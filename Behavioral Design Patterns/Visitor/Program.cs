namespace VisitorDemo
{
    public interface IVisitor
    {
        void Visit(MyClass myclasselement);
    }
    class VisitorA :IVisitor
    {
        
        public void Visit(MyClass myclasselement)
        {
            System.Console.WriteLine("Visitor A is trying to make a change");
            myclasselement.X=100;
            System.Console.WriteLine("Exiting from Visitor");
        }
    }
    public interface IOriginalInterface
    {
        void Accept(IVisitor visitor);
    }

    public class MyClass : IOriginalInterface
    {
        int x=10;
        public int X
        {
            get{return x;}
            set{x=value;}
        }
        
        public void Accept(IVisitor visitor)
        {
            
            System.Console.WriteLine($"Initial value of x : {X}");
            visitor.Visit(this);
            System.Console.WriteLine($"value of x now : {X}");
                        
        }
    }
    public class MainApp
    {
        public static void Main(String[] args)
        {
            System.Console.WriteLine("** VISITOR PATTERN DEMO **");
            IVisitor visitor=new VisitorA();
            MyClass elem=new MyClass();
            elem.Accept(visitor);

        }

    }
}