using System;
using Matrix;
using LifeGame;

namespace Challenge4 {
    class Program {
        static void Main(string[] args) {
            #region первое и второе задания
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
            #endregion

            Console.Clear();

            #region Задание 3
            int runs = 0;
            int h = 15;
            int w = 15;
            int MaxRuns = 100;
            var sim = new LifeStim(h,w);
            while (runs++ < MaxRuns) {
                sim.DrawAndGrow();
                System.Threading.Thread.Sleep(300);
            }
            #endregion  
        }
    }
}
