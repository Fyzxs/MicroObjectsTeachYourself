using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutputData.Library.Integers;
using System;

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
    }

    public class ConsoleWrite : IWrite
    {
        public void Write(Integer item) => Console.WriteLine(item);
    }

    public interface IWrite
    {
        void Write(Integer item);
    }
}
