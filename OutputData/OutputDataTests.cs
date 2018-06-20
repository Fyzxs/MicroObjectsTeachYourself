using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace OutputData
{
    [TestClass]
    public class OutputDataTests
    {
        [TestMethod]
        public void ShouldOutputFromInt()
        {
            Console.WriteLine(3);
        }
    }
}
