using OOP4.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Services
{
    public class TeacherService : IPersonService<Teacher>
    {
        private int count;
        private List<Teacher> teachers;

        public TeacherService()
        {
            this.teachers = new List<Teacher>();
        }

        public List<Teacher> GetAll()
        {
            return teachers;
        }

        public void Create(string name, int age)
        {
            Teacher teacher = new Teacher(name, age, "SomeDegree");
            count++;
            teachers.Add(teacher);
        }

        public void SortByFIO()
        {
            PersonComparator<Teacher> personComparator = new PersonComparator<Teacher>();
            teachers.Sort(personComparator);
        }

        // Метод вывода списка учителей
        public void PrintTeachers()
        {
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"Name: {teacher.GetName()}, Age: {teacher.GetAge()}, Degree: {teacher.AcadDegree}");
            }
        }
    }
}
