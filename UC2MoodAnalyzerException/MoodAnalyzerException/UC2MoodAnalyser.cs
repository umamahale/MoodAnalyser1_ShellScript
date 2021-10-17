using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerException
{
    class UC2MoodAnalyser
    {
        
        private string message;
        private object MoodAnalyserCustomException;

        public UC2MoodAnalyser()
        {
        }
        public UC2MoodAnalyser(string messgage)
        {
            this.message = messgage;

        }

        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                }

                if (this.message.Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }

        }

    }
}
