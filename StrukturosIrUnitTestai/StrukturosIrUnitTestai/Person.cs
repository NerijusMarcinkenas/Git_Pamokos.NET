using System;
using System.Collections.Generic;
using System.Text;

namespace StrukturosIrUnitTestai
{

    public struct Person
    {
        public string Name;
        public string Lastname;
        public int Age;

        public Person(string name, string lastname, int age)
        {
            Name = name;
            Lastname = lastname;
            Age = age;
        }             

        public void SayMyFullName()
        {
            Console.WriteLine($"My anem is: {Name}, and my lastname is: {Lastname}");

        }


    }
}
