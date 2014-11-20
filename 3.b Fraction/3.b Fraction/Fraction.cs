using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.b_Fraction
{
    public class Fraction
    {
        private int _numerator;
        private int _denominator;
        private int _numerator2;
        private int _denominator2;

        public int Numerator
        {
            get { return _numerator; }
            set { _numerator = value; }
        }
        public int Denominator
        {
            get { return _denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("Måste ange ett tal över 0");
                }
                _denominator = value;
            }
        }
        public int Numerator2
        {
            get { return _numerator2; }
            set { _numerator2 = value; }
        }
        public int Denominator2
        {
            get { return _denominator2; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("Måste ange ett tal över 0");
                }
                _denominator2 = value;
            }
        }
        
        public Fraction(int numerator, int denominator) : this(numerator, denominator,1,1)
        {
            
        }
        public Fraction(int numerator, int denominator, int numerator2, int denominator2)
        {
            Numerator = numerator;
            Denominator = denominator;
            Numerator2 = numerator2;
            Denominator2 = denominator2;
        }

        
        public void Add()
        {                          
            Numerator = (Numerator * Denominator2) + (Numerator2 * Denominator);
            Denominator = (Denominator * Denominator2);           
        }
        public void Multiply()
        {
            Numerator = Numerator * Numerator2;
            Denominator = Denominator * Denominator2;
        }

        public bool isEqualTo()
        {
            int compareNumerator;
            compareNumerator = Numerator2 * Denominator;        
            Numerator = Numerator * Denominator2;
            if (compareNumerator == Numerator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", Numerator, Denominator);
        }


    }
}
