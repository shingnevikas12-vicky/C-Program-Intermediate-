using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr={1,2,3,2,4};
        int remove=2;

        var result=arr.Where(x=>x!=remove);
        Console.WriteLine(string.Join(",",result));
    }
}