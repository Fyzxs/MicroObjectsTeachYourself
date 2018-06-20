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
            Console.WriteLine(new IntegerOf(3));
        }
    }
}
