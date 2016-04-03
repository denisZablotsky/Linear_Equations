using System;
using System.Text;

namespace LinearEquations
{
    class FileInput: IConsoleInput
    {
        double[,] ConsoleReadDate(out int size)
        {
            size = 0;
            double[,] array = new double[size, size+1];

            return array;
        }
    }
}
