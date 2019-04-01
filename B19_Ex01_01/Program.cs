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
            string[] i_binaryInputArray = getInputFromUser();
            int[] i_decimalArray = new int[i_binaryInputArray.Length];
            int i_numberOfAscendingSerieses = 0;

            Console.WriteLine("The numbers you entered in decimal form are : ");
            for (int i = 0; i < i_binaryInputArray.Length; i++)
            {
                Console.WriteLine(i_decimalArray[i] = convertBinaryToDecimal(i_binaryInputArray[i]));
            }
            Console.WriteLine("Avarage apearences of 0's in each binary number : {0}\n" +
                    "Avarage apearences of 1's in each binary number : {1}",
                    calculateAvarageDigitAppearances(i_binaryInputArray, 0), calculateAvarageDigitAppearances(i_binaryInputArray, 1));
            Console.WriteLine("The count of numbers which is a power of 2 is : " + countPowerOf2Numbers(i_decimalArray));
            for (int i = 0; i < i_decimalArray.Length; i++)
            {
                if (isNumberAnAscendingSeries(i_decimalArray[i]))
                {
                    i_numberOfAscendingSerieses++;
                }
            }
            Console.WriteLine("The count of numbers which is a ascending series is : " + i_numberOfAscendingSerieses);
            Console.WriteLine("The avarage of the given numers is : " + calculateDecimalAvarage(i_decimalArray));
            Console.ReadLine();
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
                if (i_binNumber[i] == '1')
                {
                    o_decNumber += (int)(Math.Pow(2, 7 - i));
                }
            }

            return o_decNumber;
        }

        private static int calculateAvarageDigitAppearances(String[] i_binNumbersArr, int i_digit)
        {
            int i_digitCount = 0, i_average;


            for (int i = 0; i < i_binNumbersArr.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i_binNumbersArr[i][j] == i_digit + '0')
                    {
                        i_digitCount++;
                    }
                }
            }

            i_average = i_digitCount / i_binNumbersArr.Length;

            return i_average;
        }

        private static bool isNumberAnAscendingSeries(int i_number)
        {
            int i_LSB;

            while (i_number != 0)
            {
                i_LSB = i_number % 10;
                i_number /= 10;

                if (i_LSB <= i_number % 10)
                {
                    return false;
                }
            }

            return true;
        }

        private static int calculateDecimalAvarage(int[] i_decNumbersArr)
        {
            int i_sum = 0;

            for (int i = 0; i < i_decNumbersArr.Length; i++)
            {
                i_sum += i_decNumbersArr[i];
            }

            return i_sum / i_decNumbersArr.Length;
        }



        private static int countPowerOf2Numbers(int[] i_decNumbersArr)
        {
            int o_counter = 0;

            for (int i = 0; i < i_decNumbersArr.Length; i++)
            {
                if ((int)Math.Sqrt(i_decNumbersArr[i]) == (double)Math.Sqrt(i_decNumbersArr[i]))
                {
                    o_counter++;
                }
            }

            return o_counter;
        }
    }
}