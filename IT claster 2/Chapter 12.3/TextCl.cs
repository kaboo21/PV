using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12._3
{
    class TextCl
    {
        public static void DisplayWordsRepeat(string str)
        {
            //position of the word in text
            int firstLetter = 0, lastLetter = 0, curentLenght = 0;
            //Current word
            string currentWord;
            //word repeat
            int wordRepeat;

            //Find and replace words
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
                            //find word
                            currentWord = str.Substring(firstLetter, curentLenght);
                            //count repeats of the word
                            wordRepeat = TextCl.WordRepeat(ref str, currentWord, lastLetter + 1);

                            Console.WriteLine($"{currentWord} - {wordRepeat} times");

                            i = lastLetter;

                            break;
                        }

            }

        }

        public static int WordRepeat(ref string str, string word, int startIndex)
        {
            int wordCounter = 1;
            //position of the word in text
            int firstLetterIndex, lastLetterIndex;

            for (int i = startIndex; i < str.Length; i++)
            {
                firstLetterIndex = str.IndexOf(word, i);
                lastLetterIndex = firstLetterIndex + word.Length - 1;
                if (firstLetterIndex >= 0)// find word
                {
                    //check is it word or part of the another word
                    if ((firstLetterIndex==0|| !Char.IsLetter(str[firstLetterIndex -1])) && 
                        (lastLetterIndex == str.Length - 1 || !Char.IsLetter(str[lastLetterIndex + 1])))
                    {
                        wordCounter++;
                        str = str.Remove(firstLetterIndex, word.Length);
                        i = firstLetterIndex - 1;
                    }
                }
            }
            return wordCounter;
        }
    }
}
