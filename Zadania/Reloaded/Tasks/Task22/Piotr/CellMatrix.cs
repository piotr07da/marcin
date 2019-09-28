namespace Reloaded.Tasks.Task22.Piotr
{
    public class CellMatrix
    {
        private readonly int _width;
        private readonly int _height;
        private readonly CellLifeState[,] _states;

        public CellMatrix(int width, int height)
        {
            _width = width;
            _height = height;
            _states = new CellLifeState[width, height];
        }

        public int Width => _width; // skrótowy zapis zamiast Width { get { return _width; } }
        public int Height => _height;

        public CellLifeState GetCellLifeState(int x, int y)
        {
            if (x >= _width || x < 0 ||
                y >= _height || y < 0)
            {
                // Wszystko co wykracza poza macierz przyjmujemy, że jest martwe

                return CellLifeState.Dead;
            }

            return _states[x, y];
        }

        public void SetCellLifeState(int x, int y, CellLifeState cellLifeState)
        {
            _states[x, y] = cellLifeState;
        }

        public int CountAliveNeighbors(int x, int y)
        {
            var n = 0;
            IncrementIfAlive(ref n, x - 1, y - 1);
            IncrementIfAlive(ref n, x - 1, y);
            IncrementIfAlive(ref n, x - 1, y + 1);
            IncrementIfAlive(ref n, x, y + 1);
            IncrementIfAlive(ref n, x + 1, y + 1);
            IncrementIfAlive(ref n, x + 1, y);
            IncrementIfAlive(ref n, x + 1, y - 1);
            IncrementIfAlive(ref n, x, y - 1);
            return n;
        }

        private void IncrementIfAlive(ref int counter, int x, int y)
        {
            IncrementIfAlive(ref counter, GetCellLifeState(x, y));
        }

        private void IncrementIfAlive(ref int counter, CellLifeState cellLifeState)
        {
            if (cellLifeState == CellLifeState.Alive)
            {
                ++counter;
            }
        }
    }
}
