using System;
using System.Collections.Generic;
using System.Linq;

namespace StrukturosIrUnitTestai
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            #region STRUCTS

            //// be konstruktoriaus
            //Person person;
            //person.Name = "Nerijus";
            //person.Lastname = "Marcinkenas";
            //person.Age = 27;
            //person.SayMyFullName();
            //Person person1;
            //person1.Name = "Samurajus";
            //person1.Lastname = "Aloyzas";
            //person1.Age = 45;
            //person1.SayMyFullName();

            //// su konstruktoriumi

            //Person person2 = new Person("Alis", "Sake", 10);
            //person2.SayMyFullName();

            //StudentGradesNoCnstr();
            //StudentGradesWithCnstr();
            #endregion

            Program uzduotis = new Program();
            do
            {
                Console.WriteLine("Pasirink uzduoti: 1 - 7");
                int select = (int)GetNumber();

                switch (select)
                {
                    case 1:
                        Console.Clear();
                        uzduotis.Uzduotis_1();
                        break;
                    case 2:
                        Console.Clear();
                        uzduotis.Uzduotis_2();
                        break;
                    case 3:
                        Console.Clear();
                        uzduotis.Uzduotis_3();
                        break;
                    case 4:
                        Console.Clear();
                        uzduotis.Uzduotis_4();
                        break;
                    case 5:
                        Console.Clear();
                        uzduotis.Uzduotis_5();
                        break;
                    case 6:
                        Console.Clear();
                        uzduotis.Uzduotis_6();
                        break;
                    case 7:
                        Console.Clear();
                        uzduotis.Uzduotis_7();
                        break;
                    case 8:
                        uzduotis.Uzduotis_8();
                        break;

                }

            } while (true);

          
           
            
            

        }

        public static void StudentGradesNoCnstr()
        {

            Student student;
            student.Name = "Saule";
            student.Grade1 = 8;
            student.Grade2 = 9;
            student.Grade3 = 5;       
            
            double awg = student.GetAvgGrade();
            Console.WriteLine($"{student.Name} vidurkis yra: {awg}");


        }
        public static void StudentGradesWithCnstr()
        {
            Student student = new Student("algis", 8, 9, 10);    
            double awg = student.GetAvgGrade();
            Console.WriteLine($"{student.Name} vidurkis yra: {awg}");
        }

        #region Unit Tests

        public static decimal CalculateTax(decimal income)
        {
            decimal result = 0;
            if (income <= 40000)
            {
                result = income * 0.05m;
            }
            else if (income > 40000 && income <= 100000)
            {
                result = income * 0.15m;
            }
            else
            {
                result = income * 0.25m;
            }
            return result;

        }


        #endregion

        public void Uzduotis_1()
        {
            DateTime courseStart = new DateTime(2022, 03, 01).Date;            
            DateTime courseEnd = new DateTime(2022, 11, 20).Date;
            DateTime now = DateTime.Now.Date;
            
            

            Task1_Student student;
            student.Name = "Nerijus";
            student.Lastname = "Marcinkenas";            
            student.CourseStart = courseStart;
            student.CourseEnd = courseEnd;
            student.Now = now;

            student.GetInfo();

        }
        public void Uzduotis_2()
        {
           
        
           Console.WriteLine("Koks jusu vardas");
           string input = Console.ReadLine();
           Console.WriteLine("Kada paimete knyga?");
         
           if (!DateTime.TryParse(Console.ReadLine(), out DateTime date))
           {
               Console.WriteLine("neteisingai ivesta data. Formatas yra: (yyyy,mm,dd)");
           }
           else
           {

               Task2_Book bookInfo = new Task2_Book(0001, "Sherlock Holmes", input, date.Date);
               TimeSpan totalDays = bookInfo.GetDays(date.Date);

               Console.WriteLine($"{bookInfo.Tittle} knyga, paimta pries {totalDays.Days} Dienu ");
           }
            
                

           

        }
        public void Uzduotis_3()
        {
            Console.WriteLine("Iveskite ilgi");
            double length = GetNumber();
            Console.WriteLine("Iveskite ploti");
            double width = GetNumber();

            Rectangle ractangle1 = new Rectangle("R1", length, width);
            Rectangle ractangle2 = new Rectangle("R2", length*2d, width*2d);
            Rectangle ractangle3 = new Rectangle("R3", length+3d, width-3d);

           double r1 = ractangle1.GetArea(length, width);
           double r2 = ractangle2.GetArea(length, width);
           double r3 = ractangle3.GetArea(length, width);
            Console.WriteLine($"{ractangle1.RactangleName} > Plotas yra = {r1}\n{ractangle2.RactangleName} > Plotas yra = {r2}\n{ractangle3.RactangleName} > Plotas yra = {r3}\n" );
        }
        public void Uzduotis_4()
        {
            Console.WriteLine("Iveskite studentu numerius (5 studentai)");
            List<Task4_Student> students = new List<Task4_Student>()
            {
                new Task4_Student(GetStudentID(), TellStudentPassed()),
                new Task4_Student(GetStudentID(), TellStudentPassed()),
                new Task4_Student(GetStudentID(), TellStudentPassed()),
                new Task4_Student(GetStudentID(), TellStudentPassed()),
                new Task4_Student(GetStudentID(), TellStudentPassed()),
            };

            Console.WriteLine(String.Join(" \n", students.Select(e => $"{e.StudentID} {e.Result}")).ToArray());

        }
        public void Uzduotis_5()
        {
            Task5_Student annualGrade = new Task5_Student(MethodCreator.CreateRandomGrades(), MethodCreator.CreateRandomGrades(), MethodCreator.CreateRandomGrades());
            string ID =  ID_Generator.GetID();
            Console.WriteLine(ID);
            string text = " Vidurkis ";
            
            Console.WriteLine("1 Semestras " + string.Join("; ",annualGrade.Semester1) + text + Task5_Student.GetSemesterAwg(annualGrade.Semester1));
            Console.WriteLine("2 Semestras " + string.Join("; ", annualGrade.Semester2) + text + Task5_Student.GetSemesterAwg(annualGrade.Semester2));
            Console.WriteLine("3 Semestras " + string.Join("; ", annualGrade.Semester3) + text + Task5_Student.GetSemesterAwg(annualGrade.Semester3));
            Console.WriteLine("Metinis vidurkis " + Task5_Student.GetAnnualGrade());


        }
        public void Uzduotis_6()
        {
            List<Task6_Voter> VoterList = new List<Task6_Voter>();
            //Task6_Voter voteriss = new Task6_Voter(ID_Generator.GetID(), MethodCreator.GetVoterVoted());
            
            for (int i = 0; i < 11; i++)
            {
                VoterList.Add(new Task6_Voter(ID_Generator.GetID(), MethodCreator.GetVoterVoted()));
            }
            
            foreach (var voteris in VoterList)
            {
                Console.WriteLine($"Balsuotojas: {voteris.Id},{MethodCreator.DarArJau()}balsavo.");
            }

        }
        public void Uzduotis_7()
        {
            Console.Clear();

            Task7_Zoo zooPark = new Task7_Zoo();
            List < Task7_Animal > animals = zooPark.CreateAnimalsList();

            Task7_Zoo zoo = new Task7_Zoo("NerijausZOO", "gyvunu g. 7, Nerijuliskes", animals);
            Console.WriteLine($"{zoo.ZooName}, {zoo.Address}");
            zooPark.CountAnimals();

            //foreach (var item in animals)
            //{
            //    Console.WriteLine($"{item.Id} yra {item.Species}");
            //}         
            

        }
        public void Uzduotis_8()
        {
            Task8_Accounting acc = new Task8_Accounting();
            acc.Receipt = CreateReceipts();
            acc.AllReceiptSum();



        }

        public static List<Task8_Receipt> CreateReceipts()
        {
            List <Task8_Receipt>Receipt = new List<Task8_Receipt>();
            Random randomCash = new Random();

            for (int i = 0; i < 100; i++)
            {
                Receipt.Add(new Task8_Receipt(ID_Generator.GetID(), randomCash.Next(1, 100) / randomCash.NextDouble()));
            }
            return Receipt;

        }



        public static int GetStudentID()
        {               
            
            return (int)GetNumber();
        }
        public bool GetStudentPassed()
        {
            
            Console.Write("Student grade:");
            int grade = (int)GetNumber();
            return grade >= 5;      
        }
        public string TellStudentPassed()
        {
            bool passed = GetStudentPassed();
            if (!passed)
            {
                return "Sorry, you not passed"; 
            }
            return "Congrats, you passed";

        }        
        public static double GetNumber()
        {
            double number;
            bool correct;

            do
            {
                string input = Console.ReadLine();
                if (!double.TryParse(input, out number))
                {
                    Console.WriteLine("Neteisingai ivestas skaicius");
                    correct = false;
                }
                else
                {
                    correct = true;
                }
            } while (!correct);
           return number;



        }

        public static bool OddOrEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



    }
}
