namespace Reloaded.Tasks.Task22.Piotr
{
    public class CellMatrix
    {
        private readonly int _width;
        private readonly int _height;
        private readonly CellMatrixOverflowPolicy _overflowPolicy;
        private readonly CellLifeState[,] _states;

        public CellMatrix(int width, int height, CellMatrixOverflowPolicy overflowPolicy)
        {
            _width = width;
            _height = height;
            _overflowPolicy = overflowPolicy;
            _states = new CellLifeState[width, height];
        }

        public int Width => _width; // skrótowy zapis zamiast Width { get { return _width; } }
        public int Height => _height;
        public CellMatrixOverflowPolicy OverflowPolicy => _overflowPolicy;

        public CellLifeState GetCellLifeState(int x, int y)
        {
            switch (_overflowPolicy)
            {
                case CellMatrixOverflowPolicy.Clip:
                    // OPCJA 1. - Macierz obcięta czyli wszystko poza macierzą jest uznawane za martwe - odwołanie się do elementu poza macierzą zwraca stan Dead
                    
                    if (x >= _width || x < 0 ||
                        y >= _height || y < 0)
                    {
                        // Wszystko co wykracza poza macierz przyjmujemy, że jest martwe

                        return CellLifeState.Dead;
                    }
                    
                    break;

                case CellMatrixOverflowPolicy.Repeated:
                    // OPCJA 2. - Macierz powtórzona - np. dla macierzy o rozmiarze 10x20 odwołanie się do elementu (12,93) da ten sam wynik co odwołanie do elementu (2,13) - działa to tak jakby macierz została w nieskończoność powtórzona w każdym kierunku

                    x %= _width;
                    y %= _height;

                    if (x < 0)
                    {
                        x = _width + x;
                    }
                    if (y < 0)
                    {
                        y = _height + y;
                    }
                    
                    break;
            }


            // Pobranie stanu.

            return _states[x, y];
        }

        public void SetCellLifeState(int x, int y, CellLifeState cellLifeState)
        {
            _states[x, y] = cellLifeState;
        }
    }

    public enum CellMatrixOverflowPolicy
    {
        Clip,
        Repeated,
    }
}
