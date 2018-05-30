namespace LifeGame.Game
{
    internal class Application
    {
        private Cell[,] area = null;
        private Field areaOfField;
        private Field field = new Field();
        private Generation generation = new Generation(); 

        public Application()
        {
            areaOfField = new Field();
            area = field.Area;

            generation.Show();
            InstallTheCageWithButton installTheCageWithButton = new InstallTheCageWithButton(field);
            field.PrintOutTheFrame();
            installTheCageWithButton.InstallTheCage();
            Start();
        }

        public void Start()
        {
            LogicTheGame logicTheGame = new LogicTheGame(field, generation);
            logicTheGame.Start();
        }
    }
}