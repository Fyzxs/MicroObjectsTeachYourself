using AddTwoInts.Library.Bools;

namespace AddTwoInts.Library.Integers {
    public abstract class Integer
    {
        public static implicit operator int(Integer origin) => origin.Value();
        protected abstract int Value();
        public Bool IsEqual(Integer other) => new IntegerEquality(this, other);
        public Integer Add(Integer addend) => new Sum(this, addend);
    }
}