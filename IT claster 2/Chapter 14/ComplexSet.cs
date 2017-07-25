using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chapter_14
{
    class ComplexSet:IEnumerable
    {
        ArrayList NumBox = new ArrayList();

        public ComplexNumber this [int index]
        {
            get { return (ComplexNumber)NumBox[index]; }
            set { NumBox.Insert(index, value); }

        }

        public ComplexNumber this [string complexNum]
        {
            get
            {
                int realPart, imaginaryPart;
                string strComplexNum;

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
                    
                    realPart = Int32.Parse(complexNum.Substring(0, realPartLenght));
                   

                    //Imaginary part
                    int imaginaryPartIndex = complexNum.IndexOf("*") + 1;
                    int imaginaryPartLenght = complexNum.Length - imaginaryPartIndex;
                    
                    imaginaryPart = Int32.Parse(complexNum.Substring(imaginaryPartIndex, imaginaryPartLenght));

                    strComplexNum = $"{realPart} + i*{imaginaryPart}";
                    foreach (ComplexNumber ComNum in NumBox)
                        if (ComNum.ToString().Equals(strComplexNum))
                        {
                            return ComNum;
                        }
                        else return null;
                }
                else
                {
                    Console.WriteLine("It's not correct string index");
                }

                return null;
                    
            }

            set
            {
                int realPart, imaginaryPart;
                string strComplexNum;

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

                    realPart = Int32.Parse(complexNum.Substring(0, realPartLenght));


                    //Imaginary part
                    int imaginaryPartIndex = complexNum.IndexOf("*") + 1;
                    int imaginaryPartLenght = complexNum.Length - imaginaryPartIndex;

                    imaginaryPart = Int32.Parse(complexNum.Substring(imaginaryPartIndex, imaginaryPartLenght));

                    strComplexNum = $"{realPart} + i*{imaginaryPart}";
                    foreach (ComplexNumber ComNum in NumBox)
                        if (ComNum.ToString().Equals(strComplexNum))
                        {
                            int index = NumBox.IndexOf(ComNum);
                            NumBox.Insert(index, value);
                        }
                }
                else
                    Console.WriteLine("It's not correct string index");

            }
            
        }

        public IEnumerator GetEnumerator()
        {
            return NumBox.GetEnumerator();
        }
    }
}
