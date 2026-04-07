using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string str = "C sharp programming language";
        var word = str.Split(' ').OrderByDescending(x=>x.Length).First();

        Console.WriteLine(word);
    }
}