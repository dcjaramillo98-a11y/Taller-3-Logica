namespace Ejercicio30
{
    /// <summary>
    /// A square matrix of the given order, filled with the formula
    /// Cell[i][j] = (i + 1) - j. Exposes the sum, max and min of all
    /// its cells.
    /// </summary>
    public class SquareMatrix
    {
        private int _order;
        private int[,] _cells = new int[0, 0];

        public int Order
        {
            get => _order;
            set
            {
                if (!ValidateOrder(value))
                    throw new ArgumentOutOfRangeException(nameof(Order), value, $"{nameof(Order)} must be greater than 0.");
                _order = value;
            }
        }

        public SquareMatrix(int order)
        {
            Order = order;
            Fill();
        }

        private bool ValidateOrder(int order) => order > 0;

        private void Fill()
        {
            _cells = new int[Order, Order];
            for (int i = 0; i < Order; i++)
            {
                for (int j = 0; j < Order; j++)
                {
                    _cells[i, j] = (i + 1) - j;
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < Order; i++)
            {
                var row = new List<string>();
                for (int j = 0; j < Order; j++)
                {
                    row.Add(_cells[i, j].ToString());
                }
                Console.WriteLine(string.Join(" ", row));
            }
        }

        public int GetSum()
        {
            int sum = 0;
            foreach (int cell in _cells)
                sum += cell;
            return sum;
        }

        public int GetMax()
        {
            int max = _cells[0, 0];
            foreach (int cell in _cells)
                if (cell > max)
                    max = cell;
            return max;
        }

        public int GetMin()
        {
            int min = _cells[0, 0];
            foreach (int cell in _cells)
                if (cell < min)
                    min = cell;
            return min;
        }
    }
}
