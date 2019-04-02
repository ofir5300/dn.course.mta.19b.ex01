using System;

namespace B19_Ex01_03
{
    public class Program
    {
        public static void Main()
        {
            string input;
            int i_ClockSize;

            Console.WriteLine("Please Enter the sand clock size: ");
            input = Console.ReadLine();

            while (!int.TryParse(input, out i_ClockSize))
            {
                Console.WriteLine("Please Enter a decimal number: ");
                input = Console.ReadLine();
            }

            B19_Ex01_02.Program.PrintTree(i_ClockSize, i_ClockSize);
            Console.ReadLine();
        }
    }
}
