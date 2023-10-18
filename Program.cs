using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcurrentPriorityQueue;


namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int> { 1, 2, 2, 2, 3, 4, 4, 5, 5, 5, 5, 6, 7, 0 };
            int targetSum =5;

            Dictionary<int, int> priority = new Dictionary<int, int>();

            foreach (var num in ints)
            {
                if (priority.ContainsKey(num))
                {
                    priority[num]++;
                }
                else
                {
                    priority.Add(num, 1);
                }
                Console.WriteLine(num);
            }

            ConcurrentPriorityQueue<int, int> priorityQueue = new ConcurrentPriorityQueue<int, int>();

            foreach (var pair in priority)
            {
                priorityQueue.Enqueue(pair.Key, -pair.Value);
            }

            while (priorityQueue.Count > 0)
            {
                int num1 = priorityQueue.Dequeue();
                if (priorityQueue.Count >= 2)
                {
                    int num2 = priorityQueue.Dequeue();
                    int num3 = targetSum - num1 - num2;
                    if (priority.ContainsKey(num3) && priority[num3] > 0)
                    {
                        Console.WriteLine($"Найдены числа: {num1}, {num2}, {num3}");
                        return;
                    }
                    priorityQueue.Enqueue(num2, -priority[num2]);
                }
                priorityQueue.Enqueue(num1, -priority[num1]);
            }

            Console.WriteLine("Тройка чисел с заданной суммой не найдена.");
        }
    }
}
