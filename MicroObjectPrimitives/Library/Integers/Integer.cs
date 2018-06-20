using MicroObjectPrimitives.Library.Bools;
using MicroObjectPrimitives.Library.Writers;

namespace MicroObjectPrimitives.Library.Integers
{
    public abstract class Integer
    {
        public static implicit operator int(Integer origin) => origin.Value();
        protected abstract int Value();

        public void Into(IWrite writer) => writer.Write(this);
        public Bool IsEqual(Integer other) => new IntegerEquality(this, other);
        public Integer Add(Integer addend) => new Sum(this, addend);
    }
}