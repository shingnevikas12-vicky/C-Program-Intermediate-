using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static Queue<int> queue = new Queue<int>();

    static void Producer()
    {
        for (int i = 1; i <= 5; i++)
        {
            lock (queue)
            {
                queue.Enqueue(i);
                Console.WriteLine("Produced: " + i);
            }
            Thread.Sleep(500);
        }
    }

    static void Consumer()
    {
        while (true)
        {
            lock (queue)
            {
                if (queue.Count > 0)
                    Console.WriteLine("Consumed: " + queue.Dequeue());
            }
        }
    }

    static void Main()
    {
        new Thread(Producer).Start();
        new Thread(Consumer).Start();
    }
}