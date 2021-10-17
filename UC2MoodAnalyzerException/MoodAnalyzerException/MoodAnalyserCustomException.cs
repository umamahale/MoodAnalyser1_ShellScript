using System;
using System.Runtime.Serialization;

namespace MoodAnalyzerException
{
    [Serializable]
    internal class MoodAnalyserCustomException : Exception
    {
        private object eMPTY_MESSAGE;
        private string v;

        public MoodAnalyserCustomException()
        {
        }

        public MoodAnalyserCustomException(string message) : base(message)
        {
        }

        public MoodAnalyserCustomException(object eMPTY_MESSAGE, string v)
        {
            this.eMPTY_MESSAGE = eMPTY_MESSAGE;
            this.v = v;
        }

        public MoodAnalyserCustomException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MoodAnalyserCustomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}