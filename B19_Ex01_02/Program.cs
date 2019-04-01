using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B19_Ex01_02
{
    class Program
    {
        public static void Main()
        {
            String i_input;
            int i_clockSize;

            Console.WriteLine("Please Enter the sand clock size: ");
            i_input = Console.ReadLine();

            while(!int.TryParse(i_input, out i_clockSize))
            {
                Console.WriteLine("Please Enter a decimal number: ");
                i_input = Console.ReadLine();
            }

            PrintTree(i_clockSize, i_clockSize);
            Console.ReadLine();
        }

        public static void PrintTree(int i_toPrint, int i_initialSize)
        {
            if (i_toPrint <= 0)
            {
                return;
            }

            // Top part
            printClockLine(i_toPrint, i_initialSize);
            // Recursive call
            PrintTree(i_toPrint - 2, i_initialSize);
            // Bottom part
            printClockLine(i_toPrint, i_initialSize);
        }

        private static void printClockLine(int i_toPrint, int i_initialSize)
        {
            int i_oneSideSpaces = (i_initialSize - i_toPrint) / 2;
            int i;

            // left side spaces
            for (i = 0; i < i_oneSideSpaces; i++)
            {
                Console.Write(" ");
            }

            // print *
            for (i = 0; i < i_toPrint; i++)
            {
                Console.Write("*");
            }

            // right side spaces
            for (i = 0; i < i_oneSideSpaces; i++)
            {
                Console.Write(" ");
            }

            Console.WriteLine("");
        }
    }
}
