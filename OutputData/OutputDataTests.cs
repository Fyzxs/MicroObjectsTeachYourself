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
    }
}
