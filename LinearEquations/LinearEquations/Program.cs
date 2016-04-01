using System;

namespace LinearEquations
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            IConsoleInput consoleInput = new ConsoleInput();
            double[,] array = consoleInput.ConsoleReadDate(out size);
            Console.WriteLine(array[0, 0]);
            Console.ReadKey();
        }
    }
}
