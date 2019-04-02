using System;

namespace B19_Ex01_01
{
    class Program
    {
        public static void Main()
        {
            string[] binaryInputArray = getInputFromUser();
            int[] decimalArray = new int[binaryInputArray.Length];
            int numberOfAscendingSerieses = 0;

            Console.WriteLine("The numbers you entered in decimal form are : ");
            for (int i = 0; i < binaryInputArray.Length; i++)
            {
                Console.WriteLine(decimalArray[i] = convertBinaryToDecimal(binaryInputArray[i]));
            }
            Console.WriteLine("Avarage apearences of 0's in each binary number : {0}\n" +
                    "Avarage apearences of 1's in each binary number : {1}",
                    calculateAvarageDigitAppearances(binaryInputArray, 0), calculateAvarageDigitAppearances(binaryInputArray, 1));
            Console.WriteLine("The count of numbers which is a power of 2 is : " + countPowerOf2Numbers(decimalArray));
            for (int i = 0; i < decimalArray.Length; i++)
            {
                if (isNumberAnAscendingSeries(decimalArray[i]))
                {
                    numberOfAscendingSerieses++;
                }
            }
            Console.WriteLine("The count of numbers which is a ascending series is : " + numberOfAscendingSerieses);
            Console.WriteLine("The avarage of the given numers is : " + calculateDecimalAvarage(decimalArray));
            Console.ReadLine();
        }

        private static string[] getInputFromUser()
        {
            string[] o_InputArray = new string[4];
            string Input;
            int i_InputCounter;
            bool v_isValidInput = true;

            Console.WriteLine("Please enter 4 binary numbers with 8 digits each");
            for (i_InputCounter = 0; i_InputCounter < 4; i_InputCounter++)
            {
                do
                {
                    Console.WriteLine("please enter value number {0}: ", i_InputCounter + 1);
                    Input = Console.ReadLine();
                    v_isValidInput = checkValidInput(Input);
                } while (!v_isValidInput);                      // procceed only if the current input is valid
                o_InputArray[i_InputCounter] = Input;
            }

            return o_InputArray;
        }

        private static bool checkValidInput(string i_Input)
        {
            if (i_Input.Length != 8)
            {
                Console.WriteLine("The number has to be 8 digits length! Please insert a valid number");
                return false;
            }

            for (int i = 0; i < 8; i++)
            {
                if (i_Input[i] != '0' && i_Input[i] != '1')
                {
                    Console.WriteLine("All digit must be 1 or 0 in a binary number! Please insert a valid number");
                    return false;
                }
            }

            return true;
        }

        private static int convertBinaryToDecimal(string i_BinNumber)
        {
            int o_DecNumber = 0;
            for (int i = 7; i >= 0; i--)
            {
                if (i_BinNumber[i] == '1')
                {
                    o_DecNumber += (int)(Math.Pow(2, 7 - i));
                }
            }

            return o_DecNumber;
        }

        private static int calculateAvarageDigitAppearances(string[] i_BinNumbersArr, int i_Digit)
        {
            int i_digitCount = 0, i_average;


            for (int i = 0; i < i_BinNumbersArr.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i_BinNumbersArr[i][j] == i_Digit + '0')
                    {
                        i_digitCount++;
                    }
                }
            }

            i_average = i_digitCount / i_BinNumbersArr.Length;

            return i_average;
        }

        private static bool isNumberAnAscendingSeries(int i_Number)
        {
            int i_LSB;

            while (i_Number != 0)
            {
                i_LSB = i_Number % 10;
                i_Number /= 10;

                if (i_LSB <= i_Number % 10)
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



        private static int countPowerOf2Numbers(int[] i_DecNumbersArr)
        {
            int o_Counter = 0;

            for (int i = 0; i < i_DecNumbersArr.Length; i++)
            {
                if ((int)Math.Sqrt(i_DecNumbersArr[i]) == (double)Math.Sqrt(i_DecNumbersArr[i]))
                {
                    o_Counter++;
                }
            }

            return o_Counter;
        }
    }
}