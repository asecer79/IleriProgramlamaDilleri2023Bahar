using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12
{
    public class Complex
    {
        private Complex() { }
        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        private double Real { get; init; }
        private double Imaginary { get; init; }

        public static Complex operator +(Complex a, Complex b)
        {

            return new Complex()
            {
                Real = a.Real + b.Real,
                Imaginary = a.Imaginary + b.Imaginary
            };
        }

        public static Complex operator +(double a, Complex b)
        {

            return new Complex()
            {
               Real = b.Real+a,
            };
        }

        public static Complex operator +(Complex a, double b)
        {

            return new Complex()
            {
                Real = a.Real + b,
            };
        }

        public static Complex operator -(Complex a, Complex b)
        {

            return new Complex()
            {
                Real = a.Real - b.Real,
                Imaginary = a.Imaginary - b.Imaginary
            };
        }
        public static Complex operator -(double a, Complex b)
        {

            return new Complex()
            {
                Real = b.Real - a,
            };
        }

        public static Complex operator -(Complex a, double b)
        {

            return new Complex()
            {
                Real = a.Real - b,
            };
        }

        public static Complex operator *(Complex a, Complex b)
            => new Complex(a.Real * b.Real - a.Imaginary * b.Imaginary,
                a.Real * b.Imaginary + a.Imaginary * b.Real);

        public static Complex operator *(double a, Complex b)
        {

            return new Complex()
            {
                Real = b.Real*a,
                Imaginary =b.Imaginary*a
            };
        }

        public static Complex operator *(Complex a, double b)
        {
            return new Complex()
            {
                Real = a.Real * b,
                Imaginary = a.Imaginary * b
            };
        }


        public static Complex operator /(Complex a, Complex b)
        {
            double real = (a.Real * b.Real + a.Imaginary * b.Imaginary) / (b.Real * b.Real + b.Imaginary * b.Imaginary);
            double imaginary = (a.Imaginary * b.Real - a.Real * b.Imaginary) / (b.Real * b.Real + b.Imaginary * b.Imaginary);

            return new Complex(real, imaginary);
        }


        public static bool operator ==(Complex a, Complex b)
        {
            return a.Real==b.Real && a.Imaginary==b.Imaginary;
        }
        public static bool operator !=(Complex a, Complex b)
        {
            return !(a == b);
        }

        //"(2,3)" =----> 2+3i

        private double x = 2;

        private int xx = (int)2.5;



        public static explicit operator Complex(string c)   //var c = (Complex)"(3,2)";
        {
            c = c.Replace(" ", "");
            c = c.Replace("(", "").Replace(")", "");
            double real =Convert.ToDouble(c.Split(",")[0]);
            double imaginary = Convert.ToDouble(c.Split(",")[1]);

            return new Complex(real, imaginary);
        }

        public static implicit operator Complex(double d)   //Complex c = 23;
        {
            return new Complex(d, 0);
        }


        public override string ToString()
        {
            if (Imaginary == 0)
            {
                return $"{Real}";
            }
            else if (Real == 0)
            {
                return $"{Imaginary}i";
            }
            else if (Imaginary < 0)
            {
                return $"{Real}{Imaginary}i";
            }

            return $"{Real} + {Imaginary}i";
        }
    }
}
