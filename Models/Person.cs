using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsConsoleProgram.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age {  get; set; }

        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
         
        public Person(string sor)
        {
            var adatok = sor.Split(";");
            //Id = Convert.ToInt32(adatok[0]);
            Name = adatok[1];
            Age = Convert.ToInt32(adatok[2]);
        }

        public Person()
        {
        }

        public override string? ToString()
        {
            return $"{Id};{Name};{Age}";
        }
    }
}
