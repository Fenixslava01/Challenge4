using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matrix;

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

            var C = new MatrixController(x, y);
            int [,] matrixA = C.CreateMatrix();
            C.FillMatrix(matrixA);
            C.ShowMatrix(matrixA);
            C.ShowSummAndExit(matrixA);
            int[,] matrixB = C.CreateMatrix();
            C.FillMatrix(matrixB);
            C.ShowMatrix(matrixB);
            C.ShowSummAndExit(matrixB);
            int[,] summaryMatrix = C.CreateMatrix();
            C.SummMatrix(matrixA, matrixB, summaryMatrix);
            C.ShowMatrix(summaryMatrix);
            C.ShowSummAndExit(summaryMatrix);
        }
    }
}
