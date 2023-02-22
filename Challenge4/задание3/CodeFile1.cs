using System;

namespace LifeGame {
    public class LifeStim {
        private int width;
        private int height;
        private bool[,] cells;
        public LifeStim(int x, int y) {
            width = x;
            height = y;
            cells = new bool[width, height];
            GenerateField();
        }
        private void GenerateField() {
            Random rand = new Random();
            for (int i = 0; i < height; i++) {
                for (int j = 0; j < width; j++) {
                    cells[i, j] = rand.Next(0, 2) != 0;
                }
            }
        }
        public void DrawAndGrow() {
            Draw();
            Grow();
        }
        private void Grow() {
            for (int i = 0; i < height; i++) {
                for (int j = 0; j < width; j++) {
                    int numOfAliveNeighbors = GetNeighbors(i, j);
                    if (cells[i, j]) {
                        if (numOfAliveNeighbors < 4) {
                            cells[i, j] = false;
                        }
                        if (numOfAliveNeighbors > 5) {
                            cells[i, j] = false;
                        }
                    }
                    else {
                        if (numOfAliveNeighbors == 2) {
                            cells[i, j] = true;
                        }
                    }
                }
            }
        }
        private int GetNeighbors(int x, int y) {
            int numOfAliveNeighbors = 0;
            for (int i = x - 1; i < x + 2; i++) {
                for (int j = y - 1; j < y + 2; j++) {
                    if (!((i < 0 || j < 0) || (i >= height || j >= width))) {
                        if (cells[i, j] == true) numOfAliveNeighbors++;
                    }
                }
            }
            return numOfAliveNeighbors;
        }
        private void Draw() {
            Console.CursorVisible = false;
            for (int i = 0; i < height; i++)  {
                for (int j = 0; j < width; j++) {
                    Console.Write(cells[i, j] ? "x" : " ");
                }
                Console.WriteLine("\r");
            }
            Console.SetCursorPosition(0, Console.WindowTop);
        }
    }
}