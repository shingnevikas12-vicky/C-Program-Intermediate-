using System;

class Program
{
    static void Main()
    {
        int[] arr = {1,2,3,4,5};
        int k = 2;

        for (int i = 0; i < k; i++)
        {
            int temp = arr[0];
            for (int j = 0; j < arr.Length - 1; j++)
                arr[j] = arr[j + 1];

            arr[^1] = temp;
        }

        Console.WriteLine(string.Join(",", arr));
    }
}