using System;

class Program
{
    static void Main()
    {
        int[] arr={1,2,3,4,5};
        int sum=0;

        for(int i=0;i<arr.Length;i+=2)
            sum+=arr[i];

        Console.WriteLine(sum);
    }
}