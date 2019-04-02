using System;


namespace B19_Ex01_03
{
    class Program
    {
        public static void Main()
        {
            String i_input;
            int i_clockSize;

            Console.WriteLine("Please Enter the sand clock size: ");
            i_input = Console.ReadLine();

            while (!int.TryParse(i_input, out i_clockSize))
            {
                Console.WriteLine("Please Enter a decimal number: ");
                i_input = Console.ReadLine();
            }

            B19_Ex01_02.Program.PrintTree(i_clockSize, i_clockSize);
            Console.ReadLine();
        }
    }
}
