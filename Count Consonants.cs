using System;

class Program
{
    static void Main()
    {
        string str="hello";
        int count=0;

        foreach(char c in str)
            if(char.IsLetter(c) && !"aeiou".Contains(c))
                count++;

        Console.WriteLine(count);
    }
}