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
            var matrix = _textFileCellMatrixImporter.Import(lines, CellMatrixOverflowPolicy.Repeated);

            Task.Run(() =>
            {
                var cgol = new ConwaysGameOfLife(matrix);

                while (true)
                {
                    _cellMatrixDrawer.Draw(matrix);
                    cgol.CalculateNextMatrix();
                    matrix = cgol.CurrentMatrix;
                    Thread.Sleep(50);

                }
            });

            Console.ReadKey();
        }


    }
}
