using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = {1,2,4,6};
        var result = Enumerable.Range(1,6).Except(arr);

        Console.WriteLine(string.Join(",", result));
    }
}