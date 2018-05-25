using System;

namespace Game_Life1.Game
{
    internal class Field
    {
        private char border = '+';
        private Cell[,] cells;
        private int height;
        private int indent = 1;
        private int startOfTheSquareY = 2;
        private int startOfTheSquareX = 1;
        private int width; 

        public Field()
        {
            width = 40;
            height = 10;
            cells = new Cell[height, width];

            for (int columns = 0; columns < width; columns++)
            {
                for (int rows = 0; rows < height; rows++)
                {
                    cells[rows, columns] = new Cell(columns + startOfTheSquareX, rows + startOfTheSquareY);
                }
            }
        }

        public int StartOfTheSquareY
        {
            get { return startOfTheSquareY; }
        }

        public int StartOfTheSquareX
        {
            get { return startOfTheSquareX; }
        }

        public int Width
        {
            get { return width; }
        }

        public int Indent
        {
            get { return indent; }
        }

        public int Height
        {
            get { return height; }
        }

        public Cell[,] Area
        {
            get { return cells; }
        }

        public void PrintOutTheFrame()
        {
            //(width + 2) увеличение ширины поля
            for (int i = 0; i < width + 2; i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.WriteLine(border);

                //(height + 1)увеличение длинны поля
                Console.SetCursorPosition(i, height + 1 + indent);
                Console.WriteLine(border);
            }

            //(height + 2) увеличение длинны поля
            for (int i = indent; i < height + (2 + indent); i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine(border);

                //(width + 1) увеличение ширины поля
                Console.SetCursorPosition(width + 1, i);
                Console.WriteLine(border);
            }
        }

        public void WithdrawTheArea()
        {
            for (int j = 0; j < Height; j++)
            {
                for (int i = 0; i < Width; i++)
                {
                    cells[j, i].Show();
                }
            }
        }
    }
}