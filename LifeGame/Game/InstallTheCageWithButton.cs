using Game_Life1.Game.Command;
using System;
using System.Collections.Generic;

namespace Game_Life1.Game
{
    internal class InstallTheCageWithButton
    {
        private Field field;
        private Cell[,] cells;
        private ICollection<ICommand> commands = new List<ICommand>();
        private Cursor cursor = new Cursor(1, 2);
         
        public InstallTheCageWithButton(Field field)
        {
            this.field = field;
            cells = field.Area;
        }

        public void InstallTheCage()
        {
            ControlOverWork toWork = new ControlOverWork();
            cursor.Show();

            Right right = new Right(field, cursor);
            Left left = new Left(cursor);
            Up up = new Up(cursor, field);
            Down down = new Down(field, cursor);
            CellCondition cellCondition = new CellCondition(field, cursor);
            Start start = new Start(toWork);

            commands.Add(right);
            commands.Add(left);
            commands.Add(up);
            commands.Add(down);
            commands.Add(cellCondition);
            commands.Add(start);

            ConsoleKeyInfo key;
            toWork.CurrentState = true;

            while (toWork.CurrentState)
            {
                key = Console.ReadKey();
                Console.SetCursorPosition(cursor.X, cursor.Y);
                //очистка хвоста
                Console.Write(' ');

                foreach (ICommand command in commands)
                {
                    command.Executive(key);
                }

                field.PrintOutTheFrame();
                field.WithdrawTheArea();
                cursor.Show();
            }
        }
    }
}