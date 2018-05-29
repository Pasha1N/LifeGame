using System;

namespace Game_Life1.Game.Command
{
    internal class CellCondition : ICommand 
    {
        private Cursor cursor;
        private Cell[,] cells;
        private Field field;

        public CellCondition(Field field, Cursor cursor)
        {
            this.cursor = cursor;
            this.field = field;
            cells = field.Area;
        }

        public void Executive(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.Enter)
            {
                bool @break = false;
                bool Is = false;
                int xOfTheCurrentCell = 0;
                int yOfTheCurrentCell = 0;

                for (int j = 0; j < field.Height; j++)
                {
                    for (int i = 0; i < field.Width; i++)
                    {
                        if (cells[j, i] != null)
                        {
                            if (cells[j, i].X == cursor.X && cells[j, i].Y == cursor.Y)
                            {
                                if (cells[j, i].IsAlive)
                                {
                                    Is = true;
                                    @break = true;
                                }
                            }

                            xOfTheCurrentCell = cells[cursor.Y - field.StartOfTheSquareY, cursor.X - field.StartOfTheSquareX].X;
                            yOfTheCurrentCell = cells[cursor.Y - field.StartOfTheSquareY, cursor.X - field.StartOfTheSquareX].Y;
                        }

                        if (@break)
                        {
                            break;
                        }
                    }

                    if (@break)
                    {
                        break;
                    }
                }

                if (Is)
                {
                    cells[yOfTheCurrentCell - field.StartOfTheSquareY, xOfTheCurrentCell - field.StartOfTheSquareX].Kill();
                }
                else
                {
                     cells[yOfTheCurrentCell - field.StartOfTheSquareY, xOfTheCurrentCell - field.StartOfTheSquareX].Revitalize();
                }

                cells[yOfTheCurrentCell - field.StartOfTheSquareY, xOfTheCurrentCell - field.StartOfTheSquareX].Show();
            }
        }
    }
}