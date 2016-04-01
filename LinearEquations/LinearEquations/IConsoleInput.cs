﻿
namespace LinearEquations
{
    public interface IConsoleInput
    {
        public static int[,] ConsoleReadDate(out int size);
        /*
            Класс должен предоставлять статический метод для 
         * ввода данных с консоли. У пользователя спрашивают
         * размер СЛАУ, затем последовательно спрашивают 
         * коэффициенты системы. В результате меняется значение
         * поля size и возвращается матрица заполненных коэффициетов.
         */
    }
}