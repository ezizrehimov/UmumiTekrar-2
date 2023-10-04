using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmumiTekrar2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("Ford", "Mustang", 20, 200);
            car.AddFuel(100);

            Console.WriteLine(" = = = = = = = = = ");

            int empCount;
            string empCountStr;
            Console.WriteLine("Isci sayini daxil edin: ");

            do
            {
                empCountStr = Console.ReadLine();
            } while (!int.TryParse(empCountStr, out empCount));

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < empCount; i++)
            {
                Console.Write($"Isci {i + 1} Ad ve Soyad elave edin: ");
                string fullName = Console.ReadLine();


                int age;
                string ageStr;
                do
                {
                    Console.Write("Yash elave edin: ");

                    ageStr = Console.ReadLine();
                } while (!int.TryParse(ageStr, out age));


                double salary;
                string salaryStr;
                do
                {
                    Console.Write("Maash elave edin: ");
                    salaryStr = Console.ReadLine();
                } while (!double.TryParse(salaryStr, out salary));


                Console.Write("Pozisiya: ");
                string position = Console.ReadLine();
                employees.Add(new Employee(fullName, age, salary, position));
            }

            /* burda 2 shertdir. check edir ki,
             1 ve ya 0 dan basqa nese daxil etse, tekrar daxil etmeyini istesin.
             ve elece yalniz reqem daxil etmeyini check edir. */
            int reply;
            string replyStr;
            do
            {
                Console.Write("Filter elemek isteyirsen? (1/0) 1- he , 0 - yox: ");
                replyStr = Console.ReadLine();

            } while (!int.TryParse(replyStr, out reply) || (reply != 1 && reply != 0));


            if (reply == 1)
            {
                Console.Write("Filter metnini daxil edin: ");
                string filterTxt = Console.ReadLine();
                List<Employee> filteredEmployees = employees.FindAll(employee => employee.FullName.Contains(filterTxt));

                Console.WriteLine("Filter edilmish isciler: ");
                foreach (var item in filteredEmployees)
                {
                    item.empInfo();
                }
            }
            if (reply == 0)
            {
                Console.WriteLine("Butun isciler: ");
                foreach (var item in employees)
                {
                    item.empInfo();
                }
            }


        }
    }
}
