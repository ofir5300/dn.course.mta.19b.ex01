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
             * private static bool isDivisibleBy3(String i_input)
             * private static int countLowerCaseLetters(String i_input)
             * 
             */

        }

        private static bool isDivisibleBy3(String i_input)
        {
            int i_decimalInput;

            if(!int.TryParse(i_input, out i_decimalInput))              // if the string cannot be convert to int it cannot by divide by 3
            {
                return false;
            }
            else if(i_decimalInput % 3 != 0)                            
            {
                return false;
            }

            return true;
        }
    }
}
