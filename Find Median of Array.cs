using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr={1,3,2,4};
        var sorted=arr.OrderBy(x=>x).ToArray();

        double median=(sorted[1]+sorted[2])/2.0;
        Console.WriteLine(median);
    }
}