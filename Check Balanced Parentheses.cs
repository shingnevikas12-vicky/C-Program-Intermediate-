using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string str = "{[()]}";
        Stack<char> st = new();

        foreach(char c in str)
        {
            if("({[".Contains(c)) st.Push(c);
            else
            {
                if(st.Count == 0) { Console.WriteLine("Not Balanced"); return; }
                st.Pop();
            }
        }
        Console.WriteLine("Balanced");
    }
}