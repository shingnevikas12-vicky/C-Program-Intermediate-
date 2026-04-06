using System;
using System.Collections.Generic;

class Student
{
    public string Name;
    public int Age;
}

class Program
{
    static void Main()
    {
        var list = new List<Student>
        {
            new Student { Name="A", Age=22 },
            new Student { Name="B", Age=20 }
        };

        list.Sort((x,y)=>x.Age.CompareTo(y.Age));

        foreach(var s in list)
            Console.WriteLine(s.Name);
    }
}