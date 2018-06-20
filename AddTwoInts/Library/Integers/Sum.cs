namespace AddTwoInts.Library.Integers
{
    public sealed class Sum : Integer
    {
        private readonly int _augend;
        private readonly int _addend;

        public Sum(int augend, int addend)
        {
            _augend = augend;
            _addend = addend;
        }

        protected override int Value() => _augend + _addend;
    }
}