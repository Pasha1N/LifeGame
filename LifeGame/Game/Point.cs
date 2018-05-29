namespace GameLife.Game
{
    internal class Point
    {
        private bool toKill;
        private bool toRevitalize;
        private int x;
        private int y;

        public Point(int y, int x)
        {
            this.x = x;
            this.y = y;
        }
         
        public bool ToKill
        {
            get { return toKill; }
            set { toKill = value; }
        }

        public bool ToRevitalize
        {
            get { return toRevitalize; }
            set { toRevitalize = value; }
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }
    }
}