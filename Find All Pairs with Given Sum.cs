using System;

class Program
{
    static void Main()
    {
        int[] arr = {1,2,3,4,5};
        int sum = 5;

        for(int i=0;i<arr.Length;i++)
            for(int j=i+1;j<arr.Length;j++)
                if(arr[i]+arr[j]==sum)
                    Console.WriteLine($"{arr[i]}, {arr[j]}");
    }
}