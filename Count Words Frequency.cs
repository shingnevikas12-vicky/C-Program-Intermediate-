using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string str = "hello world hello";
        var words = str.Split(' ');
        Dictionary<string,int> dict = new();

        foreach(var w in words)
        {
            if(dict.ContainsKey(w)) dict[w]++;
            else dict[w] = 1;
        }

        foreach(var i in dict)
            Console.WriteLine(i.Key + ":" + i.Value);
    }
}