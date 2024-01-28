using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    public class Rectangle
    {
        protected int width;
        protected int height;

        public virtual void SetWidth(int width)
        {
            this.width = width;
        }

        public virtual void SetHeight(int height)
        {
            this.height = height;
        }

        public int Area()
        {
            return this.width * this.height;
        }
    }

    public class Square : Rectangle
    {
        public override void SetWidth(int width)
        {
            base.SetWidth(width);
            base.SetHeight(width);
        }

        public override void SetHeight(int height)
        {
            base.SetWidth(height);
            base.SetHeight(height);
        }
    }
}
