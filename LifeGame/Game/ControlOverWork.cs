namespace LifeGame.Game
{
    internal class ControlOverWork
    {
        private bool toWork;

        public bool CurrentState
        {
            get { return toWork; }
            set { toWork = value; }
        }
    }
} 