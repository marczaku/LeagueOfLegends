namespace Utility.Test;

public class FibonacciTests
{

    [Test]
    public void WorksForAnArbitraryValue()
    {
        // given
        int n = 6;
        
        // when
        int result = Fibonacci.Recursive(n);
        
        // then
        Assert.That(result, Is.EqualTo(8));
    }
}