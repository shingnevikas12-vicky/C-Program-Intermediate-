using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string str = "swiss";
        var result = str.GroupBy(c => c)
                        .FirstOrDefault(g => g.Count() == 1);

        Console.WriteLine(result?.Key);
    }
}