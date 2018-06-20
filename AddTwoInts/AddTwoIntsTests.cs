using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddTwoInts
{
    [TestClass]
    public class AddTwoIntsTests
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldReturnSumOfTwoInts()
        {
            //Arrange
            Integer expected = new IntegerOf(9);
            Integer augend = new IntegerOf(4);
            Integer addend = new IntegerOf(5);
            Integer subject = new Sum(augend, addend);

            //Act
            Bool integerEquality = new IntegerEquality(subject, expected);

            //Assert
            Assert.IsTrue(integerEquality);
        }
    }

    public abstract class Integer
    {
        public static implicit operator int(Integer origin) => origin.Value();
        protected abstract int Value();
    }

    public sealed class IntegerOf : Integer
    {
        private readonly int _origin;

        public IntegerOf(int origin) => _origin = origin;

        protected override int Value() => _origin;
    }

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

    public class IntegerEquality : Bool
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

    public abstract class Bool
    {
        public static implicit operator bool(Bool origin) => origin.Value();
        protected abstract bool Value();
    }
}
