public class Triangle : IFigure
{
    public double SideX { get; set; }
    public double SideY { get; set; }
    public double SideZ { get; set; }


    public Triangle(double sideX, double sideY, double sideZ)
    {
        SideX = sideX;
        SideY = sideY;
        SideZ = sideZ;
    }

    public double CalculateArea()
    {
        return double s = (SideX + SideY + SideZ) / 2;
        return Math.Sqrt(s * (s - SideX) * (s - SideY) * (s - SideZ));
    }

    public double CalculatePerimeter()
    {
        return SideX + SideY + SideZ;
    }
}