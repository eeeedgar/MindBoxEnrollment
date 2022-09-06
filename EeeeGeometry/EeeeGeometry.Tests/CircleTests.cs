using System;
using EeeeGeometry.Figures;
using EeeeGeometry.Tools;
using NUnit.Framework;

namespace EeeeGeometry.Tests;

public class CircleTests
{
    [Test]
    public void CreateInvalidCircle_ThrowException()
    {
        Assert.Catch<EeeeGeometryException>(() =>
        {
            var invalidCircle = new Circle(-1);
        });
    }
    
    [Test]
    public void CreateCircle_CheckSquare()
    {
        const double radius = 10;
        const double expectedSquare = 314.159265359;
        const double epsilon = 1e-6;
                                      
        var circle = new Circle(radius);
        
        Assert.AreEqual(true, Math.Abs(circle.Square() - expectedSquare) < epsilon);
    }
}