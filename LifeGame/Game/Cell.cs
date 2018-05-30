using System;

namespace LifeGame.Game
{
    internal class Cell
    {
        private bool cell = false;
        private int x;
        private int y;

        public Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public bool IsAlive
        {
            get
            {
                bool alive = false;

                if (cell)
                {
                    alive = true;
                }
                return alive;
            }
        }

        public void Kill()
        {
            if (cell)
            {
                cell = false;
            }
        }

        public void Revitalize()
        {
            if (!cell)
            {
                cell = true;
            }
        }

        public void Show()
        {
            if (cell)
            {
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write('O');
                Console.ResetColor();
            }
            else
            {
                Console.SetCursorPosition(x, y);
                Console.Write(' ');
            }
        }
    }
}