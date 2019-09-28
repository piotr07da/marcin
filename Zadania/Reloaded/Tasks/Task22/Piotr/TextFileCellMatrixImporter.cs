namespace Reloaded.Tasks.Task22.Piotr
{
    public class TextFileCellMatrixImporter
    {
        public CellMatrix Import(string[] lines, CellMatrixOverflowPolicy overflowPolicy)
        {
            var matrix = new CellMatrix(lines[0].Length, lines.Length, overflowPolicy); // szerokość to długość zerowej linijki, wysokość to liczba linijek

            for (var x = 0; x < matrix.Width; ++x)
            {
                for (var y = 0; y < matrix.Height; ++y)
                {
                    CellLifeState state;

                    if (lines[y][x] == '#')
                    {
                        state = CellLifeState.Alive;
                    }
                    else
                    {
                        state = CellLifeState.Dead;
                    }

                    matrix.SetCellLifeState(x, y, state);
                }
            }

            return matrix;
        }
    }
}
