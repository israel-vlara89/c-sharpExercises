using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4Structs
{
    public struct Complex
    {
        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
    public double Real { get; set; }
    public double Imaginary { get; set; }
    
    public static Complex operator +(Complex complex1, Complex complex2)
    {
        Complex complexSum = new Complex();
        complexSum.Real = complex1.Real + complex2.Real;
        complexSum.Imaginary = complex1.Imaginary + complex2.Imaginary;
        return complexSum;
    }
    public static implicit operator Complex(double dbl)
    {
        Complex cmplx = new Complex();
        cmplx.Real = dbl;
        return cmplx;    
    }
    //This is not a safe operation 
    public static explicit operator double(Complex cmplx)
    {
        return cmplx.Real;
    }
        static void Main(string[] args)
        {
            Complex complex1 = new Complex();
            complex1.Real = 3;
            complex1.Imaginary = 1;

            Complex complex2 = new Complex(7, 5);

            Complex complexSum = complex1 + complex2;

            Console.WriteLine($"Complex sum - Real: {complexSum.Real}, " +
                $"Imaginary: {complexSum.Imaginary}");

            Complex complex3 = 9;
            double realPart = (double)complex3;


            Console.ReadKey();
        }
    }
}
