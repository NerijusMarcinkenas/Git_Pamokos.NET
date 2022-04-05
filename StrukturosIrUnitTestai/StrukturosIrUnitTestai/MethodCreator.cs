using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrukturosIrUnitTestai
{
    public class MethodCreator
    {
        

        public static Random random = new Random();
        public static List<double> CreateRandomGrades()
        {
            List<double> fillSemesterGrades = new List<double>();
            for (int i = 0; i < 13; i++)
            {
                fillSemesterGrades.Add(random.Next(1, 11));                
            }
            return fillSemesterGrades;

        }
        public static bool GetVoterVoted()
        {
            double odds = 0.47;
            double randomDouble = MethodCreator.random.NextDouble();
            return odds > randomDouble;


        }

        public static string DarArJau()
        {
            if (GetVoterVoted())
            {
                return " jau ";
            }
            else
            {
                return " dar ne";
            }

        }

        //public static List<Task6_Voter> 


    }
}
