using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B19_Ex01_05
{
    class Program
    {
        public static void Main()
        {
            /*
             * private static string getInputFromUser();
             * private static bool checkUserInput(string i_input);
             * private static int biggestDigitInString(string i_input);
             * private static int smallestDigitInString(string i_input);
             * 
             */
        }

        private static string getInputFromUser()
        {
            string i_input;

            Console.WriteLine("Please insert a 8 digit positive number");
            do
            {
                i_input = Console.ReadLine();
            } while (!checkUserInput(i_input));

            return i_input;
        }

        private static bool checkUserInput(string i_input)
        {
            int i_decimalInput;

            if (i_input.Length != 8)
            {
                Console.WriteLine("Your input is different than 8 digits, please try again");
                return false;
            }
            else if(!Int32.TryParse(i_input, out i_decimalInput))
            {
                Console.WriteLine("Your input is not a number, please try again");
                return false;
            }
            else if(i_decimalInput <= 0)
            {
                Console.WriteLine("Your input is not positive, please try again");
                return false;
            }

            return true;
        }


    }
}
