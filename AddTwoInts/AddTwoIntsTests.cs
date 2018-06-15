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
            ISum subject = new Sum(augend, addend);

            //Act
            int actual = subject.Value();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

    public abstract class Integer
    {
        public static implicit operator int(Integer origin) => origin.Value();
        protected abstract int Value();
    }

    public class IntegerOf : Integer
    {
        private readonly int _origin;

        public IntegerOf(int origin) => _origin = origin;

        protected override int Value() => _origin;
    }

    public class Sum : ISum
    {
        private readonly int _augend;
        private readonly int _addend;

        public Sum(int augend, int addend)
        {
            _augend = augend;
            _addend = addend;
        }

        public int Value()
        {
            return _augend + _addend;
        }
    }

    public interface ISum
    {
        int Value();
    }
}
