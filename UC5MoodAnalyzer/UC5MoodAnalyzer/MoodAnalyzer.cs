using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace UC5MoodAnalyzer
{
    class MoodAnalyzer
    {
        public static object CreateMoodAnalysisUsingParameterizedConstructor(string className, string constructorName, string message)
        {
            Type type = typeof(MoodAnalyzer);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                object Instance = ctor.Invoke(new object[] { message });
                return Instance;
            }

            else
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_METHOD, "Constructor is not Found");
            }
        }
          
        else
              {
                   throw private new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_CLASS, "class not found");
            
              }
         
}
     











