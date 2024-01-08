using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Domain
{
    public class Employee : Person
    {
        private string special;

        public Employee(string firstName, int age,  string special) : base(firstName, age)
        {
            this.special = special;
        }
    }
}
