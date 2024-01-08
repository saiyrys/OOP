using OOP4.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Services
{
    public class StudentService : IPersonService<Student>
    {
        private int count;
        private List<Student> students;

        public StudentService()
        {
            this.students = new List<Student>();
        }

        public List<Student> GetAll()
        {
            return students;
        }

        public void Create(string name, int age)
        {
            Student student = new Student(name, age);
            count++;
            students.Add(student);
        }

        public void SortByFIO()
        {
            PersonComparator<Student> personComparator = new PersonComparator<Student>();
            students.Sort(personComparator);
        }
    }
}
