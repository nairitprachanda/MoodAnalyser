using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class moodAnalyser
    {
        private string message;
        public moodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood(string mesaage)
        {
            try
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
            catch
            {
                //Returning Happy when case of Null exception
                return "HAPPY";
            }
        }
    }
}
