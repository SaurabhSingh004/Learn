//STATIC POLYMORPHISM

// using System;
// namespace FunctionOverloadingDemo
// {
//   class Example
//   {
//      void printData(int rno)
//      {
//         Console.WriteLine("Roll number: {0}", rno );
//      }
//      void printData(int rno, string name)
//      {
//         Console.WriteLine("Roll number: {0}", rno );
//         Console.WriteLine("Name: {0}", name );
//      }
//      void printData(int rno, string name, double marks)
//      {
//         Console.WriteLine("Roll number: {0}", rno );
//         Console.WriteLine("Name: {0}", name );
//         Console.WriteLine("Marks: {0}", marks );
//      }
//      static void Main(string[] args)
//      {
//         Example obj = new Example();
//         obj.printData(1);
//         obj.printData(2, "John");
//         obj.printData(3, "Sally", 78.5);        
//       }
//   }
// }

//RUNTIME POLYMORPHISM

using System;
namespace AbstractionDemo
{
   class Shape
   {
     public virtual double area()
     {
         return 0;
     }
   }
   class Circle: Shape
   {
     private double radius;
     public Circle( double r)
     {
        radius = r;
     }
     public override double area ()
     {
        return (3.14*radius*radius);
     }
   }
   class Square: Shape
   {
     private double side;
     public Square( double s)
     {
        side = s;
     }
     public override double area ()
     {
        return (side*side);
     }
   }
    class Triangle: Shape
   {
     private double tbase;
     private double theight;
     public Triangle( double b, double h)
     {
        tbase = b;
        theight = h;
     }
     public override double area ()
     {
        return (0.5*tbase*theight);
     }
  }
   class Test
   {
     static void Main(string[] args)
     {
        Circle c = new Circle(2.5);
        Console.WriteLine("Area of Circle = {0}", c.area());
        Square s = new Square(5.5);
        Console.WriteLine("Area of Square = {0}", s.area());
        Triangle t = new Triangle(3.0, 5.0);
        Console.WriteLine("Area of Triangle = {0}", t.area());
     }
   }
}