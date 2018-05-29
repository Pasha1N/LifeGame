using System;

namespace GameLife.Game.Command
{
    internal class Down : ICommand 
    {
        private Cursor cursor;
        private Field field;

        public Down(Field field, Cursor cursor)
        {
            this.field = field;
            this.cursor = cursor;
        }

        public void Executive(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.DownArrow)
            {
                if (cursor.Y != field.Height+field.Indent)
                {
                    cursor.Y++;
                }
            }
        }
    }
}