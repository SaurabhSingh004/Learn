using System;
namespace InheritanceDemo
{
    class A
    {
        public int a;
        public A()
        {
           a = 5;
        }
    }
    class B: A
    {
        public int b;
        public B()
        {
            b = 20;
        }
        public int getSum()
        {
            return a + b;
        }
    }
   class Test
   {
     static void Main(string[] args)
     {
         B obj = new B();
        Console.WriteLine("Sum = {0}", obj.getSum());
     }
   }
}