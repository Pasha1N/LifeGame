using System.Collections.Generic;
using System.Threading;

namespace Game_Life1.Game
{
    internal class LogicTheGame
    {
        private Cell[,] cells;
        private ICollection<Point> cellIndices = new List<Point>();
        private Field field;
        private IList<Cell[,]> fields = new List<Cell[,]>();
        private Generation generation = new Generation();

        public LogicTheGame(Field field, Generation generation)
        { 
            this.field = field;
            cells = field.Area;
            this.generation = generation;
        }

        public void Start()
        {
            bool toWork = true;
            while (toWork)
            {
                generation.Show();
                Thread.Sleep(300);

                for (int row = 0; row < field.Height; row++)
                {
                    for (int column = 0; column < field.Width; column++)
                    {
                        int numberLiving = 0;
                        int numberDead = 0;

                        for (int height = row - 1; height < row + 2; height++)
                        {
                            for (int width = column - 1; width < column + 2; width++)
                            {
                                if (height >= 0 && width >= 0 && height < field.Height && width < field.Width)
                                {
                                    if (cells[height, width].IsAlive())
                                    {
                                        numberLiving++;
                                    }
                                    else
                                    {
                                        numberDead++;
                                    }
                                }
                            }
                        }

                        if (cells[row, column].IsAlive())
                        {
                            if (numberLiving < 3 || numberLiving > 4)
                            {
                                Point point = new Point(row, column);
                                point.ToKill = true;
                                cellIndices.Add(point);
                            }
                        }
                        else
                        {
                            if (numberLiving == 3)
                            {
                                Point point = new Point(row, column);
                                point.ToRevitalize = true;
                                cellIndices.Add(point);
                            }
                        }
                    }
                }

                foreach (Point point in cellIndices)
                {
                    if (point.ToKill)
                    {
                        cells[point.Y, point.X].Kill();
                    }

                    if (point.ToRevitalize)
                    {
                        cells[point.Y, point.X].Revitalize();
                    }
                }

                field.WithdrawTheArea();
                generation.Next();

                int rows = field.Height;
                int columns = field.Width;
                int countCells = rows * columns;

                if (fields.Count > 1)
                {
                    foreach (Cell[,] area in fields)
                    {
                        int count = 0;
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                if (area[i, j].IsAlive() == cells[i, j].IsAlive())
                                {
                                    count++;
                                }
                            }
                        }

                        if (count == countCells)
                        {
                            toWork = false;
                        }
                    }
                }

                Cell[,] copyOfCells = new Cell[rows, columns];
                int numberOfDead = 0;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        copyOfCells[i, j] = new Cell(i, j);
                        if (cells[i, j].IsAlive())
                        {
                            copyOfCells[i, j].Revitalize();
                        }
                        else
                        {
                            copyOfCells[i, j].Kill();
                            numberOfDead++;
                        }
                    }
                }

                if (numberOfDead == countCells)
                {
                    toWork = false;
                }
                fields.Add(copyOfCells);
            }
        }
    }
}