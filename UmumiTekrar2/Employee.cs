using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmumiTekrar2
{
    internal class Employee : Human
    {
        public double Salary { get; set; }
        public string Position { get; set; }

        public Employee(string fullName, int age, double salary, string position)
        {
            FullName = fullName;
            Age = age;
            Salary = salary;
            Position = position;
        }

        public void empInfo()
        {
            Console.WriteLine($"Ad Soyad - {FullName}, " +
                $"Yash - {Age}, " +
                $"Maash - {Salary}, " +
                $"Pozisiya - {Position}.");
        }
    }
}
