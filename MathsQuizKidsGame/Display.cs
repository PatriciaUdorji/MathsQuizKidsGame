using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MathsQuizKidsGame
{
    internal class Display
    {
        public static void storeStudentsAndScoresDetails(int totalScore, int totalQuestion)
        {
            Console.WriteLine("you scored {0}/{1}", totalScore, totalQuestion);
            FilesDepository.studentName(totalScore);
            FilesDepository.saveStudentNameAndScore();
        }
        public static void displayStudentsAndScores()
        {
            Console.WriteLine("Top Scorers: ");
            Dictionary<string, int> collection = FilesDepository.loadStudentNameAndScore();
            foreach (KeyValuePair<string, int> dict in collection.OrderByDescending(key => key.Value).Take(5))
            {
                Console.WriteLine("{0} - {1}", dict.Key, dict.Value);
            }
        }
        public static void welcomeScreen()
        {
            Console.WriteLine("Welcome to Maths Quiz Game)\nSelect an Option\n1. Take Quiz \n2. View Top Scores \n3. Exit");
           // Thread.Sleep(10000);//adds a 20 seconds delay before the next operation to give the user time to read the instructions
          //  Console.Clear(); //clears the screen before starting the test
        }
        public static int option()
        {
            int number;
            do
            {
                number = optionFeed();
            }
            while (number <= 0 || number > 3);
            if (number > 3 || number <= 0)
            {
                Console.WriteLine("invalid input, try again");
                Console.Write("choose a valid option: ");
            }
            return number;
        }
        public static int optionFeed()
        {
            Console.Write("option: ");
            int choice;
            int.TryParse(Console.ReadLine(), out choice);
            return choice;
        }


        // Create a Timer object that knows to call our TimerCallback
        // method once every 2000 milliseconds.
        Timer t = new Timer(TimerCallback, null, 0, 2000);

        private static void TimerCallback(Object o)
        {
            // Display the date/time when this method got called.
            Console.WriteLine("In TimerCallback: " + DateTime.Now);
        }

      

    }



}
