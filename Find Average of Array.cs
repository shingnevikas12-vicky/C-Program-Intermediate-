using System;

class Program
{
    static void Main()
    {
        int[] arr={10,20,30};
        int sum=0;

        foreach(int i in arr) sum+=i;

        Console.WriteLine((double)sum/arr.Length);
    }
}