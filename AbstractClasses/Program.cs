using System;

abstract class Shape {
    public abstract double GetArea();
}

class Circle : Shape {
    private double _radius;
    public Circle(double r) => _radius = r;
    public override double GetArea() => Math.PI * _radius * _radius;
}

class Rectangle : Shape {
    private double _width, _height;
    public Rectangle(double w, double h) => (_width, _height) = (w, h);
    public override double GetArea() => _width * _height;
}

class Program {
    static void Main() {
        Circle circle = new Circle(5);
        Rectangle rect = new Rectangle(4, 6);

        Console.WriteLine($"Circle area: {circle.GetArea():F2}"); // 78.54
        Console.WriteLine($"Rectangle area: {rect.GetArea()}");   // 24
    }
}