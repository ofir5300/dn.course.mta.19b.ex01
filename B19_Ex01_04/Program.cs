﻿using System;
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

        private static bool isDivisibleBy3(String i_input)
        {
            int i_decimalInput;

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
                if (isOnlyDigits(i_input))
                {
                    int.TryParse(i_input, out i_decimalInput);
                    if (i_decimalInput % 3 != 0)
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
