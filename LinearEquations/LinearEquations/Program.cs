using System;

namespace LinearEquations
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            IConsoleInput consoleInput = new ConsoleInput();
            ISeidelsMethod seidel = new SeidelsMethod();
            double[,] array = consoleInput.ConsoleReadDate(out size);
            double[] res = seidel.calculate(array, size);
            
            Console.ReadKey();
        }
    }
}
