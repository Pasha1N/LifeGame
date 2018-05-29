using System;

namespace GameLife.Game.Command
{
    internal class Start : ICommand 
    {
        private ControlOverWork toWork;

        public Start(ControlOverWork toWork)
        {
            this.toWork = toWork;
        }

        public void Executive(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.Spacebar)
            {
                toWork.CurrentState = false;
            }
        }
    }
}