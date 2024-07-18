using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MathsQuizKidsGame
{
  
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            int chosenIndex;
            string answerConfirmer;
            string[] answerGen = FilesDepository.answerDeriver();
            int numberOFQuestion = 0;
            int score = 0;

            Display.welcomeScreen();
            
        int choice = Display.option();
            if ( choice == 1)
            {
                do
                {
                    chosenIndex = random.Next(0, answerGen.Length);

                    if (!Questions.returnChosenNumber().Contains(chosenIndex))
                    {
                        Console.WriteLine(Questions.questionExtractor(chosenIndex));
                        string answerFromFile = answerGen[chosenIndex].ToLower();
                        string[] answerLine = answerFromFile.Split(' ');
                        answerConfirmer = Console.ReadLine().ToLower();

                        if (answerLine.Contains(answerConfirmer))
                        {
                            Console.WriteLine("Correct! 20 Point");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("Your answer is incorrect");
                        }
                        numberOFQuestion++;
                    }
                    else
                    {
                        continue;
                    }
                }
                while (numberOFQuestion <= 4);

                    try
                        {
                            
                            Display.storeStudentsAndScoresDetails(score, numberOFQuestion);
                        }

                    catch (System.ArgumentException)
                    {
                        Console.WriteLine("Name Already Exist, Kindly use a different name");
                    }

                Console.WriteLine("Your Total Point is " + Grade.totalGrade() + "%");

                if(Grade.totalGrade()<39)
                {
                    Console.WriteLine("Grade - Fail");
                }
                else if(Grade.totalGrade()>=40 && Grade.totalGrade()<50)
                {
                    Console.WriteLine("Grade - Pass");
                }
                else if (Grade.totalGrade() >= 50 && Grade.totalGrade() < 70)
                {
                    Console.WriteLine("Grade - Credit");
                }

                else if (Grade.totalGrade() >= 70 && Grade.totalGrade() < 101)
                {
                    Console.WriteLine("Grade - Distinction");
                }

            }
            else if (choice == 2)
            {
                Display.displayStudentsAndScores();
            }
            else if (choice == 3)
            {
                Console.WriteLine("Quiting...");
            }
            
            




        }
    }
}
