using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    internal class Program
    {
        static void FindExits(int startI, int startJ, int[,] l, List<Tuple<int, int>> exitCoordinates)
        {
            if (startI < 0 || startI >= l.GetLength(0) || startJ < 0 || startJ >= l.GetLength(1))
            {
                return;
            }

            if (l[startI, startJ] == 1)
            {
                return;
            }

            if (l[startI, startJ] == 2)
            {
                exitCoordinates.Add(new Tuple<int, int>(startI, startJ));
            }

            l[startI, startJ] = 1;

            FindExits(startI - 1, startJ, l, exitCoordinates); // Вверх
            FindExits(startI + 1, startJ, l, exitCoordinates); // Вниз
            FindExits(startI, startJ - 1, l, exitCoordinates); // Влево
            FindExits(startI, startJ + 1, l, exitCoordinates); // Вправо
        }

        static void Main(string[] args)
        {
            int[,] labyrinth1 = new int[,]
            {
            {1, 1, 1, 1, 1, 1, 1 },
            {1, 0, 0, 0, 0, 0, 1 },
            {1, 0, 1, 1, 1, 0, 1 },
            {0, 0, 0, 0, 1, 0, 2},
            {1, 1, 0, 0, 1, 1, 1 },
            {1, 1, 1, 0, 1, 1, 1 },
            {1, 1, 1, 0, 1, 1, 1 }
            };

            List<Tuple<int, int>> exitCoordinates = new List<Tuple<int, int>>();

            FindExits(3, 0, labyrinth1, exitCoordinates);

            if (exitCoordinates.Count > 0)
            {
                Console.WriteLine($"Найдено {exitCoordinates.Count} выходов");
                foreach (var exit in exitCoordinates)
                {
                    Console.WriteLine($"Координаты выхода: ({exit.Item1}, {exit.Item2})");
                }
            }
            else
            {
                Console.WriteLine("Выходы не найдены.");
            }

            Console.ReadKey();
        }
    }
}
