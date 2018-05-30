using System;

namespace LifeGame.Game.Command
{
    internal class Right : ICommand 
    {
        private Cursor cursor;
        private Field field;

        public Right(Field field, Cursor cursor)
        {
            this.field = field;
            this.cursor = cursor;
        }

        public void Executive(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.RightArrow)
            {
                if (cursor.X != field.Width)
                {
                    cursor.X++;
                }
            }
        }
    }
}