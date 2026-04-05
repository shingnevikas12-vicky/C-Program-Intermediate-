using System;
using System.Dynamic;

class Program
{
    static void Main()
    {
        dynamic obj = new ExpandoObject();
        obj.Name = "Rahul";

        Console.WriteLine(obj.Name);
    }
}