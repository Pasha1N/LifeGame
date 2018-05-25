using System;

namespace Game_Life1.Game
{
    internal class Cursor
    {
        private int x;
        private int y;
         
        public Cursor(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Show()
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine('X');
            Console.ResetColor();
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}