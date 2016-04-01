using System;

namespace LinearEquations
{
    class SeidelsMethod: ISeidelsMethod
    {
        public double[] calculate(double[,] array, int size)
        {
            double eps = 0.01;
            double[] results = new double[size];
            bool flag = true;
            double[] currentValues = new double[size];
            while (flag)
            {
                for (int i = 0; i < size; i++)
                     results[i] = currentValues[i];
                    currentValues = new double[size];
                for (int i = 0; i < size; i++)
                {
                    double var = 0;
                    for (int j = 0; j < i; j++)
                        var += (array[i, j] * currentValues[j]);
                    for (int j = i + 1; j < size; j++)
                        var += (array[i, j] * results[j]);
                    currentValues[i] =(double)((array[i, size] - var) / array[i, i]);
                }
                double norm = 0;
                for (int i = 0; i < size; i++)
                    norm += Math.Abs(currentValues[i] - results[i]);
                if (norm < eps)
                    flag = false;  
            }
            return results;
        }
       
    }
}
