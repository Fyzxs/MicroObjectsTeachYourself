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
            new ConsoleWrite().Into(new IntegerOf(3));
        }
    }

    public class ConsoleWrite : IWrite
    {
        public void Into(Integer item) => Console.WriteLine(item);
    }

    public interface IWrite
    {
        void Into(Integer item);
    }
}
