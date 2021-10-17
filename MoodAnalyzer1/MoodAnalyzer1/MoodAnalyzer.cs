using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer1
{
   public class MoodAnalyzer
    {
       
        


            private string message;

            public MoodAnalyzer(string messgage)

            {
                this.message = messgage;

            }

            public string AnalyseMood()
            {
                if (this.message.Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
        }
    }

