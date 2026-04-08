using System;

class Program
{
    static void Main()
    {
        string str="abc";

        for(int i=0;i<str.Length;i++)
            for(int j=1;j<=str.Length-i;j++)
                Console.WriteLine(str.Substring(i,j));
    }
}