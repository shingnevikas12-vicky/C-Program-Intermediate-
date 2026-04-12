using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = {5,2,8,1};
        Console.WriteLine(arr.Max() - arr.Min());
    }
}