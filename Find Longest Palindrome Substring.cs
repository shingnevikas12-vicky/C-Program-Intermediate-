using System;

class Program
{
    static void Main()
    {
        string str="babad";
        string longest="";

        for(int i=0;i<str.Length;i++)
        {
            for(int j=i;j<str.Length;j++)
            {
                string sub=str.Substring(i,j-i+1);
                string rev=new string(sub.Reverse().ToArray());

                if(sub==rev && sub.Length>longest.Length)
                    longest=sub;
            }
        }
        Console.WriteLine(longest);
    }
}