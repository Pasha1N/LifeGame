using System;

namespace LifeGame.Game.Command
{
    internal interface ICommand 
    {
        void Executive(ConsoleKeyInfo key);
    }
}