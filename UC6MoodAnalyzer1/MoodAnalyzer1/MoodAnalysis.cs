using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MoodAnalyzer1
{
    
    public static string InvokeAnalyseMood(string message, string methodName)
        {
            try
            {
            Type type = Type.GetType("MoodAnalyzerApp.MoodAnalyse");
            object MoodAnalyseFactory = null;
            object moodAnalyseObject = MoodAnalyseFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerApp.MoodAnalyse","MoodAnalyse",message);
            MethodInfo analyseMoodInfo = type.GetMethod(methodName);
            object mood = analyseMoodInfo.Invoke(moodAnalyseObject, null);
            return mood.ToString();

            }
            catch(NullReferenceException)
            {
            throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "method is not found");
             }
        }
    }

