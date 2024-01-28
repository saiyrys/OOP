using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    public interface IAreaShape
    {
        double Area();
    }
    public interface IVolumeShape
    {
        double Volume();
    }
    public class Circle : IAreaShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return 2 * Math.PI * radius;
        }
    }
    public class Cube : IAreaShape, IVolumeShape
    {
        private int edge;

        public Cube(int edge)
        {
            this.edge = edge;
        }

        public double Area()
        {
            return 6 * edge * edge;
        }

        public double Volume()
        {
            return edge * edge * edge;
        }
    }
}
