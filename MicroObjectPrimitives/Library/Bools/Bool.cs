namespace MicroObjectPrimitives.Library.Bools {
    public abstract class Bool
    {
        public static implicit operator bool(Bool origin) => origin.Value();
        protected abstract bool Value();
    }
}