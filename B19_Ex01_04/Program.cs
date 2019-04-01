using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B19_Ex01_04
{
    class Program
    {
        public static void Main()
        {

            /*
             * private static String getInputFromUser()
             * private static bool checkValidInput(String i_input)
             * private static bool isPalyndrom(String i_input)
             * private static bool isDivisibleBy3(String i_input)       V
             * private static int countLowerCaseLetters(String i_input)
             * 
             */

            String i_input = getInputFromUser();
            // isPalyndrom
            isDivisibleBy3(i_input);
            countLowerCaseLetters(i_input);

            Console.ReadLine();
        }

        private static int countLowerCaseLetters(String i_input)
        {
            int i_lowerCaseCounter = 0;
            if (!isOnlyEnglishLetters(i_input))
            {
                Console.WriteLine("The string is a number so it has no Lower Case letters");
                return 0;
            }
            for (int i = 0; i < i_input.Length; i++)
            {
                if (i_input[i] <= 'z' && i_input[i] >= 'a')
                {
                    i_lowerCaseCounter++;
                }
            }
            Console.WriteLine("The string consist {0} lower case letters", i_lowerCaseCounter);

            return i_lowerCaseCounter;
        }

        private static bool isDivisibleBy3(String i_input)
        {
            Int64 i_decimalInput;
            
            if (isOnlydigits(i_input))
            {
                Int64.TryParse(i_input, out i_decimalInput);

                if ((double)i_decimalInput % (double)3 == 0)
                {
                    Console.WriteLine("The number is divisble by 3");
                    return true;
                }
                else
                {
                    Console.WriteLine("The number is not divisble by 3");
                    return false;
                }
            }
            Console.WriteLine("The string is not a number so cannot be divide by 3");

            return false;
        }

        private static String getInputFromUser()
        {
            String i_input;
            Console.WriteLine("Please enter 12 letters or numbers:");
            i_input = Console.ReadLine();

            while (!checkValidInput(i_input))
            {
                Console.WriteLine("Please enter valid input:");
                i_input = Console.ReadLine();
            }

            return i_input;
        }

        private static bool checkValidInput(String i_input)
        {
            bool onlyLetters, onlyDigits, validLength;

            // check validity rules
            validLength = (i_input.Length == 12);
            onlyDigits = isOnlydigits(i_input);
            onlyLetters = isOnlyEnglishLetters(i_input);

            // return result
            if ((onlyLetters || onlyDigits) && validLength)
            {
                return true;
            }

            Console.WriteLine("The string should consist of only 12 numbers or only 12 English letters.");
            return false;
        }

        public static bool isOnlydigits(String i_input)
        {
            foreach (char c in i_input)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool isOnlyEnglishLetters(String i_input)
        {
            foreach (char c in i_input)
            {
                if (!Char.IsLetter(c))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool isPalyndrom(String i_input, int i_start, int i_end)
        {
            if(i_start == i_end)
            {
                return true;
            }

            if(i_input[i_start] != i_input[i_end])
            {
                return false;
            }

            return isPalyndrom(i_input, i_start - 1, i_end -1);
        }

    }
}

