using System;
using System.Collections.Generic;
using System.Text;

namespace StrukturosIrUnitTestai
{

    public struct Student
    {
        public string Name;
        public int Grade1;
        public int Grade2;
        public int Grade3;

       


        public Student(string name, int grade1, int grade2, int grade3)
        {
            Name = name;
            Grade1 = grade1;
            Grade2 = grade2;
            Grade3 = grade3;
        }


        public  double GetAvgGrade()
        {
           
            double awg = (Grade1 + Grade2 + Grade3) / 3;
            return awg;
            
        }


    }
   

}
