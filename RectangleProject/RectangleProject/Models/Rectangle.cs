using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleProject.Models
{
    public class Rectangle
    {
        private double sideA, sideB;
        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public double SideA
        {
            get => sideA;
            set => sideA = value;
        }
        public double SideB
        {
            get => sideB;
            set => sideB = value;
        }

        public double Area { get => sideA * sideB; }
        public double Perimeter { get => 2 * (sideA + sideB); }

        public override string ToString()
        { return $"A:{sideA}, B:{sideB}, Area:{Math.Round(Area, 2)}, Perimeter:{Math.Round(Perimeter, 2)}"; }
    }
}
