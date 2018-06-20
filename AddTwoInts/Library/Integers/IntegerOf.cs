namespace AddTwoInts.Library.Integers {
    public sealed class IntegerOf : Integer
    {
        private readonly int _origin;

        public IntegerOf(int origin) => _origin = origin;

        protected override int Value() => _origin;
    }
}