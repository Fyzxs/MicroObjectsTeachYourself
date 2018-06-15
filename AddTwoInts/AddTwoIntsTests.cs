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

            //Act
            int actual = Sum(augend, addend);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        private int Sum(int augend, int addend)
        {
            return augend + addend;
        }
    }
}
