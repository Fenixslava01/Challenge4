using System;
namespace Matrix {
    class MatrixController {
        private readonly int rows;
        private readonly int cols;
        private readonly Random rand = new Random();
        public MatrixController(int x, int y) {
            rows = x;
            cols = y;
        }
        public int[,] CreateMatrix() {
            int[,] matrix = new int[rows, cols];
            return matrix;
        }
        public int[,] FillMatrix(int [,] matrix) {
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    matrix[i, j] = rand.Next(0, 50);
                }
            }
            return matrix;
        }
        public void ShowMatrix(int[,] matrix) {
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    Console.Write($"{matrix[i, j],2} ");
                }
                Console.WriteLine("");
            }
        }
        public int[,] SummMatrix(int[,] matrixA, int[,] matrixB, int [,] summMatrixC) {
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    summMatrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }
            return summMatrixC;  
        }
        public void ShowSummAndExit(int[,] matrix) {
            int summMatrix = 0;
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    summMatrix += matrix[i, j];
                }
            }
            Console.WriteLine($"summMatrix = {summMatrix}");
            Console.WriteLine("Нажмите любую кнопку для продолжения...");
            Console.ReadKey();
        }
    }
}