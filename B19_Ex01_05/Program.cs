using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B19_Ex01_05
{
    class Program
    {
        public static void Main()
        {
            /*
             * private static string getInputFromUser();
             * private static bool checkUserInput(string i_input);
             * private static int biggestDigitInString(string i_input);
             * private static int smallestDigitInString(string i_input);
             * 
             */
        }

        private static int biggestDigitInString(string i_input)
        {
            int o_biggestDigit = i_input[0], i_currentDigit;
            foreach (char c in i_input)
            {
                i_currentDigit = c - '0';
                if(o_biggestDigit < i_currentDigit)
                {
                    o_biggestDigit = i_currentDigit;
                }
            }

            return o_biggestDigit;
        }

        private static int smallestDigitInString(string i_input)
        {
            int o_smallestDigit = i_input[0], i_currentDigit;
            foreach (char c in i_input)
            {
                i_currentDigit = c - '0';
                if (o_smallestDigit > i_currentDigit)
                {
                    o_smallestDigit = i_currentDigit;
                }
            }

            return o_smallestDigit;
        }

        private static int countDivisibleBy3Numbers(String i_input)
        {
            int o_counter = 0, i_currentDigit;

            foreach (char c in i_input)
            {
                i_currentDigit = c - '0';
                if((double)i_currentDigit % 3 == 0)
                {
                    o_counter++;
                }
            }

            return o_counter;
        }

        private static int countDigitsBiggetThanLSD(String i_input)
        {
            int o_counter = 0;
            int i_currentDigit;
            int lsd = i_input[7] - '0';

            foreach (char c in i_input)
            {
                i_currentDigit = c - '0';
                if (i_currentDigit > lsd)
                {
                    o_counter++;
                }
            }

            return o_counter;
        }
    }
}
