using EeeeGeometry.Tools;

namespace EeeeGeometry.Figures;

public class Circle : IFigure
{
    public Circle(double radius)
    {
        if (radius < 0)
            throw new EeeeGeometryException("Radius length must be a positive value.");
                
        Radius = radius;
    }

    public double Radius { get; }

    public double Square()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}