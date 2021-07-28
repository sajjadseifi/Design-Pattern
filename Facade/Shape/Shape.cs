using System;

namespace Design_Pattern.Facade.Shape
{
    public class Circle : IShape
    {
        public void Draw() => Console.WriteLine("Rectangle:Draw()");
    }

    public class Rectangle : IShape
    {
        public void Draw() => Console.WriteLine("Rectangle:Draw()");
    }

    public class Pentagon : IShape
    {
        public void Draw() => Console.WriteLine("Pentagon:Draw()");
    }

}