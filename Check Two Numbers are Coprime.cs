using System;

class Program
{
    static int GCD(int a,int b)
    {
        while(b!=0)
        {
            int t=b;
            b=a%b;
            a=t;
        }
        return a;
    }

    static void Main()
    {
        Console.WriteLine(GCD(8,15)==1);
    }
}