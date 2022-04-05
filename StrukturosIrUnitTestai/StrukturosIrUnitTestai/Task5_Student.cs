using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrukturosIrUnitTestai
{
    public struct Task5_Student
    {
        public static double AnnualGrade;
        public List<double> Semester1;
        public List<double> Semester2;
        public List<double> Semester3;

       
        public Task5_Student(List<double> semester1, List<double> semester2, List<double> semester3)
        {
            Semester1 = semester1;
            Semester2 = semester2;
            Semester3 = semester3;          
        }

        public static double GetAnnualGrade()
        {
            double annGrade = (GetSemesterAwg(MethodCreator.CreateRandomGrades()) + GetSemesterAwg(MethodCreator.CreateRandomGrades()) + GetSemesterAwg(MethodCreator.CreateRandomGrades())) / 3d;
            return Math.Round(annGrade, 2);         

        }
        public static double GetSemesterAwg(List<double> semester)
        {
          return  Math.Round(semester.Sum() / semester.Count(), 2) ;
        }



    }
}
