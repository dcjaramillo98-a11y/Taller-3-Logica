namespace TallerLogica
{
    /// <summary>
    /// Decomposes a number into its prime factors, in ascending order,
    /// via trial division.
    /// </summary>
    public class NumberFactorization
    {
        private int _number;

        public int Number
        {
            get => _number;
            set
            {
                if (!ValidateNumber(value))
                    throw new Exception($"{nameof(Number)} must be greater than 1.");
                _number = value;
            }
        }

        public NumberFactorization(int number)
        {
            Number = number;
        }

        private bool ValidateNumber(int number) => number > 1;

        public List<int> GetFactors()
        {
            var factors = new List<int>();
            int remaining = Number;
            int divisor = 2;

            while (remaining > 1)
            {
                while (remaining % divisor == 0)
                {
                    factors.Add(divisor);
                    remaining /= divisor;
                }
                divisor++;
            }

            return factors;
        }

        public override string ToString()
        {
            var factors = GetFactors();
            return $"{Number} = {string.Join(" x ", factors)}";
        }
    }
}