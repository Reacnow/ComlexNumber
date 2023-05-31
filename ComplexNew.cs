using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComlexNumber
{
    internal class ComplexNew
    {
        private double r, i;
        private static uint Counter;

        public ComplexNew()
        {
            r = 0;
            i = 0;
            Counter++;
        }
        public ComplexNew(double Re, double Im)
        {
            r = Re; i = Im;
            Counter++;
        }
        public ComplexNew(ComplexNew c)
        {
            r = c.r; i = c.i; Counter++;
        }
        ~ComplexNew()
        {
            Counter--;
        }
        public double Abs()
        {
            return Math.Sqrt(r * r + i * i);
        }
        public static ComplexNew operator +(ComplexNew c1, ComplexNew c2)
        {
            return new ComplexNew(c1.r + c2.r, c1.i + c2.i);
        }
        public void PrintComp()
        {
            Console.WriteLine(" Комплексное число {0:0.0} + {1:0.0}i", r, i);
        }
        public static uint HowMany()
        {
            return Counter;
        }
    }
}
