using EeeeGeometry.Tools;

namespace EeeeGeometry.Figures;

public class Triangle : IFigure
{
    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new EeeeGeometryException("Side lengths must be positive values.");
        }

        if (a >= b + c || b >= a + c || c >= a + b)
        {
            throw new EeeeGeometryException("Rules for the existence of a triangle:" +
                                            " the length of each side must be less than the sum of the other two.");
        }
        
        A = a;
        B = b;
        C = c;
    }

    public double A { get; }
    public double B { get; }
    public double C { get; }


    public double Square()
    {
        var p = (A + B + C) / 2;

        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));

    }

    public bool IsRectangular(double epsilon)
    {
        double cat1, cat2, hyp;

        if (A >= B && A >= C)
        {
            hyp = A;
            cat1 = B;
            cat2 = C;
        }
        else if (B >= A && B >= C)
        {
            hyp = B;
            cat1 = A;
            cat2 = C;
        }
        else
        {
            hyp = C;
            cat1 = A;
            cat2 = B;
        }

        return Math.Abs(Math.Pow(hyp, 2) - (Math.Pow(cat1, 2) + Math.Pow(cat2, 2))) <= epsilon;
    }
}