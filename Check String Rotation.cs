using System;

class Program
{
    static void Main()
    {
        string s1 = "abcde";
        string s2 = "cdeab";

        Console.WriteLine((s1 + s1).Contains(s2));
    }
}