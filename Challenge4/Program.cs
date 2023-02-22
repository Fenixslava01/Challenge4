using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов: ");
            int y = int.Parse(Console.ReadLine());
            int summMatrix = 0;
            int[,] matrix = new int[x,y];
            Random rand = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matrix[i, j] = rand.Next(0,50);
                    Console.Write($"{matrix[i, j]} ");
                    summMatrix += matrix[i, j];
                }
            }
            Console.WriteLine($"summMatrix = {summMatrix}");
            Console.WriteLine("Нажмите любую кнопку для выхода...");
            Console.ReadKey();
        }
    }
}
