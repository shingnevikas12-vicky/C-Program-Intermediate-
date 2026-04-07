using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string str = "hello world hello";
        var dup = str.Split(' ')
                     .GroupBy(x=>x)
                     .Where(g=>g.Count()>1)
                     .Select(g=>g.Key);

        Console.WriteLine(string.Join(",", dup));
    }
}