using System;
using System.Collections.Generic;
using System.Text;

namespace chividientich
{
    class Rectangle
    {
        double width, height;

        public Rectangle()
        {
        }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double Dientich()
        {
            return this.width * this.height;
        }

        public double Chuvi()
        {
            return (this.width + this.height) * 2;
        }

        public string Display()
        {
            return   "width=" + width + ", height=" + height;
        }
    }
}

