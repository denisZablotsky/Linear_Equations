using System;

namespace LinearEquations
{
    public class ConsoleInput: IConsoleInput
    {
        public int[,] ConsoleReadDate(out int size)
        {
            size = 0;
            bool flag = true;
            string s;
            Console.WriteLine("Enter size of matrix: ");
            while (flag)
            {
                s = Console.ReadLine();
                if (int.TryParse(s, out size))
                {
                    if (size >= 0)
                        flag = false;
                    else
                        Console.WriteLine("Size of matrix its a positive number.");
                }
                else
                    Console.WriteLine("Not a number was entered.");
            }
            int[,] array = new int[size, size + 1];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size + 1; j++)
                {
                    flag = true;
                    while (flag)
                    {
                        Console.WriteLine("Enter {0}:{1} coef:", i, j);
                        s = Console.ReadLine();
                        if (int.TryParse(s, out array[i, j]))
                            flag = false;
                        else
                            Console.WriteLine("Not a number was entered.");
                    }
                }
            }
            return array;
        }
    }
}
