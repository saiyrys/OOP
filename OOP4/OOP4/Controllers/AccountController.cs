using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP4.Domain;

namespace OOP4.Controllers
{
    public class AccountController
    {

        public static void PaySalary<T>(T person, int salary) where T : Teacher
        {
            Console.WriteLine($"{person.GetName()} выплачено зарплата {salary}р.");
        }

        // Заготовка для метода AverageAge
        public static double AverageAge<T>(List<T> persons) where T : Person
        {
            if (persons.Count == 0)
                return 0.0;

            int totalAge = 0;
            foreach (var person in persons)
            {
                totalAge += person.GetAge();
            }

            return (double)totalAge / persons.Count;
        }
    }
}
