using System;

class Program
{
    static void Main()
    {
        string str="hello";
        HashSet<char> seen=new();

        foreach(char c in str)
        {
            if(!seen.Add(c))
                Console.Write("*");
            else
                Console.Write(c);
        }
    }
}