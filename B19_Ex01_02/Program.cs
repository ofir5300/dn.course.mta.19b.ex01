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

        public static void PrintTree(int i_ToPrint, int i_InitialSize)
        {
            if (i_ToPrint <= 0)
            {
                return;
            }

            // Top part
            printClockLine(i_ToPrint, i_InitialSize);

            // Recursive call
            PrintTree(i_ToPrint - 2, i_InitialSize);
            
            // Bottom part
            if(i_ToPrint != 1 && i_ToPrint != 2)
            {
                printClockLine(i_ToPrint, i_InitialSize);
            }
        }

        private static void printClockLine(int i_ToPrint, int i_InitialSize)
        {
            int i_OneSideSpaces = (i_InitialSize - i_ToPrint) / 2;
            int i;

            // left side spaces
            for (i = 0; i < i_OneSideSpaces; i++)
            {
                Console.Write(" ");
            }

            // print *
            for (i = 0; i < i_ToPrint; i++)
            {
                Console.Write("*");
            }

            // right side spaces
            for (i = 0; i < i_OneSideSpaces; i++)
            {
                Console.Write(" ");
            }

            Console.WriteLine(string.Empty);
        }
    }
}
