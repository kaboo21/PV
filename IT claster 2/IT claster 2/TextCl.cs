using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_claster_2
{
    static class Text
    {
        public static void ReplaceWordsInText(ref string str, int wordleght, string someword)
        {
            //position of the word in text
            int firstLetter = 0, lastLetter = 0, curentLenght = 0;
            //diference between input and output words
            int wordDifference;

            //Replace words
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))//find start of the word
                    for (int j = i + 1; j < str.Length; j++)
                        if (!char.IsLetter(str[j]) || j == str.Length - 1)//find end of the word
                        {
                            firstLetter = i;
                            if (j != str.Length - 1)
                                lastLetter = j - 1;
                            else
                                lastLetter = j;
                            curentLenght = lastLetter - firstLetter + 1;
                            //find word that need to be replaced
                            if (curentLenght == wordleght)
                            {
                                str = str.Remove(firstLetter, curentLenght);
                                str = str.Insert(firstLetter, someword);
                                wordDifference = someword.Length - curentLenght;
                                i = j - 1 + wordDifference;
                            }
                            i = j;
                            break;
                        }

            }

        }
        public static void UpperWords(ref string str)
        {
            //position of the word in text
            int firstLetter = 0, lastLetter = 0;
            char tempChar;

            //Upper first letter of the words
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))//find start of the word
                    for (int j = i + 1; j < str.Length; j++)
                        if (!char.IsLetter(str[j]) || j == str.Length - 1)//find end of the word
                        {
                            firstLetter = i;
                            if (j != str.Length - 1)
                                lastLetter = j - 1;
                            else
                                lastLetter = j;
                            tempChar = Char.ToUpper(str[firstLetter]);

                            //Change first letter to upper case
                            str = str.Remove(firstLetter, 1);
                            str = str.Insert(firstLetter,  tempChar.ToString());
                            i = j - 1;
                            
                            i = j;
                            break;
                        }

            }
        }

    }
}
