using System;
using System.Drawing;
using Learning05;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning06 World!");
        Square square1 = new Square("Orange",2.4);
        Console.WriteLine(square1.GetColor());
        Console.WriteLine(square1.GetArea());
        Rect rectangle1 = new Rect("Blue",2,5);
        Console.WriteLine(rectangle1.GetColor());
        Console.WriteLine(rectangle1.GetArea());
        Circle circle1 = new Circle("Red",2.4);
        Console.WriteLine(circle1.GetColor());
        Console.WriteLine(circle1.GetArea());        
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);
        int count = 0;
        while (count < shapes.Count)
        {
            Console.WriteLine(shapes[count].GetColor());
            Console.WriteLine(shapes[count].GetArea());
            count++;
        }
    }
}