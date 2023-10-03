using System.Runtime.Serialization;

namespace StackTest
{
    [Serializable]
    public class EmpttyStackException : Exception
    {
        public EmpttyStackException() : base("Stack is empty")
        {
            //empty constructor
        }
        //one-parameter constructor

        public EmpttyStackException(string? message) : base(message)
        {

        }
        //two-parameter constructor

        public EmpttyStackException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EmpttyStackException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}