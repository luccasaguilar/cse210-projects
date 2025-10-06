using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("red_square", 10));
        shapes.Add(new Retangle("blue_retangle", 10, 20));
        shapes.Add(new Circle("brown_circle", 10));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor()); 
            Console.WriteLine(shape.GetArea());
        }

        // var square = new Square("red", 10);
        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());

        // var retangle = new Retangle("blue", 10, 20);
        // Console.WriteLine(retangle.GetColor());
        // Console.WriteLine(retangle.GetArea());

        // var circle = new Circle("brown", 10);
        // Console.WriteLine(circle.GetColor());
        // Console.WriteLine(circle.GetArea());

    }
}