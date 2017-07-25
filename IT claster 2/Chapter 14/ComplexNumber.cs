using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chapter_14
{
    class ComplexNumber
    {
        private int value;

        public int RealPart { get; set; }
        public int ImaginaryPart { get; set; }

        public ComplexNumber ()
        {
            RealPart = 0;
            ImaginaryPart = 0;
        }
        public ComplexNumber (string complexNum)
        {
            //delete all sapces " "
            string pattern = " ";
            complexNum = Regex.Replace(complexNum, pattern, String.Empty);

            //check if it complex number
            Regex reg = new Regex("\\d+\\+i\\*\\d+");//x + i*y
            Match match1 = reg.Match(complexNum);
            //write real and imaginary parts
            if (match1.Success)
            {
                //Real part
                int realPartLenght = complexNum.IndexOf("+");
                try
                {
                    RealPart = Int32.Parse(complexNum.Substring(0, realPartLenght));
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Real part Overflow");
                }

                //Imaginary part
                int imaginaryPartIndex = complexNum.IndexOf("*") + 1;
                int imaginaryPartLenght = complexNum.Length - imaginaryPartIndex;
                try
                {
                    ImaginaryPart = Int32.Parse(complexNum.Substring(imaginaryPartIndex, imaginaryPartLenght));
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Imaginary part Overflow");
                }
            }
            else
                Console.WriteLine("It's not complex number");
        }

        public static ComplexNumber operator + (ComplexNumber cn1, ComplexNumber cn2)
        {
            int newRealPart = cn1.RealPart + cn2.RealPart;
            int newImaginaryPart = cn1.ImaginaryPart + cn2.ImaginaryPart;
            return new ComplexNumber() { RealPart = newRealPart, ImaginaryPart = newImaginaryPart };
        }

        public static ComplexNumber operator - (ComplexNumber cn1, ComplexNumber cn2)
        {
            int newRealPart = cn1.RealPart - cn2.RealPart;
            int newImaginaryPart = cn1.ImaginaryPart - cn2.ImaginaryPart;
            return new ComplexNumber() { RealPart = newRealPart, ImaginaryPart = newImaginaryPart };
        }

        public static bool operator == (ComplexNumber cn1, ComplexNumber cn2)
        {
            return (cn1.RealPart == cn2.RealPart &&
                    cn1.ImaginaryPart == cn2.ImaginaryPart) ? true : false;
        }

        public static bool operator !=(ComplexNumber cn1, ComplexNumber cn2)
        {
            return (cn1.RealPart == cn2.RealPart &&
                    cn1.ImaginaryPart == cn2.ImaginaryPart) ? false : true;
        }

        public static bool operator > (ComplexNumber cn1, ComplexNumber cn2)
        {
            if (cn1.RealPart > cn2.RealPart)
                return true;
            else if (cn1.RealPart == cn2.RealPart && cn1.ImaginaryPart > cn2.ImaginaryPart)
                return true;
            else return false;
        }

        public static bool operator < (ComplexNumber cn1, ComplexNumber cn2)
        {
            if (cn1.RealPart < cn2.RealPart)
                return true;
            else if (cn1.RealPart == cn2.RealPart && cn1.ImaginaryPart < cn2.ImaginaryPart)
                return true;
            else return false;
        }


        public static explicit operator ComplexNumber(string strCn)
        {
            return new ComplexNumber(strCn);
        }

        public static implicit operator String(ComplexNumber cn)
        {
            return $"{cn.RealPart} + i*{cn.ImaginaryPart}";
        }



        public override string ToString()
        {
            return $"{RealPart} + i*{ImaginaryPart}";
        }
    }
}
