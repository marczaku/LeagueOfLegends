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