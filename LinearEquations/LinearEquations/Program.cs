using System;

namespace LinearEquations
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            IConsoleInput consoleInput;
            Console.WriteLine("Enter method of input data: Press f to input via FILE or another key to manual input:");
            if (Console.ReadKey(true).Key == ConsoleKey.F)
                consoleInput = new FileInput();
            else
                consoleInput = new ConsoleInput();
            ISeidelsMethod seidel = new SeidelsMethod();
            double[,] array = consoleInput.ConsoleReadDate(out size);
            double[] res = seidel.calculate(array, size);
            
            Console.ReadKey();
        }
    }
}
