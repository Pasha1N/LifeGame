using System;

namespace Game_Life1.Game
{
    internal class Generation
    {
        private int count = 0;
         
        public void Next()
        {
            count++;
        }

        public int Count
        {
            get { return count; }
        }

        public void Show()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("Generation: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(count);
            Console.ResetColor();
        }
    }
}