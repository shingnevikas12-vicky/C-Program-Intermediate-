using System;

class Program
{
    static void Main()
    {
        int[] arr = {1,2,3,7,5};
        int sum = 12;

        for(int i=0;i<arr.Length;i++)
        {
            int curr=0;
            for(int j=i;j<arr.Length;j++)
            {
                curr+=arr[j];
                if(curr==sum)
                    Console.WriteLine($"{i}-{j}");
            }
        }
    }
}