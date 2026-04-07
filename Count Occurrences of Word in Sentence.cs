using System;

class Program
{
    static void Main()
    {
        string str = "hello hello world";
        string word = "hello";

        int count = str.Split(' ').Count(x=>x==word);
        Console.WriteLine(count);
    }
}