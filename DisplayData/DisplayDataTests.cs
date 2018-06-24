using MicroObjectPrimitives.Library.Integers;
using MicroObjectPrimitives.Library.Writers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DisplayData
{
    [TestClass]
    public class DisplayDataTests
    {
        [TestMethod]
        public void ShouldOutputFromInt()
        {
            IWrite writer = new ConsoleWrite();
            IInto value = new IntegerOf(3);
            value.Into(writer);
        }

        [TestMethod]
        public void ShouldTestIntegerWrites()
        {
            FakeWrite fakeWrite = new FakeWrite();
            Integer integer = new IntegerOf(3);
            integer.Into(fakeWrite);


            Assert.IsTrue(integer.IsEqual(fakeWrite.Item));
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
