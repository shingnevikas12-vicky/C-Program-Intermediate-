using System;

class Program
{
    static void Main()
    {
        string str="12345";
        bool flag=true;

        foreach(char c in str)
            if(!char.IsDigit(c)) flag=false;

        Console.WriteLine(flag);
    }
}