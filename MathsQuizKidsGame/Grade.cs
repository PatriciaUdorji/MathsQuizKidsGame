using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;       
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MathsQuizKidsGame
{
    
    internal class Grade
    {
        enum scoreGrade
        {
            fail, pass, credit, distinction
        }


        
        public static int nameScore()
        {
            int playerScore = 1;
            Dictionary<string, int> namescore = FilesDepository.loadStudentNameAndScore();
            for (int i=1; i<namescore.Count; i++)       
            {
                playerScore = namescore.ElementAt(i).Value;
            }
            return playerScore;
        }



    public static double totalPoint()
        {
            int scorePoint = 20;
            int Totalscore = Grade.nameScore();
            int Totalpoint = Totalscore * scorePoint;
            return Totalpoint;
            
        }

        public static double totalGrade()
        {
            int scorePoint = 20;
            int numberOFQuestion = 5;
            double totalGradePercentage  =( totalPoint()/(numberOFQuestion*scorePoint) )*100;
            return totalGradePercentage;

        }

       


    }



}
