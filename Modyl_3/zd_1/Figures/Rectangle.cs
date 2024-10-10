using zd_1.Figures;

public class Rectangle : IFigure
{
    public double Height { get; set; }
    public double Width { get; set; }

    public Rectangle (double height, double width)
    {
        Height = height;
        Width = width;
    }

    public double CalculateArea()
    {
        return Height * Width;
    } 

    public double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
}