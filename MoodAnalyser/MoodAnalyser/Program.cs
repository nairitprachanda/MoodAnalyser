using System;

namespace MoodAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mood Analyser Problem!");
            Console.WriteLine("Enter message: ");
            string message = Console.ReadLine();
            moodAnalyser checkMood = new moodAnalyser(message);
            string result = checkMood.AnalyseMood(message);
            Console.WriteLine(result + " MOOD");
        }
    }
}
