using System;

class Program
{
    static void Main()
    {
        string str = "C sharp is good";
        var words = str.Split(' ');
        Array.Reverse(words);

        Console.WriteLine(string.Join(" ", words));
    }
}