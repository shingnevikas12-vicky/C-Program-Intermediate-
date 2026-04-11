using System;

class Program
{
    static void Main()
    {
        int[,] m = {{1,2},{3,4}};
        int n = 2;

        for(int i=0;i<n;i++)
        {
            for(int j=n-1;j>=0;j--)
                Console.Write(m[j,i]+" ");
            Console.WriteLine();
        }
    }
}