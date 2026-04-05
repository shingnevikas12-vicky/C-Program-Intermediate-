using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

class SimpleScheduler
{
    private BlockingCollection<Action> queue = new();

    public SimpleScheduler()
    {
        Task.Run(() =>
        {
            foreach (var task in queue.GetConsumingEnumerable())
                task();
        });
    }

    public void Schedule(Action action)
    {
        queue.Add(action);
    }
}

class Program
{
    static void Main()
    {
        var scheduler = new SimpleScheduler();

        scheduler.Schedule(() => Console.WriteLine("Task 1"));
        scheduler.Schedule(() => Console.WriteLine("Task 2"));
    }
}