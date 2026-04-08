using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string str="hello world";
        var result=CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);

        Console.WriteLine(result);
    }
}