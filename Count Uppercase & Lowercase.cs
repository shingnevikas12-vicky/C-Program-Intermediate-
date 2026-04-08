using System;

class Program
{
    static void Main()
    {
        string str="Hello World";
        int upper=0,lower=0;

        foreach(char c in str)
        {
            if(char.IsUpper(c)) upper++;
            if(char.IsLower(c)) lower++;
        }

        Console.WriteLine($"{upper} {lower}");
    }
}