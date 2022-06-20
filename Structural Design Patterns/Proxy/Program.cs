
namespace Proxy
{ 
     interface IWorkspace
     {
        void DoSomeWork();
     }
     public class Proxy: IWorkspace
     {
        ConcreteSubject cs;

        public void DoSomeWork()
        {
            System.Console.WriteLine("Proxy Access happening ...");
            if(cs==null)
            {
                cs=new ConcreteSubject();
            }
            cs.DoSomeWork();
        }

     }
     public class ConcreteSubject: IWorkspace
     {
        public void DoSomeWork()
        {
            System.Console.WriteLine("Concrete subject access ...");
        }
     }
     public class MainApp
     {
        public static void Main()
        {
            Console.WriteLine("***Proxy Pattern Demo***\n");
            Proxy obj=new Proxy();
            obj.DoSomeWork();
        }
     }
}