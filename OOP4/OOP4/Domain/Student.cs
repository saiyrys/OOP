using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Domain
{
    public class Student : Person, IComparable<Student>
    {
        private int id;
        private static int generalId;

        public Student(string name, int age) : base(name, age)
        {
            this.id = generalId;
            generalId++;
        }

        public int GetId()
        {
            return id;
        }

        public override string ToString()
        {
            return $"Student [age={base.GetAge()}, name={base.GetName()}, id={id}]";
        }

        public int CompareTo(Student other)
        {
            Console.WriteLine($"{base.GetName()} - {other.GetName()}");

            if (base.GetAge() == other.GetAge())
            {
                if (id == other.GetId()) return 0;
                if (id > other.GetId()) return 1;
                else return -1;
            }

            if (base.GetAge() > other.GetAge())
                return 1;
            else
                return -1;
        }
    }
}
