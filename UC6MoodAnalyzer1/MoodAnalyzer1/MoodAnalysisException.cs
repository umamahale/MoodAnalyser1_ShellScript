using System;
using System.Runtime.Serialization;

namespace MoodAnalyzer1
{
    [Serializable]
    internal class MoodAnalysisException : Exception
    {
        private object nO_SUCH_METHOD;
        private string v;

        public MoodAnalysisException()
        {
        }

        public MoodAnalysisException(string message) : base(message)
        {
        }

        public MoodAnalysisException(object nO_SUCH_METHOD, string v)
        {
            this.nO_SUCH_METHOD = nO_SUCH_METHOD;
            this.v = v;
        }

        public MoodAnalysisException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MoodAnalysisException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}