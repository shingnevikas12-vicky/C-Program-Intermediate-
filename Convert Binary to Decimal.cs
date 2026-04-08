using System;

class Program
{
    static void Main()
    {
        string bin="1010";
        int dec=Convert.ToInt32(bin,2);

        Console.WriteLine(dec);
    }
}