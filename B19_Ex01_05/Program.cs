using System;

namespace B19_Ex01_05
{
    class Program
    {
        public static void Main()
        {
            string i_input = getInputFromUser();
            Console.WriteLine("The biggest digit in the number given is : " + biggestDigitInString(i_input));
            Console.WriteLine("The smallest digit in the number given is : " + smallestDigitInString(i_input));
            Console.WriteLine("The count of digits which can be divide by 3 is : " + countDivisibleBy3Numbers(i_input));
            Console.WriteLine("The count of digits which is bigger than the least significant digit is: " + countDigitsBiggerThanLSD(i_input));

            Console.ReadLine();
        }

        private static int biggestDigitInString(string i_Input)
        {
            int biggestDigit = i_Input[0] - '0', currentDigit;
            foreach (char c in i_Input)
            {
                currentDigit = c - '0';
                if(biggestDigit < currentDigit)
                {
                    biggestDigit = currentDigit;
                }
            }

            return biggestDigit;
        }

        private static int smallestDigitInString(string i_Input)
        {
            int o_SmallestDigit = i_Input[0] - '0', currentDigit;
            foreach (char c in i_Input)
            {
                currentDigit = c - '0';
                if (o_SmallestDigit > currentDigit)
                {
                    o_SmallestDigit = currentDigit;
                }
            }

            return o_SmallestDigit;
        }

        private static int countDivisibleBy3Numbers(string i_Input)
        {
            int o_Counter = 0, currentDigit;

            foreach (char c in i_Input)
            {
                currentDigit = c - '0';
                if((double)currentDigit % 3 == 0)
                {
                    o_Counter++;
                }
            }

            return o_Counter;
        }

        private static int countDigitsBiggerThanLSD(string i_Input)
        {
            int o_Counter = 0;
            int currentDigit;
            int lsd = i_Input[7] - '0';

            foreach (char c in i_Input)
            {
                currentDigit = c - '0';
                if (currentDigit > lsd)
                {
                    o_Counter++;
                }
            }

            return o_Counter;
        }

        private static string getInputFromUser()
        {
            string io_Input;

            Console.WriteLine("Please insert a 8 digit positive number");
            do
            {
                io_Input = Console.ReadLine();
            } while (!checkUserInput(io_Input));

            return io_Input;
        }

        private static bool checkUserInput(string i_Input)
        {
            int i_DecimalInput;

            if (i_Input.Length != 8)
            {
                Console.WriteLine("Your input is different than 8 digits, please try again");
                return false;
            }
            else if(!Int32.TryParse(i_Input, out i_DecimalInput))
            {
                Console.WriteLine("Your input is not a number, please try again");
                return false;
            }
            else if(i_DecimalInput <= 0)
            {
                Console.WriteLine("Your input is not positive, please try again");
                return false;
            }

            return true;
        }


    }
}
