using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = {5,1,3,2};
        Console.WriteLine(arr.Distinct().OrderBy(x=>x).Skip(1).First());
    }
}