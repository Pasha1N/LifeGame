using System;

namespace GameLife.Game.Command
{
    internal interface ICommand 
    {
        void Executive(ConsoleKeyInfo key);
    }
}