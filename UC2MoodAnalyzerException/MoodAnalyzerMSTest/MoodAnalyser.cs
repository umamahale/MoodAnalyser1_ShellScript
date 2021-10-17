using System;

namespace MoodAnalyzerMSTest
{
    internal class MoodAnalyser
    {
        private string message;

        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        internal string AnalyseMood()
        {
            throw new NotImplementedException();
        }
    }
}