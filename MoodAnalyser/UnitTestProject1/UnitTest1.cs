using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace UnitTestProject1
{
   
        [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void TestMethod1()
            {
                //Arrange
                string message = "I am in Happy Mood";
                string expected = "HAPPY";
                moodAnalyser mood = new moodAnalyser(message);
                //Act
                string result = mood.AnalyseMood(message);
                //Assert
                Assert.AreEqual(expected, result);
            }
        }
}
