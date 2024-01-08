using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Domain
{
    public class StudentGroup : IComparable<StudentGroup>, IEnumerable<Student>
    {
        private List<Student> group;
        private int idGroup;

        public StudentGroup(List<Student> group, int idGroup)
        {
            this.group = group;
            this.idGroup = idGroup;
        }

        public List<Student> GetGroup()
        {
            return group;
        }

        public void SetGroup(List<Student> group)
        {
            this.group = group;
        }

        public int GetIdGroup()
        {
            return idGroup;
        }

        public void SetIdGroup(int idGroup)
        {
            this.idGroup = idGroup;
        }

        public override string ToString()
        {
            return $"StudentGroup{{group={group}, idGroup={idGroup}}}";
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return new StudentIterator(group);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(StudentGroup other)
        {
            return this.group.Count.CompareTo(other.group.Count);
        }
    }

    /*public class StudentIterator : IEnumerator<Student>
    {
        private List<Student> group;
        private int counter;

        public StudentIterator(List<Student> group)
        {
            this.group = group;
            this.counter = -1;
        }

        public Student Current
        {
            get
            {
                if (counter >= 0 && counter < group.Count)
                    return group[counter];
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
            return counter < group.Count;
        }

        public void Reset()
        {
            counter = -1;
        }*/
    }

