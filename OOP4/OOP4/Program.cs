using OOP4.Controllers;
using OOP4.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Иван", 25);
            Student s2 = new Student("Игорь", 23);
            Student s3 = new Student("Иван", 22);
            Student s4 = new Student("Игорь", 23);
            Student s5 = new Student("Даша", 23);
            Student s6 = new Student("Лена", 23);

            List<Student> listStud = new List<Student>
            {
                s1, s2, s3, s4, s5, s6
            };

            StudentGroup group4580 = new StudentGroup(listStud, 4580);
            Console.WriteLine(group4580);

            foreach (Student std in group4580)
            {
                Console.WriteLine(std);
            }

            Console.WriteLine("=========================================================");

            listStud.Sort();

            foreach (Student std in listStud)
            {
                Console.WriteLine(std);
            }

            Teacher t1 = new Teacher("Галина", 55, "Docent");
            Teacher t2 = new Teacher("Татьяна", 57, "Docent");

            Console.WriteLine(new PersonComparator<Student>().Compare(s1, s3));

            // AccountController controller = new AccountController();
            // controller.PaySalary(t1, 50000);
            // controller.PaySalary(s1, 50000);

            AccountController.PaySalary(t1, 50000);

            Console.WriteLine(AccountController.AverageAge(listStud));

            List<Student> students = new List<Student>
            {
                s1, s2, s3, s4, s5, s6
            };

            List<Teacher> teachers = new List<Teacher>
            {
                t1, t2
            };

            // Реализация 2 задания
            List<Employee> employees = new List<Employee>();

            double avgStudentAge = AccountController.AverageAge(students);
            double avgTeacherAge = AccountController.AverageAge(teachers);
            double avgEmployeeAge = AccountController.AverageAge(employees);

            Console.WriteLine($"Average Student Age: {avgStudentAge}");
            Console.WriteLine($"Average Teacher Age: {avgTeacherAge}");
            Console.WriteLine($"Average Employee Age: {avgEmployeeAge}");
        }
    }
}
