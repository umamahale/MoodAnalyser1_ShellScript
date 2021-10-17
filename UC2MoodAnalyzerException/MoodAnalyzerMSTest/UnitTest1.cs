using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerMSTest;
using static MoodAnalyzerMSTest.MoodAnalyser;
using System;

namespace MoodAnalyzerMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_Null_Mood_Should_THrow_MoodAnalysisException()
        {
            try
            {

                string message = null;
                MoodAnalyser moodAnalyse = new MoodAnalyser(message);
                string mood = moodAnalyse.AnalyseMood();
            }


            catch (MoodAnalyserCustomException e)
            {
                Assert.AreNotEqual("Mood Should not be null", e.Message);
            }
        }



        [TestMethod]  

        public void Given_Empty_Mood_Should_THrow_MoodAnalysisException_Indicating_EmptyMood()
        {
            try
            {

                string message = "";
                MoodAnalyser moodAnalyse = new MoodAnalyser(message);
                string mood = moodAnalyse.AnalyseMood();
            }


            catch (MoodAnalyserCustomException e)
            {
                Assert.AreNotEqual("Mood Should not be Empty", e.Message);
            }
        }




    }
}
