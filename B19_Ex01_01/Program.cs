using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B19_Ex01_01
{
    class Program
    {
        public static void Main()
        {
            // functions: 
            // ilan
            /* private static int[] getInputFromUser
             * private int convertBinaryToDecimal(int i_binNumber)
             * private int calculateAvarageDigitAppearances(int[] i_binNumbersArr)
             * private int countPowerOf2Numbers(int[] i_binNumbersArr)
             * private int calculateDecimalAvarage(int[] i_decNumbersArr)
             * private bool checkValidInput(int i_input)
             */

        }

        private static int[] getInputFromUser()
        {
            int[] o_inputArray = new int[8];
            int i_inputCounter = 0;
            bool v_isValidInput = true;

            Console.WriteLine("Please enter 4 binary numbers with 8 digits each");
            do
            {
                Console.WriteLine("please enter value number {0}", i_inputCounter);     // input +1
                o_inputArray[i_inputCounter] = Console.ReadLine();

            } while (!v_isValidInput);

            return o_inputArray;
        }
    }
}
