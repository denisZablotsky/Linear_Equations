using System;
using System.Text;
using System.IO;

namespace LinearEquations
{
    class FileInput: IConsoleInput
    {
        public double[,] ConsoleReadDate(out int size)
        {
            size = 0;
            string fileDir;
            double[,] array;
            string line;
            do{
                Console.WriteLine("Select a file for calculations.(Full path)");
                fileDir = Console.ReadLine();
            }while(!File.Exists(fileDir));
            StreamReader file = new StreamReader(fileDir);
            int.TryParse(file.ReadLine(), out size);
            array = new double[size, size + 1];
            int i = 0;
            while ((line = file.ReadLine()) != null && size != 0)
            {
                string[] numbers = line.Split(' ');
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i < size && j <= size)
                    {
                        if (!double.TryParse(numbers[j], out array[i, j]))
                        {
                            size = 0;
                            break;
                        }
                    }
                }
                i++;
            }
            file.Close();
            return array;
        }
    }
}
