using System;
using EeeeGeometry.Figures;
using EeeeGeometry.Tools;
using NUnit.Framework;

namespace EeeeGeometry.Tests;

public class TriangleTests
{
    [Test]
    public void CreateInvalidTriangle_ThrowException()
    {
        Assert.Catch<EeeeGeometryException>(() =>
        {
            var invalidTriangle = new Triangle(1000, 1, 2);
        });
    }
    
    [Test]
    public void CreateRectangleTriangle_CheckIt()
    {
        var rectangleTriangle = new Triangle(3, 4, 5);
        
        Assert.AreEqual(true, rectangleTriangle.IsRectangular(1e-6));
    }
    
    [Test]
    public void CreateNonRectangleTriangle_CheckIt()
    {
        var nonRectangleTriangle = new Triangle(3, 3, 3);
        
        Assert.AreEqual(false, nonRectangleTriangle.IsRectangular(1e-6));
    }
    
    [Test]
    public void CreateTriangle_CheckSquare()
    {
        var triangle = new Triangle(3, 4, 5);
        
        const double expectedSquare = 6.0;
        const double epsilon = 1e-6;
        

        Assert.AreEqual(true, Math.Abs(triangle.Square() - expectedSquare) < epsilon);
    }
}