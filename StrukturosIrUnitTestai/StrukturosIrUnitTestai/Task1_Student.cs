using System;
using System.Collections.Generic;
using System.Text;

namespace StrukturosIrUnitTestai
{
    public struct Task1_Student
    {
        public string Name;
        public string Lastname;
        public DateTime CourseStart;
        public DateTime CourseEnd;
        public DateTime Now;
               

        public void GetInfo()
        {
            Console.WriteLine($"As esu: {Name} {Lastname}, ir as mokausi .Net nuo {CourseStart.ToString("yyyy-MM-dd")} iki {CourseEnd.ToString("yyyy-MM-dd")}");

            Console.WriteLine($"Liko mokytis: {(CourseEnd - Now).ToString("dd")}, dienos");

        }



    }
}
