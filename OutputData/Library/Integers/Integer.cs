namespace OutputData.Library.Integers
{
    public abstract class Integer
    {
        public static implicit operator int(Integer origin) => origin.Value();
        protected abstract int Value();

        public void Into(IWrite writer) => writer.Write(this);
    }
}