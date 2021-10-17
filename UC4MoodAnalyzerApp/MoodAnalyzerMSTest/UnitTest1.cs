using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoodAnalyzerMSTest
{
    [TestClass]
    public class UnitTest1
    {
        private object MoodAnalyseFactory;

        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            object expected = new MoodAnalyse();
            object obj = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyserApp.MoodAnalyse", "MoodAnalyse");
            expected.Equals(obj);
        }
    }
}
