using System;

namespace B19_Ex01_02
{
    public class Program
    {
        public static void Main()
        {
            PrintTree(5, 5);
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
            if(i_toPrint != 1 && i_toPrint != 2)
            {
                printClockLine(i_toPrint, i_initialSize);
            }
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
