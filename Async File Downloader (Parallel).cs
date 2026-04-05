using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var client = new HttpClient();

        var t1 = client.GetStringAsync("https://example.com");
        var t2 = client.GetStringAsync("https://example.org");

        await Task.WhenAll(t1, t2);

        Console.WriteLine("Downloaded both files");
    }
}