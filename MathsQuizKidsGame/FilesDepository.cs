using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MathsQuizKidsGame
{
    internal class FilesDepository

    {
        private static string[] questionExtractor;
        private static string[] answerCreate;
        private static string[] config;
        private static Dictionary<string, int> studentAndScores = loadStudentNameAndScore();

        public static string[] questionsInFile()
        {
            if (configFileExtractor() == 1)
            {
                questionExtractor = File.ReadAllLines("questions.txt");
            }
            else if (configFileExtractor() == 2)
            {
                questionExtractor = File.ReadAllLines("multiplechoicequestions.txt");
            }
            
            return questionExtractor;
        }
        public static string[] answerDeriver()
        {
            if (configFileExtractor() == 1)
            {
                answerCreate = File.ReadAllLines("answers.txt");
            }
            else if (configFileExtractor() == 2)
            {
                answerCreate = File.ReadAllLines("Multiplechoiceanswers.txt");
            }
            
            return answerCreate;
        }
        public static void studentName(int score)
        {
            Console.WriteLine("input your name");
            string name = Console.ReadLine();
            studentAndScores.Add(name, score);
        }

        public static Dictionary<string, int> merge()
        {
            studentAndScores = loadStudentNameAndScore();
            return studentAndScores;

        }
        public static void saveStudentNameAndScore()
        {
            BinaryFormatter bf = new BinaryFormatter();
            string nameOfFile = "studentNameAndScore.bin";
            FileStream file = File.Create(nameOfFile);

            bf.Serialize(file, studentAndScores);
            file.Close();
        }
        public static Dictionary<string, int> loadStudentNameAndScore()
        {
            Dictionary<string, int> studentLog = new Dictionary<string, int>();
            BinaryFormatter bf = new BinaryFormatter();
            string nameOfFile = "studentNameAndScore.bin";
            FileStream file = File.OpenRead(nameOfFile);
            studentLog = (Dictionary<string, int>)(bf.Deserialize(file));
            file.Close();
            return studentLog;
        }

        public static int configFileExtractor()
        {
            config = File.ReadAllLines("difficultyConfigFile.txt");
            string [] elements = config[0].Split(' ');
            int difficultyInteger = int.Parse(elements.Last());
            return difficultyInteger;
        }



    }


}
