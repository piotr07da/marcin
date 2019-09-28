namespace Reloaded.Tasks.Task22.Piotr
{
    public class ConwaysGameOfLife
    {
        public ConwaysGameOfLife(CellMatrix initialMatrix)
        {
            _currentMatrix = initialMatrix;
        }

        private CellMatrix _currentMatrix;
        public CellMatrix CurrentMatrix { get { return _currentMatrix; } }

        public void CalculateNextMatrix()
        {
            var nextMatrix = new CellMatrix(_currentMatrix.Width, _currentMatrix.Height, _currentMatrix.OverflowPolicy);

            for (var x = 0; x < _currentMatrix.Width; ++x)
            {
                for (var y = 0; y < _currentMatrix.Height; ++y)
                {
                    var state = _currentMatrix.GetCellLifeState(x, y);
                    var aliveNeighbors = CountAliveNeighbors(x, y);

                    switch (state)
                    {
                        case CellLifeState.Dead:
                            if (aliveNeighbors == 3)
                            {
                                nextMatrix.SetCellLifeState(x, y, CellLifeState.Alive);
                            }
                            else
                            {
                                nextMatrix.SetCellLifeState(x, y, CellLifeState.Dead);
                            }
                            break;

                        case CellLifeState.Alive:
                            if (aliveNeighbors < 2 || aliveNeighbors > 3)
                            {
                                nextMatrix.SetCellLifeState(x, y, CellLifeState.Dead);
                            }
                            else
                            {
                                nextMatrix.SetCellLifeState(x, y, CellLifeState.Alive);
                            }
                            break;
                    }
                }
            }

            _currentMatrix = nextMatrix;
        }

        public int CountAliveNeighbors(int x, int y)
        {
            var n = 0;

            IncrementIfAlive(ref n, x - 1, y - 1);
            IncrementIfAlive(ref n, x - 1, y);
            IncrementIfAlive(ref n, x - 1, y + 1);

            IncrementIfAlive(ref n, x + 1, y - 1);
            IncrementIfAlive(ref n, x + 1, y);
            IncrementIfAlive(ref n, x + 1, y + 1);

            IncrementIfAlive(ref n, x, y - 1);
            IncrementIfAlive(ref n, x, y + 1);

            return n;
        }

        private void IncrementIfAlive(ref int counter, int x, int y)
        {
            IncrementIfAlive(ref counter, _currentMatrix.GetCellLifeState(x, y));
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
