using OutputData.Library.Integers;
using System;

namespace OutputData.Library.Writers
{
    public sealed class ConsoleWrite : IWrite
    {
        public void Write(Integer item) => Console.WriteLine(item);
    }
}