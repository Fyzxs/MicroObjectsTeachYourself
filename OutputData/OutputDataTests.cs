using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutputData.Library.Integers;
using OutputData.Library.Writers;

namespace OutputData
{
    [TestClass]
    public class OutputDataTests
    {
        [TestMethod]
        public void ShouldOutputFromInt()
        {
            IWrite writer = new ConsoleWrite();
            Integer integer = new IntegerOf(3);
            integer.Into(writer);
        }

        [TestMethod]
        public void ShouldTestIntegerWrites()
        {
            FakeWrite fakeWrite = new FakeWrite();
            Integer integer = new IntegerOf(3);
            integer.Into(fakeWrite);

            Assert.AreEqual((int)integer, fakeWrite.Item);//Duplicate More From AddTwoInts?
        }

        private class FakeWrite : IWrite
        {
            public Integer Item;
            public void Write(Integer item)
            {
                Item = item;
            }
        }
    }
}
