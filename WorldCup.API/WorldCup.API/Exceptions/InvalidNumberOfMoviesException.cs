using System;
using System.Runtime.Serialization;

namespace WorldCup.API.Exceptions
{
    [Serializable]
    public class InvalidNumberOfMoviesException : Exception
    {
        public InvalidNumberOfMoviesException()
        {
        }

        public InvalidNumberOfMoviesException(string message) : base(message)
        {
        }

        public InvalidNumberOfMoviesException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidNumberOfMoviesException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}