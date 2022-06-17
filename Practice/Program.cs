namespace Practice
{
    // public class C
    // {
    // public static int num=10;
    //  public C()
    //  {
    //     num+=10;
    //     System.Console.WriteLine($"Most Base Constructor {num}");
        
    //  }
    //   static C()
    //  {
    //     num+=10;
    //     System.Console.WriteLine($"Most static constructor {num}");
        
    //  }
    // }
    // public class A: C
    // {
   
    //  public A()
    //  {
    //     num+=10;
    //     System.Console.WriteLine($"next Parent Constructor {num}");
        
    //  }
    //   static A()
    //  {
    //     num+=10;
    //     System.Console.WriteLine($"next Parent static constructor {num}");
        
    //  }
    // }
    // public class B:A
    // {
    //     static B()
    //     {
    //         num+=9;
    //         Console.WriteLine($"Child  static Constructor {num}");
    //     }
    //     public B()
    //     {
    //         num+=9;
    //         Console.WriteLine($"Child Constructor {num}");
            
    //     }
    // }

    public class A{
        public int num=10;
        public virtual void show()
        {
            System.Console.WriteLine("HELLO a");
        }
    }
    public class C:A{
       
        public override void show()
        {
            System.Console.WriteLine("HELLO C");
        }
    }
    public class B{
       
       public string val="90";
       public void change()
       {
            val="20";
       }
        public void show()
        {
            System.Console.WriteLine("HELLO B");
        }
    }

    public class MainProgram
    {
        public static void Main(string[] args)
        {
           B obj=new B();
           obj.val="40";
           obj.change();
           System.Console.WriteLine(obj.val);
           B obj2=obj;
           obj2.val="30";
           System.Console.WriteLine(obj2.val);

        }
    }
}