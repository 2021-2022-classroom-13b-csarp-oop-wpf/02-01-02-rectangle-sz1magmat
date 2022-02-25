using System;

namespace RectangleProject.Models
{
    public class Rectangle
    {
        private double sideA, sideB;
        public Rectangle(double sideA, double sideB)
        {
            if (sideA <= 0 || sideB <= 0) throw new RectangleSideIsNullOrZero("Nem lehet negatív vagy nulla oldal!");
            else
            {
                this.sideA = sideA;
                this.sideB = sideB;
            }
        }

        public double SideA
        {
            get => sideA;
            set
            {
                if (value <= 0) throw new RectangleSideIsNullOrZero("Nem lehet negatív vagy nulla oldal!");
                else sideA = value;
            }
        }
        public double SideB
        {
            get => sideB;
            set
            {
                if (value <= 0) throw new RectangleSideIsNullOrZero("Nem lehet negatív vagy nulla oldal!");
                else sideB = value;
            }
        }

        public double Area { get => sideA * sideB; }
        public double Perimeter { get => 2 * (sideA + sideB); }

        public override string ToString()
        { return $"A:{sideA}, B:{sideB}, Area:{Math.Round(Area, 2)}, Perimeter:{Math.Round(Perimeter, 2)}"; }
    }
}
