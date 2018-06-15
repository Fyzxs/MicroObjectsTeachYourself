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
            int expected = 9;
            int augend = 4;
            int addend = 5;
            Sum subject = new Sum(augend, addend);

            //Act
            int actual = subject.Value();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

    public class Sum
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
}
