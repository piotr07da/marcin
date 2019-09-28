using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task22.Piotr
{
    public class TaskClass22piotr
    {
        private readonly TextFileCellMatrixImporter _textFileCellMatrixImporter;
        private readonly CellMatrixDrawer _cellMatrixDrawer;

        public TaskClass22piotr()
        {
            _textFileCellMatrixImporter = new TextFileCellMatrixImporter();
            _cellMatrixDrawer = new CellMatrixDrawer();
        }

        public void Test()
        {
            var lines = File.ReadAllLines(@"Tasks\Task22\spaceship.txt");
            var matrix = _textFileCellMatrixImporter.Import(lines);

            Task.Run(() =>
            {
                while (true)
                {
                    matrix = NextCellMatrix(matrix);
                    _cellMatrixDrawer.Draw(matrix);
                    Thread.Sleep(100);
                }
            });

            Console.ReadKey();
        }

        private CellMatrix NextCellMatrix(CellMatrix currentCellMatrix)
        {
            var newCellMatrix = new CellMatrix(currentCellMatrix.Width, currentCellMatrix.Height);

            for (var x = 0; x < currentCellMatrix.Width; ++x)
            {
                for (var y = 0; y < currentCellMatrix.Height; ++y)
                {
                    var state = currentCellMatrix.GetCellLifeState(x, y);
                    var aliveNeighbors = currentCellMatrix.CountAliveNeighbors(x, y);

                    switch (state)
                    {
                        case CellLifeState.Dead:
                            if (aliveNeighbors == 3)
                            {
                                newCellMatrix.SetCellLifeState(x, y, CellLifeState.Alive);
                            }
                            else
                            {
                                newCellMatrix.SetCellLifeState(x, y, CellLifeState.Dead);
                            }
                            break;

                        case CellLifeState.Alive:
                            if (aliveNeighbors < 2 || aliveNeighbors > 3)
                            {
                                newCellMatrix.SetCellLifeState(x, y, CellLifeState.Dead);
                            }
                            else
                            {
                                newCellMatrix.SetCellLifeState(x, y, CellLifeState.Alive);
                            }
                            break;
                    }
                }
            }

            return newCellMatrix;
        }
    }
}
