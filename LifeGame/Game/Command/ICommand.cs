using System;

namespace Game_Life1.Game.Command
{
    internal interface ICommand 
    {
        void Executive(ConsoleKeyInfo key);
    }
}