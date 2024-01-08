using OOP4.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Services
{
    public class EmployeeService : IPersonService<Employee>
    {
        private int count;
        private List<Employee> employees;

        public EmployeeService()
        {
            this.employees = new List<Employee>();
        }

        public List<Employee> GetAll()
        {
            return employees;
        }

        public void Create(string name, int age)
        {
            Employee employee = new Employee(name, age, "basic");
            count++;
            employees.Add(employee);
        }

        public void SortByFIO()
        {
            PersonComparator<Employee> personComparator = new PersonComparator<Employee>();
            employees.Sort(personComparator);
        }
    }
}
