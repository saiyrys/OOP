using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    public interface IEngine
    {
        void Start();
    }

    // Class representing the car
    public class Car_Task5
    {
        private IEngine engine;

        public Car_Task5(IEngine engine)
        {
            this.engine = engine;
        }

        public void Start()
        {
            this.engine.Start();
        }
    }
    public class PetrolEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Бензиновый двигатель запущен");
        }
    }
    public class DieselEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Дизельный двигатель запущен");
        }
    }
}
