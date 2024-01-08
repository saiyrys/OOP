using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Services
{
    public interface IPersonService<T>
    {
        List<T> GetAll();
        void Create(string name, int age);
    }
}
