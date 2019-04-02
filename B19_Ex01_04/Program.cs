using System;

namespace B19_Ex01_04
{
    public class Program
    {
        public static void Main()
        {
            string input = getInputFromUser();
            isPalyndrom(input);
            isDivisibleBy3(input);
            countLowerCaseLetters(input);

            Console.ReadLine();
        }

        private static int countLowerCaseLetters(string i_Input)
        {
            int lowerCaseCounter = 0;
            if (!isOnlyEnglishLetters(i_Input))
            {
                Console.WriteLine("The string is a number so it has no Lower Case letters");
                return 0;
            }

            for (int i = 0; i < i_Input.Length; i++)
            {
                if (i_Input[i] <= 'z' && i_Input[i] >= 'a')
                {
                    lowerCaseCounter++;
                }
            }

            Console.WriteLine("The string consist {0} lower case letters", lowerCaseCounter);

            return lowerCaseCounter;
        }

        private static bool isDivisibleBy3(string i_Input)
        {
            ulong decimalInput;

            if (isOnlydigits(i_Input))
            {
                ulong.TryParse(i_Input, out decimalInput);

                if ((double)decimalInput % (double)3 == 0)
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

        private static string getInputFromUser()
        {
            string o_Input;
            Console.WriteLine("Please enter 12 letters or numbers:");
            o_Input = Console.ReadLine();

            while (!checkValidInput(o_Input))
            {
                Console.WriteLine("Please enter valid input:");
                o_Input = Console.ReadLine();
            }

            return o_Input;
        }

        private static bool checkValidInput(string i_Input)
        {
            bool v_onlyLetters, v_onlyDigits, v_validLength;

            // check validity rules
            v_validLength = i_Input.Length == 12;
            v_onlyDigits = isOnlydigits(i_Input);
            v_onlyLetters = isOnlyEnglishLetters(i_Input);

            // return result
            if ((v_onlyLetters || v_onlyDigits) && v_validLength)
            {
                return true;
            }

            Console.WriteLine("The string should consist of only 12 numbers or only 12 English letters.");
            return false;
        }

        public static bool isOnlydigits(string i_Input)
        {
            foreach (char c in i_Input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool isOnlyEnglishLetters(string i_Input)
        {
            foreach (char c in i_Input)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }

            return true;
        }

        private static void isPalyndrom(string i_Input)
        {
            if (isOnlyEnglishLetters(i_Input))
            {
                Console.WriteLine(
                    "The string is {0} a palyndrom",
                    isPalyndromRecursive(i_Input, 0, i_Input.Length - 1) ? "indeed" : "not");
            }
            else
            {
                Console.WriteLine("The string is not a text so cannot be a palyndrom");
            }
        }

        private static bool isPalyndromRecursive(string i_Input, int i_Start, int i_End)
        {
            if (i_Start >= i_End)
            {
                return true;
            }

            if (i_Input[i_Start] != i_Input[i_End])
            {
                return false;
            }

            return isPalyndromRecursive(i_Input, i_Start + 1, i_End - 1);
        }
    }
}