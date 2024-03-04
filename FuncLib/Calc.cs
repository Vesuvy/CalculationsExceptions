using System;
using ExceptionLib;

namespace FuncLib
{
    public class Calc
    {
        public static double CalculateFunction(double x, double N) // f(x) = 1 / (x - N)
        {
            if (Math.Abs(x - N) < double.Epsilon)
            {
                throw new DivideByZeroException("Ошибка: деление на ноль.");
            }
            if (x <= 0 || x > 10)
            {
                throw new OutOfRangMyException("Ошибка: x выходит за пределы диапазона."); //x выходит за пределы диапазона
            }
            return 1 / (x - N);
        }
    }
}

