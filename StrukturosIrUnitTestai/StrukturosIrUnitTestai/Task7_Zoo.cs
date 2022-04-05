using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StrukturosIrUnitTestai
{
    public struct Task7_Zoo
    {
        public string ZooName;
        public string Address;
        public List<Task7_Animal> AnimalList;

        public Task7_Zoo(string zooName, string address, List<Task7_Animal> animalList)
        {
            ZooName = zooName;
            Address = address;
            AnimalList = animalList;
        }

        public List<Task7_Animal> CreateAnimalsList()
        {
            AnimalList = new List<Task7_Animal>();
            string path = @"C:\Users\nerki\Documents\C# .Net kursai\animals.txt";           
            string[] lines = File.ReadAllLines(path);          
                        
            for (int i = 0; i < 100; i++)
            {                
                AnimalList.Add(new Task7_Animal(ID_Generator.GetID(), lines[MethodCreator.random.Next(0, lines.Length - 1)]));
            }
            return AnimalList;

        }

        public void CountAnimals()
        {

            Console.WriteLine($"Viso gyvunu yra {AnimalList.Count}");
            var query = AnimalList.GroupBy(x => x.Species).Select(y => new { Species = y.Key, Counter = y.Count() }).ToList();
            foreach (var item in query)
            {
                Console.WriteLine($"{item.Species} viso yra {item.Counter}");
            }
            Console.WriteLine();


           // Isskaidom ir  sudedam kiekviena rusi

            List<string> species = new List<string>();
            List<int> count = new List<int>();

            for (int i = 0; i < AnimalList.Count; i++)
            {

                if (species.Contains(AnimalList[i].Species))
                {
                    count[species.IndexOf(AnimalList[i].Species)]++;

                }
                else
                {
                    species.Add(AnimalList[i].Species);
                    count.Add(1);
                }
            }
            for (int i = 0; i < species.Count; i++)
            {
                Console.WriteLine($"{species[i]} yra {count[i]} vnt. ");
            }

        }
    }
}
