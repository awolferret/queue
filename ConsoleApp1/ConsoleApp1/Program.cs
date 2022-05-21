using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> money = new Queue<int>();
            money.Enqueue(100);
            money.Enqueue(150);
            money.Enqueue(200);
            int bank = 0;
            int count = money.Count;

            for (int i = 0; i < count; i++)
            {
                  bank += money.Dequeue();
                  Console.WriteLine($"Денег на счету: {bank}");
                  Console.ReadKey();
                  Console.Clear();
            }
        }
    }
}