using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Domain
{
    public class Teacher : Person
    {
        public string AcadDegree { get; }

        public Teacher(string firstName, int age, string acadDegree) : base(firstName, age)
        {
            AcadDegree = acadDegree;
        }
    }
}
