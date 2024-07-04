namespace Utility;

public static class Fibonacci
{
    public static int Recursive(int n)
    {
        if (n < 1) return n;
        
        return Recursive(n - 2) + Recursive(n - 1);
    }
}