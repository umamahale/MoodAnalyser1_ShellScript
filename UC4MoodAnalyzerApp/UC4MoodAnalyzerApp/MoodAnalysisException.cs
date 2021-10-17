using System;
using System.Runtime.Serialization;

namespace UC4MoodAnalyzerApp
{
    [Serializable]
    internal class MoodAnalysisException : Exception
    {
        private object nO_SUCH_CLASS;
        private string v;

        public MoodAnalysisException()
        {
        }

        public MoodAnalysisException(string message) : base(message)
        {
        }

        public MoodAnalysisException(object nO_SUCH_CLASS, string v)
        {
            this.nO_SUCH_CLASS = nO_SUCH_CLASS;
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