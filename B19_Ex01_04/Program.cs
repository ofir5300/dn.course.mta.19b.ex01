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

        }

        private static int countLowerCaseLetters(String i_input)
        {
            int i_lowerCaseCounter = 0;
            if(!isOnlyEnglishLetters(i_input))
            {
                Console.WriteLine("The string is a number so it has no Lower Case letters");
                return 0;
            }
            for(int i = 0; i < i_input.Length; i++)
            {
               if(i_input[i] <= 'z' && i_input[i] >= 'a')
                {
                    i_lowerCaseCounter++;
                }
            }
            Console.WriteLine("The string consist {0} lower case letters", i_lowerCaseCounter);

            return i_lowerCaseCounter; 
        }

        private static bool isDivisibleBy3(String i_input)
        {
            int i_decimalInput;

            if(isOnlyDigits(i_input))
            {
                int.TryParse(i_input, out i_decimalInput);
                if(i_decimalInput % 3 != 0)
                {
                    Console.WriteLine("The number is divisible by 3");
                    return true;
                }
                else
                {
                    Console.WriteLine("The number is not divisible by 3");
                    return true;
                }
            }
            Console.WriteLine("The string is not a number so cannot be divide by 3");

            return false;
        }
    }
}
