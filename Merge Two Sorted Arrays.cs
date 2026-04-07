using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] a = {1,3,5};
        int[] b = {2,4,6};

        var result = a.Concat(b).OrderBy(x=>x);
        Console.WriteLine(string.Join(",", result));
    }
}