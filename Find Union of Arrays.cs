using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] a={1,2,3};
        int[] b={3,4,5};

        var union=a.Union(b);
        Console.WriteLine(string.Join(",",union));
    }
}