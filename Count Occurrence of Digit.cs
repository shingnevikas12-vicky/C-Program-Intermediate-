using System;

class Program
{
    static void Main()
    {
        int num=122333;
        int digit=3,count=0;

        while(num>0)
        {
            if(num%10==digit) count++;
            num/=10;
        }
        Console.WriteLine(count);
    }
}