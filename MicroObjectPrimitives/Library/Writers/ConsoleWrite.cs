using MicroObjectPrimitives.Library.Integers;
using System;

namespace MicroObjectPrimitives.Library.Writers
{
    public sealed class ConsoleWrite : IWrite
    {
        public void Write(Integer item) => Console.WriteLine(item);
    }
}