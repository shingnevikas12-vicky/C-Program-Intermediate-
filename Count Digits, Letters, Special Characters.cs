using System;

class Program
{
    static void Main()
    {
        string str="abc123@!";
        int d=0,l=0,s=0;

        foreach(char c in str)
        {
            if(char.IsDigit(c)) d++;
            else if(char.IsLetter(c)) l++;
            else s++;
        }

        Console.WriteLine($"{l},{d},{s}");
    }
}