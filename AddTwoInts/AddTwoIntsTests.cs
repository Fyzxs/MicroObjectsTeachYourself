using MicroObjectPrimitives.Library.Integers;
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
            Integer subject = augend.Add(addend);

            //Act
            //Assert
            Assert.IsTrue(subject.IsEqual(expected), $"Actual <{(int)subject}> was not the same as Expected <{(int)expected}>");
        }
    }
}
