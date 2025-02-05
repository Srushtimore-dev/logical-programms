using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programms
{
    public class StringExamples
    {

        public string AcceptString()
        {
            Console.WriteLine("Enter string minor changes");
            string str = Console.ReadLine();
            return str;
        }
        public void StrReverse()
        {
            Console.WriteLine("please enter string");
            string str = Console.ReadLine();


            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }



        public void CharCount()
        {
            Console.WriteLine("plese enter the string");
            String str = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                count++;
            }
            Console.WriteLine("charactr count" + count);
        }


        public void SmallCharactercount()
        {
            String str = "SHUbham";
            int smallcount = 0;
            int capcount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    smallcount++;
                }
                else
                {
                    capcount++;
                }

            }
            Console.WriteLine("capital characters count : " + capcount);
            Console.WriteLine("small characters count : " + smallcount);
        }

        public string ReverseWordsManually()
        {
            string sentence = AcceptString().Trim();
            string result = "";
            int wordStart = 0;
            for (int i = 0; i <= sentence.Length; i++)
            {  // Identify the end of a word (or end of the string)
                if (i == sentence.Length || sentence[i] == ' ')
                { // Reverse the characters in the current word
                    for (int j = i - 1; j >= wordStart; j--)
                    {
                        if(sentence[j] != ' ')
                        {
                            result = result + sentence[j];
                        }
                    }
                    // Add a space after the word (except for the last word)
                    if (i != sentence.Length)
                    {
                        if (result[result.Length - 1] != ' ')
                        result += " ";
                    }
                    // Move the start to the next word
                    wordStart = i + 1;

                }
            }

            Console.WriteLine(result);
            return result;
        }


        public void removeDupuplicateCharacter()
        {
            string str = AcceptString().Trim();
            string res = "";
            for (int i = 0; i < str.Length; i++)
            {
                bool isduplicate = false;

                for (int j = 0; j < res.Length; j++)
                {
                    if (str[i] == res[j])
                    {
                        isduplicate = true;
                    }

                }

                if (!isduplicate)
                {
                    res = res + str[i];
                }
            }

            Console.WriteLine(res);
        }





       
    }
}
