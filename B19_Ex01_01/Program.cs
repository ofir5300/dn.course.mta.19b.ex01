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
            /* private static int[] getInputFromUser
             * private int convertBinaryToDecimal(int i_binNumber)
             * private int calculateAvarageDigitAppearances(int[] i_binNumbersArr)
             * private int countPowerOf2Numbers(int[] i_binNumbersArr)
             * private int calculateDecimalAvarage(int[] i_decNumbersArr)
             * private bool checkValidInput(int i_input)
             */

        }

        private int convertBinaryToDecimal(int i_binNumber)
        {
            int o_decNumber = 0;

            for(int i = 0; i < 8; i++)
            {
                o_decNumber += (i_binNumber % 10) * (int)(Math.Pow(2, i));
                i_binNumber /= 10;
            }

            return o_decNumber;
        }

    }
}
