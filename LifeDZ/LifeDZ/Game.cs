namespace LifeDZ
{
    class Game
    {
        private bool[,] _isLife;
        private int[,] _area;
        private int _n;
        public Game(int n)
        {
            _n = n;
            _area = new int[_n, _n];
            _isLife = new bool[_n, _n];

            for (int i = 0; i < _n; i++)
                for (int j = 0; j < _n; j++)
                {
                    _area[i, j] = 0;
                    _isLife[i, j] = false;
                }
        }
        public void search_for_life(int col, int row)
        {

            if (_isLife[col, row] != true)
            {
                _isLife[col, row] = true;
                _area[col, row] = 50;
            }
        }
        public void search_for_life()
        {
            for (int col = 0; col < _n; col++)
                for (int row = 0; row < _n; row++)
                {
                    var neighboursCount = CountNeighbours(col, row);
                    var haslife = _isLife[col, row];
                    if (!haslife && neighboursCount == 3)
                    {
                        _isLife[col, row] = true;
                        _area[col, row] = 50;
                    }

                    else if (haslife && (neighboursCount < 2 || neighboursCount > 3))
                    {
                        _isLife[col, row] = false;
                        _area[col, row] = 0;
                    }


                }

        }


        public int Life_count()
        {
            int count = 0;
            for (int i = 0; i < _n; i++)
                for (int j = 0; j < _n; j++)
                {
                    if (_isLife[i, j] == true)
                        count++;
                }
            return count;
        }

        public int CountNeighbours(int x, int y)
        {
            int count = 0;
            for (int i = -1; i < 2; i++)
            {

                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + _n) % _n;
                    var row = (y + j + _n) % _n;
                    var isSelfChecking = col == x && row == y;
                    var hasLife = _isLife[col, row];
                    if (hasLife && !isSelfChecking)
                    {
                        count++;
                    }
                }
            }

            return count;

        }


        public int[,] Area
        {
            get { return _area; }
        }

    }
}
