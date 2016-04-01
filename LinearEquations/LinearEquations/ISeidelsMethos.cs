
namespace LinearEquations
{
    public interface ISeidelsMethos
    {
        double[] calculate(double[,] array, int size);
        // Cтатический метод calculate принимает на вход
        // матрицу коэффициентов размера size*size+1, 
        // само значение размера матрицы size.
        // На выход должна быть возвращена одномерная 
        // матрица решений размера size
    }
}
