using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer1;
using MoodAnalyzerMSTest;
using System;
namespace MoodAnalyzerMSTest
{
    [TestClass]
    public class UnitTest1
    {
            // summary 
            // TC.1: TC.2 <i am in sad mood >  < i am in happy mood> message should restun Sad.
            //</summary>
            [TestMethod]
            public void GivenSadMoodShouldReturnHAPPY()
            {
                //Arrange
                string expected = "HAPPY";
                string message = "I am in Sad Mood";
                MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);
                // act 
                string mood = moodAnalyse.AnalyseMood();
                //Assert
                Assert.AreEqual(expected, mood);
            }
    }
}
