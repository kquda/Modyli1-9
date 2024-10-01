﻿using System;

class Shape
{
    public virtual double Area() { return 0; }
    public virtual double Perimeter() { return 0; }
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

class Program
{
    static void Main()
    {
        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 6);

        Console.WriteLine($"Площадь круга: {circle.Area()}, Периметр: {circle.Perimeter()}");
        Console.WriteLine($"Площадь прямоугольника: {rectangle.Area()}, Периметр: {rectangle.Perimeter()}");
    }
}
