// create arrays of doubles and int 

using System.Runtime.Serialization;

[Serializable]
internal class FullStackException : Exception
{
    public FullStackException()
    {
    }

    public FullStackException(string? message) : base(message)
    {
    }

    public FullStackException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected FullStackException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}