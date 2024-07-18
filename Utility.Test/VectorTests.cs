using System.Numerics;
using NUnit.Framework;
namespace Utility.Test;
public class VectorTests
{

    [Test]
    public void Vector3UpPointsUpwards()
    {
        // given
        Vector3 up = Vector3.Up;
        
        // then
        Assert.That(up.y, Is.EqualTo(1));
    }

    [Test]
    public void Vector3Add()
    {
        // given
        Vector3 a = new(0, 3, 0);
        Vector3 b = new(2, 1, 0);
        
        // when
        var result = a + b;
        
        // then
        Assert.That(result, Is.EqualTo(new Vector3(2, 4, 0)));
    }
    
    [Test]
    public void Vector3MagnitudeIsCorrect()
    {
        // given
        Vector3 up = Vector3.Up;
        
        // when
        float mag = up.Magnitude;
        
        // then
        Assert.That(mag, Is.EqualTo(1));
    }
}