using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var cts = new CancellationTokenSource();

        var task = Task.Run(() =>
        {
            while (!cts.Token.IsCancellationRequested)
                Console.WriteLine("Running...");
        });

        await Task.Delay(1000);
        cts.Cancel();
    }
}