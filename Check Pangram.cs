using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string str = "abcdefghijklmnopqrstuvwxyz";
        Console.WriteLine(str.ToLower().Distinct().Count()==26);
    }
}