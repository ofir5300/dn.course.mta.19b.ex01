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
            Console.WriteLine(convertBinaryToDecimal("00000011"));
        }

        private static string[] getInputFromUser()
        {
            string[] o_inputArray = new string[4];
            string i_input;
            int i_inputCounter;
            bool v_isValidInput = true;

            Console.WriteLine("Please enter 4 binary numbers with 8 digits each");
            for (i_inputCounter = 0; i_inputCounter < 4; i_inputCounter++)
            {
                do
                {
                    Console.WriteLine("please enter value number {0}: ", i_inputCounter + 1);
                    i_input = Console.ReadLine();       
                    v_isValidInput = checkValidInput(i_input);
                } while (!v_isValidInput);                      // procceed only if the current input is valid
                o_inputArray[i_inputCounter] = i_input;
            }

            return o_inputArray;
        }

        private static bool checkValidInput(string i_input)
        {
            if (i_input.Length != 8)
            {
                Console.WriteLine("The number has to be 8 digits length! Please insert a valid number");
                return false;
            }

            for (int i = 0; i < 8; i++)
            {
                if (i_input[i] != '0' && i_input[i] != '1')
                {
                    Console.WriteLine("All digit must be 1 or 0 in a binary number! Please insert a valid number");
                    return false;
                }
            }

            return true;
        }

        private static int convertBinaryToDecimal(String i_binNumber)
           { 
            int o_decNumber = 0;
            for (int i = 7; i >= 0; i--)
            {
                if(i_binNumber[i] == '1')
                {
                    o_decNumber += (int)(Math.Pow(2, 7 - i));
                }
            }

            return o_decNumber;
        }

        private int calculateAvarageDigitAppearances(String[] i_binNumbersArr, int i_digit)
        {
            int digitCount = 0, average;

            for(int i = 0; i < i_binNumbersArr.Length; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if (i_binNumbersArr[i][j] == Convert.ToChar(i_digit))
                    {
                        digitCount++;
                    }
                }
            }

            average = digitCount / i_binNumbersArr.Length;

            return average;
        }

        private int countPowerOf2Numbers(int[] i_decNumbersArr)
        {
            int counter = 0;

            for (int i = 0; i < i_decNumbersArr.Length; i++)
            {
                if(Math.Sqrt((double)i_decNumbersArr[i]) == Math.Sqrt(i_decNumbersArr[i]))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
