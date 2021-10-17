using System;

namespace MoodAnalyzerMSTest
{
    internal class MoodAnalyse
    {
        
        
            
        private string message;
      
        
        public MoodAnalyser(string messgage)
        {
            this.message = messgage;

        }

        public object MoodAnalyserCustomException { get; private set; }

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
    }
}