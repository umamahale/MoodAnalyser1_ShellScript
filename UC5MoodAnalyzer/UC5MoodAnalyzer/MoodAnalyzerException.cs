using System;
using System.Runtime.Serialization;

namespace UC5MoodAnalyzer
{
    [Serializable]
    internal class MoodAnalyzerException : Exception
    {
        private object nO_SUCH_METHOD;
        private string v;

        public MoodAnalyzerException()
        {
        }

        public MoodAnalyzerException(string message) : base(message)
        {
        }

        public MoodAnalyzerException(object nO_SUCH_METHOD, string v)
        {
            this.nO_SUCH_METHOD = nO_SUCH_METHOD;
            this.v = v;
        }

        public MoodAnalyzerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MoodAnalyzerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        internal class ExceptionType
        {
            public static string NO_SUCH_METHOD { get; internal set; }

            internal class NO_SUCH_CLASS
            {
            }
        }
    }
}