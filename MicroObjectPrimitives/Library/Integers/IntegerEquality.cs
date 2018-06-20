using MicroObjectPrimitives.Library.Bools;

namespace MicroObjectPrimitives.Library.Integers
{
    public sealed class IntegerEquality : Bool
    {
        private readonly Integer _lhs;
        private readonly Integer _rhs;

        public IntegerEquality(Integer lhs, Integer rhs)
        {
            _lhs = lhs;
            _rhs = rhs;
        }

        protected override bool Value() => (int)_lhs == _rhs;
    }
}