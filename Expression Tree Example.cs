using System;
using System.Linq.Expressions;

class Program
{
    static void Main()
    {
        Expression<Func<int, int>> expr = x => x * x;
        var func = expr.Compile();
        Console.WriteLine(func(5));
    }
}