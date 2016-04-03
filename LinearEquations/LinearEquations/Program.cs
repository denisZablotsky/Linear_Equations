using System;

namespace LinearEquations
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            double[,] array = new double[1, 1];
            IConsoleInput consoleInput;
            Console.WriteLine("Enter method of input data: Press f to input via FILE or another key to manual input:");
            if (Console.ReadKey(true).Key == ConsoleKey.F)
                consoleInput = new FileInput();
            else
                consoleInput = new ConsoleInput();
            ISeidelsMethod seidel = new SeidelsMethod();
            while(size == 0)
                array = consoleInput.ConsoleReadDate(out size);
            printSystem(array, size);

            double[] res = seidel.calculate(array, size);
            
            Console.ReadKey();
           
        }
        static void printSystem(double[,] array, int size)
        {
            Console.WriteLine(" /");
            for(int i = 0; i < size; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < size; j++)
                    if (array[i, j] < 0 || j == 0)
                        Console.Write("{0}x{1} ", array[i, j], (j + 1).ToString());
                    else
                        Console.Write("+ {0}x{1} ", array[i, j], (j + 1).ToString());
                Console.WriteLine(" = " + array[i, size].ToString());
            }
            Console.WriteLine(" \\");
        }
    }
}
