using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoodAnalyzerMSTest
{
    [TestClass]
    public class UnitTest1
    {
        public object MoodAnalyseFactory { get; private set; }

        [TestMethod]
        public void GivenAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyse("HAPPY");
            object obj = MoodAnalyseFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerApp.MoodAnalyse", "MoodAnalyse", "HAPPY");
            expected.Equals(obj);
        }
    }
}
