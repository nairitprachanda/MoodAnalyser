using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace UnitTestProject1
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_I_Am_In_Sad_Mood_Should_Return_SAD()
        {
            //Arrange
            string message = "I am in sad mood.";
            moodAnalyser moodAnalyser = new moodAnalyser(message);
            //Act
            string result = moodAnalyser.AnalyseMood(message);
            //Assert
            Assert.AreEqual("SAD", result);
        }
        [TestMethod]
        public void Given_I_Am_In_Happy_Mood_Should_Return_HAPPY()
        {
            //Arrange
            string message = "I am in happy mood.";
            moodAnalyser moodAnalyser = new moodAnalyser(message);
            //Act
            string result = moodAnalyser.AnalyseMood(message);
            //Assert
            Assert.AreEqual("HAPPY", result);
        }
        //Removed TC2.1 Given_Null_Should_Return_HAPPY() because now null mood will throw custom exception
        [TestMethod]
        public void Given_Null_Mood_Should_Throw_MoodAnalysisException_Indicating_Null_Mood()
        {
            try
            {
                //Arrange
                string message = null;
                moodAnalyser moodAnalyser = new moodAnalyser(message);
                //Act
                string result = moodAnalyser.AnalyseMood(message);
            }
            catch (CustomException e)
            {
                //Assert
                Assert.AreEqual("Mood should not be null.", e.Message);
            }
        }
        [TestMethod]
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisException_Indicating_Empty_Mood()
        {
            try
            {
                //Arrange
                string message = "";
                moodAnalyser moodAnalyser = new moodAnalyser(message);
                //Act
                string result = moodAnalyser.AnalyseMood(message);
            }
            catch (CustomException e)
            {
                //Assert
                Assert.AreEqual("Mood should not be empty.", e.Message);
            }
        }
    }
}
