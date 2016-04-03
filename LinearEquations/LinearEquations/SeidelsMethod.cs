using System;

namespace LinearEquations
{
    class SeidelsMethod: ISeidelsMethod
    {
        public double[] calculate(double[,] array, int size)
        {
            double eps = 0.001;
            double[] results = new double[size];
            double[] modifyedFreeValues = new double[size];
            // Modification of matrix
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= size; j++)
                {
                    if (i != j)
                        array[i, j] = array[i, j] / array[i, i];
                    if (j == size)
                        results[i] = array[i, j];
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
          
            for (int q = 0; q < 6; q++)
            {
                for (int i = 0; i < size; i++)
                {
                    modifyedFreeValues[i] = results[i];
                    results[i] = 0;
                }
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (i != j)
                            results[i] -= (array[i, j] * modifyedFreeValues[j]);
                        else
                            results[i] += modifyedFreeValues[j];
                    }
                }
                for (int i = 0; i < size; i++)
                    Console.Write(results[i] + " ");
                Console.WriteLine("****");
            }
            return results;
        }
        
    }
}
