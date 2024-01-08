using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Domain
{
    public class StudentIterator : IEnumerator<Student>
    {
        private int counter;
        private readonly List<Student> students;

        public StudentIterator(List<Student> students)
        {
            this.students = students;
            this.counter = -1;
        }

        public Student Current
        {
            get
            {
                if (counter >= 0 && counter < students.Count)
                    return students[counter];
                throw new InvalidOperationException();
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            // Ресурсы освобождаются, если необходимо
        }

        public bool MoveNext()
        {
            counter++;
            return counter < students.Count;
        }

        public void Reset()
        {
            counter = -1;
        }
    }
}
