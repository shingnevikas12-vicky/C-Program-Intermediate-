using System;

class Program
{
    static void Main()
    {
        int[] arr={1,3,20,4,1};

        for(int i=1;i<arr.Length-1;i++)
            if(arr[i]>arr[i-1] && arr[i]>arr[i+1])
                Console.WriteLine(arr[i]);
    }
}