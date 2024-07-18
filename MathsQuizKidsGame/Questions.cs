using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsQuizKidsGame
{
    internal class Questions
    {
       
        private static string[] questions = FilesDepository.questionsInFile();
        private static List<int> chosenRandomNumber = new List<int>();

        public static string questionExtractor(int chosenNumber)
        {
            chosenRandomNumber.Add(chosenNumber);
            return questions[chosenNumber];
        }
        public static List<int> returnChosenNumber()
        {
            return chosenRandomNumber;
        }
    }
}
