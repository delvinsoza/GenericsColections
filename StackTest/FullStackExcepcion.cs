using System.Runtime.Serialization;

namespace StackTest
{
    [Serializable]
    internal class FullStackExcepcion : Exception
    {
        //parameterless constructor
        public FullStackExcepcion()
        {
        }

        public FullStackExcepcion(string? message) : base("Stack is full")
        {
            //empty constructor
        }

        public FullStackExcepcion(string? message, Exception? innerException) : base(message, innerException)
        {
            //empty constructor
        }
        //two-parameter constructor

        protected FullStackExcepcion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            //empty constructor
        }
    }
}