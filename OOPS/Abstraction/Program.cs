using System;
namespace AbstractionDemo
{
   abstract class Shape
   {
     public abstract double area();
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
        double c=0.1;
        double d=0.2;
        double e=c+d;
        if(e == 0.7)
        {
           Console.WriteLine("hello");
        }
        else
        Console.WriteLine("my ");
     }
   }
}