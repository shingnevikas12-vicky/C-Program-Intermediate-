using System;

class Program
{
    static void Middleware(Action next)
    {
        Console.WriteLine("Before");
        next();
        Console.WriteLine("After");
    }

    static void Main()
    {
        Middleware(() => Console.WriteLine("Core Logic"));
    }
}