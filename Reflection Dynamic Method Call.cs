using System;
using System.Reflection;

class Demo
{
    public void Show() => Console.WriteLine("Hello");
}

class Program
{
    static void Main()
    {
        var obj = new Demo();
        var method = obj.GetType().GetMethod("Show");
        method.Invoke(obj, null);
    }
}