using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    public class Employee
    {
        private string name;
        private DateTime dob;
        private int baseSalary;

        public Employee(string name, DateTime dob, int baseSalary)
        {
            this.name = name;
            this.dob = dob;
            this.baseSalary = baseSalary;
        }

        public string GetEmpInfo()
        {
            return "Имя - " + name + " , Дата Рождения - " + dob.ToString();
        }

        public class SalaryCalculator
        {
            public int CalculateNetSalary(int baseSalary)
            {
                int tax = (int)(baseSalary * 0.25); 
                return baseSalary - tax;
            }
        }

    }
}
