using System;

abstract class Figure
{
    public abstract double CalculatingSquare();
}

class Circle : Figure
{
    public double Radius { get; set; }

    public Circle (double radius)
    {
        Radius = radius;
    }

    public override double CalculatingSquare()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Figure
{
    public double Lenght { get; set; }
    public double Widht { get; set; }

    public Rectangle (double lenght, double widht)
    {
        Lenght = lenght;
        Widht = widht;
    }

    public override double CalculatingSquare()
    {
        return Lenght * Widht;
    }
}

class Triangle : Figure
{
    public double BaseLength { get; set; }
    public double Height { get; set; }

    public Triangle(double baseLength, double height)
    {
        BaseLength = baseLength;
        Height = height;
    }

    public override double CalculatingSquare()
    {
        return (BaseLength * Height) / 2;
    }
}

// Делегат для динамического вызова метода вычисления площади
delegate double AreaDelegate();

class Program
{
    static void Main()
    {
        // Создание объектов для различных фигур
        Figure circle = new Circle(8);
        Figure rectangle = new Rectangle(2, 7);
        Figure triangle = new Triangle(5, 8);

        // Создание делегатов для каждого метода вычисления площади
        AreaDelegate circleDelegate = new AreaDelegate(circle.CalculatingSquare);
        AreaDelegate rectangleDelegate = new AreaDelegate(rectangle.CalculatingSquare);
        AreaDelegate triangleDelegate = new AreaDelegate(triangle.CalculatingSquare);

        // Динамический вызов методов через делегаты
        Console.WriteLine($"Площадь круга: {circleDelegate()}");
        Console.WriteLine($"Площадь прямоугольника: {rectangleDelegate()}");
        Console.WriteLine($"Площадь треугольника: {triangleDelegate()}");
    }
}