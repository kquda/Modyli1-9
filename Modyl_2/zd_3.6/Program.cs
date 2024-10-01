using System;

abstract class Shape
{
    public abstract double Area();
    public abstract double Perimeter();
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        return Math.PI * radius * radius;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * radius;
    }
}

class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double Area()
    {
        return width * height;
    }

    public override double Perimeter()
    {
        return 2 * (width + height);
    }
}

class Triangle : Shape
{
    private double sideA;
    private double sideB;
    private double sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    public override double Area()
    {
        double s = Perimeter() / 2; // Полупериметр
        return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
    }

    public override double Perimeter()
    {
        return sideA + sideB + sideC;
    }
}

class Program
{
    static void Main()
    {
        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 6);
        Shape triangle = new Triangle(3, 4, 5);

        Console.WriteLine($"Площадь круга: {circle.Area()}, Периметр: {circle.Perimeter()}");
        Console.WriteLine($"Площадь прямоугольника: {rectangle.Area()}, Периметр: {rectangle.Perimeter()}");
        Console.WriteLine($"Площадь треугольника: {triangle.Area()}, Периметр: {triangle.Perimeter()}");
    }
}
