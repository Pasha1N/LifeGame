using System;

namespace GameLife.Game.Command
{
    internal class Up : ICommand 
    {
        private Cursor cursor;
        private Field field;

        public Up(Cursor cursor, Field field)
        {
            this.cursor = cursor;
            this.field = field;
        }

        public void Executive(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.UpArrow)
            {
                if (cursor.Y != field.StartOfTheSquareY)
                {
                    cursor.Y--;
                }
            }
        }
    }
}