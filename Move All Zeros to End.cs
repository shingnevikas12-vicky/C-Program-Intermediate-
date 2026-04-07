using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = {0,1,0,3,12};

        var result = arr.Where(x=>x!=0)
                        .Concat(arr.Where(x=>x==0));

        Console.WriteLine(string.Join(",", result));
    }
}