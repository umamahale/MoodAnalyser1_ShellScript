﻿using System;
using System.Collections.Generic;
using System.Text;
using static MoodAnalyzerApp.MoodAnalysisCustomException;

namespace MoodAnalyzerApp
{
    class MoodAnalyser
    {
        
        
            private string message;
            public MoodAnalyser()
            { }
            public MoodAnalyser(string messgage)
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


