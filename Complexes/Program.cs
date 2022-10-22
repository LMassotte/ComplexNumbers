using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complexes
{
    class Program
    {
        static void Main(string[] args)
        {
            int reel1, imag1, reel2, imag2;
            Console.WriteLine("Real part of complex 1 :");
            reel1 = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Imaginary part of complex 1 :");
            imag1 = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Real part of complex 2 :");
            reel2 = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Imaginary part complex 2 :");
            imag2 = (int.Parse(Console.ReadLine()));

            ComplexNumber c1 = new ComplexNumber(reel1, imag1);
            ComplexNumber c2 = new ComplexNumber(reel2, imag2);

            Console.WriteLine("Complex 1: " + c1.realPart + "+" + c1.imaginaryPart + "i");
            Console.WriteLine("Complex 2: " + c2.realPart + "+" + c2.imaginaryPart + "i");

            ComplexNumber c3 = c1 + c2;
            ComplexNumber c4 = c1 - c2;
            ComplexNumber c5 = c1 * c2;
            ComplexNumber c6 = c1 / c2;

            Console.WriteLine("Complex 3 (c1 + c2): " + c3.realPart + "+" + c3.imaginaryPart + "i");
            Console.WriteLine("Complex 4 (c1 - c2): " + c4.realPart + "+" + c4.imaginaryPart + "i");
            Console.WriteLine("Complex 5 (c1 * c2): " + c5.realPart + "+" + c5.imaginaryPart + "i");
            Console.WriteLine("Complex 6 (c1 / c2): " + c6.realPart + "+" + c6.imaginaryPart + "i");

            Console.ReadLine();
        }
    }
}
