using PersonsConsoleProgram.Models;
using System;

namespace MyApp
{
    internal class Program
    {
        static public List<Person> Persons = new List<Person>();
        static void AddPerson()
        {
            Console.Write("Név: ");
            string name = Console.ReadLine();

            Console.Write("Kor");
            int age = Convert.ToInt32(Console.ReadLine());

            Person p = new Person(name, age);
            Persons.Add(p);

        }

        static void ListPersons()
        {
            foreach (Person p in Persons)
            {
                Console.WriteLine(p);
            }
        }

        static void SaveToCsv()
        {
            File.WriteAllText("emberek.csv", string.Join("\n", Persons));
        }

        static void LoadFromCsv()
        {
            var sorok = File.ReadAllLines("emberek.csv");
            foreach (var s in sorok)
            {
                Persons.Add(new Person(s));

                //Console.WriteLine(s);
            }
        }
        static void Main(string[] args)
        {
            Person p = new Person("Andi", 100);
            Console.WriteLine(p);
            LoadFromCsv();
            AddPerson();
           // AddPerson();
           ListPersons();
          // SaveToCsv();
        }
    }
}