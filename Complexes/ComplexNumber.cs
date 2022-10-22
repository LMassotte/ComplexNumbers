using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complexes
{
    class ComplexNumber
    {
        #region Attributes
        public int realPart;
        public int imaginaryPart;
        #endregion

        #region Constructeurs
        public ComplexNumber(int realPart, int imaginaryPart)
        {
            this.realPart = realPart;
            this.imaginaryPart = imaginaryPart;
        }

        public ComplexNumber()
        {

        }
        #endregion

        #region Méthodes

        public static ComplexNumber Conjugate(ComplexNumber a)
        {
            return new ComplexNumber(a.realPart, -(a.imaginaryPart));
        }
        public static ComplexNumber operator + (ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.realPart + b.realPart, a.imaginaryPart + b.imaginaryPart);
        }

        public static ComplexNumber operator - (ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.realPart - b.realPart, a.imaginaryPart - b.imaginaryPart);
        }

        public static ComplexNumber operator * (ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.realPart * b.realPart - a.imaginaryPart * b.imaginaryPart, a.realPart * b.imaginaryPart + a.imaginaryPart * b.realPart);
        }

        
        public static ComplexNumber operator / (ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber conjub = Conjugate(b);
            ComplexNumber tmp = a * conjub;
            ComplexNumber tmp2 = b * conjub;

            return new ComplexNumber(tmp.realPart / tmp2.realPart, tmp.imaginaryPart / tmp2.realPart);
        }
        
        #endregion
    }
}
